using Catalog.Api.Infrastructure;
using Catalog.Api.Infrastructure.Entites;
using Catalog.Api.Infrastructure.Entities;
using Catalog.Api.Models.RequestModel;
using Catalog.Api.Models.ResponseModel;
using Catalog.Api.Service.CloudinaryService;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/products")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly CatalogContext _context;

        public ProductController(CatalogContext context, ILogger<ProductController> logger, ICloudinaryService cloudinaryService)
        {
            _context = context;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductRequest req)
        {
            var response = new PaginationResponse<GetListProductResponse>();

            if (req.Min > req.Max)
            {
                return Ok(response);
            }

            var brands = new List<int>();
            if (req.Brands != null)
            {
                brands = req.Brands
                    .Replace(" ", string.Empty)
                    .Split(",")
                    .Select(i => Convert.ToInt32(i))
                    .ToList();
            }

            var categories = new List<int>();
            if (req.Categories != null)
            {
                categories = req.Categories
                    .Replace(" ", string.Empty)
                    .Split(",")
                    .Select(i => Convert.ToInt32(i))
                    .ToList();
            }

            var queryable = _context.Products
                .Where(product => req.Min == null || product.Price >= req.Min)
                .Where(product => req.Max == null || product.Price <= req.Max)
                .Where(product => !brands.Any() || brands.Contains(product.CategoryId))
                .Where(product => !categories.Any() || categories.Contains(product.CategoryId))
                .Where(product => string.IsNullOrEmpty(req.Sku) || product.Sku.Equals(req.Sku))
                .Where(product => string.IsNullOrEmpty(req.Keyword) || product.Name.Contains(req.Keyword)
                                                                    || product.Description.Contains(req.Keyword)
                                                                    || product.Sku.Contains(req.Keyword))
                .Skip((req.Page - 1) * req.Limit)
                .Take(req.Limit)
                .AsNoTracking();

            var sortByList = new Dictionary<string, string>
            {
                ["id"] = nameof(Product.Id),
                ["price"] = nameof(Product.Price),
                ["date_modified"] = nameof(Product.LastModified),
            };

            if (sortByList[req.SortBy] == nameof(Product.Price))
            {
                queryable = req.SortDescending ?
                    queryable.OrderBy(product => product.Price) :
                    queryable.OrderByDescending(product => product.Price);
            }
            else if (sortByList[req.SortBy] == nameof(Product.LastModified))
            {
                queryable = req.SortDescending ?
                    queryable.OrderBy(product => product.LastModified) :
                    queryable.OrderByDescending(product => product.LastModified);
            }

            var products = await queryable.ToListAsync();

            var productsDto = products.Select(product =>
                new GetListProductResponse
                {
                    Id = product.Id,
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    BrandId = product.BrandId,
                    Discount = product.Discount,
                    Name = product.Name,
                    ImageUrl = product.ImageUrl,
                    ReviewsCount = product.ReviewsCount,
                    Star = product.Star,
                    TotalBuyers = product.TotalBuyers,
                    Sku = product.Sku,
                    Summary = product.ShortDescription,
                }).ToList();

            var totalProducts = await _context.Products.CountAsync();
            var totalPage = req.Limit != 1 ? totalProducts / req.Limit + 1 : 0;

            response = new PaginationResponse<GetListProductResponse>
            {
                Data = productsDto,
                Meta = new Pagination
                {
                    Count = productsDto.Count(),
                    CurrentPage = req.Page,
                    Total = totalProducts,
                    TotalPages = totalPage,
                    PerPage = req.Limit
                }
            };

            return Ok(response);
        }

        [HttpGet("products/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.ProductVariant)
                .ThenInclude(pv => pv.VariantOptions)
                .ThenInclude(vo => vo.OptionType)
                .SingleOrDefaultAsync(p => p.Id == id);

            if (product is null)
            {
                return Problem("Not exist product");
            }

            var variantsResponse = new List<GetProductByIdResponse.Variant>();

            foreach (var productVariant in product.ProductVariant)
            {
                var variantList = productVariant.VariantOptions.Select(v => new GetProductByIdResponse.Variant
                {
                    OptionType = v.OptionType.Name,
                    OptionTypeId = v.OptionTypeId,
                    OptionValue = v.OptionValue,
                    ProductId = productVariant.ProductId,
                    ProductVariantId = productVariant.Id,
                    Sku = productVariant.Sku,
                });
                variantsResponse.AddRange(variantList);
            }

            var response = new GetProductByIdResponse
            {
                Id = product.Id,
                Name = product.Name,
                DescriptionSections = [product.Description],
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Discount = product.Discount,
                ReviewsCount = product.ReviewsCount,
                Star = product.Star,
                TotalBuyers = product.TotalBuyers,
                Sku = product.Sku,
                ShortDescription = product.ShortDescription,
                Brand = new()
                {
                    BrandId = product.BrandId,
                    BrandName = product.Brand?.Name,
                    ThumbnailUrl = product.Brand?.AvatarUrl,
                    Code = product.Brand.Code,
                },
                Category = new()
                {
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category?.Name,
                    ThumbnailUrl = product.Category?.ThumbnailUrl,
                    Code = product.Category?.Code,
                },
                Variants = variantsResponse,
            };

            return Ok(response);
        }


        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var productEntity = req.Adapt<Product>();

            try
            {
                //await _unitOfWork.ProductRepository.Create(productEntity);
                //await _unitOfWork.Commit();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPatch("products/{id}")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] int id,
            [FromBody] UpdateProductRequest req)
        {
            var productEntity = await _context.Products.FindAsync(req.Id);

            if (productEntity is null)
            {
                return Problem("Not exist product");
            }

            productEntity.Name = req.Name;
            productEntity.Price = req.Price;
            productEntity.CategoryId = req.CategoryId;
            productEntity.BrandId = req.BrandId;
            productEntity.Sku = req.Sku;
            productEntity.Description = req.Description;
            productEntity.ShortDescription = req.Summary;
            productEntity.Discount = req.Discount;
            productEntity.ImageUrl = req.ImageUrl;

            productEntity.SetTimeLastModified();

            try
            {
                //_unitOfWork.ProductRepository.Update(productEntity);
                //await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            var productEntity = await _context.Products.FindAsync(id);

            if (productEntity is null)
            {
                return Problem("Not exists product");
            }

            try
            {
                //_unitOfWork.ProductRepository.Update(productEntity);
                //await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
