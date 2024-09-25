using Catalog.Api.Data.Entities;
using Catalog.Api.Models.ResponseModel;
using Catalog.Api.Service.CloudinaryService;
using Mapster;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/products")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly CatalogContext _context;
        private readonly IEventBus _eventBus;

        public ProductController(CatalogContext context, ILogger<ProductController> logger, ICloudinaryService cloudinaryService /*IEventBus eventBus*/)
        {
            _context = context;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
            //_eventBus = eventBus;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetListProductRequest req)
        {
            var response = new PaginationResponse<GetListProductResponse>();

            if (req.MinPrice > req.MaxPrice)
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

            var queryable = _context.Products.AsQueryable();

            if (req.MinPrice != null)
            {
                queryable = queryable.Where(product => product.Price >= req.MinPrice);
            }

            if (req.MaxPrice != null)
            {
                queryable = queryable.Where(product => product.Price <= req.MaxPrice);
            }

            if (brands.Any())
            {
                queryable = queryable.Where(product => brands.Contains(product.BrandId));
            }

            if (categories.Any())
            {
                queryable = queryable.Where(product => categories.Contains(product.CategoryId));
            }

            if (!string.IsNullOrEmpty(req.Sku))
            {
                queryable = queryable.Where(product => product.Sku.Equals(req.Sku));
            }

            if (!string.IsNullOrEmpty(req.Keyword))
            {
                queryable = queryable.Where(product =>
                    product.Name.Contains(req.Keyword) ||
                    product.Description.Contains(req.Keyword));
            }

            var sortByList = new Dictionary<string, string>
            {
                ["id"] = nameof(Product.Id),
                ["price"] = nameof(Product.Price),
                ["date_modified"] = nameof(Product.LastModified),
            };

            queryable = queryable
                .OrderBy(product => product.Id)
                .Skip((req.Page - 1) * req.Limit)
                .Take(req.Limit);


            queryable = sortByList[req.SortBy] switch
            {
                nameof(Product.Id) => req.SortDescending
                    ? queryable.OrderBy(product => product.Id)
                    : queryable.OrderByDescending(product => product.Id),
                nameof(Product.LastModified) => req.SortDescending
                    ? queryable.OrderBy(product => product.LastModified)
                    : queryable.OrderByDescending(product => product.LastModified),
                nameof(Product.Price) => req.SortDescending
                    ? queryable
                    : queryable.OrderByDescending(product => product.Price),
                _ => queryable
            };

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
                    ImageUrl = product.ThumbnailUrl,
                    ReviewsCount = product.ReviewCount,
                    Star = product.RatingAverage,
                    TotalBuyers = product.TotalBuyer,
                    Sku = product.Sku,
                    Summary = product.ShortDescription,
                }).ToList();

            var totalProducts = await _context.Products.CountAsync();
            var totalPage = req.Limit != 0 ? (totalProducts / req.Limit) + 1 : 0;
            response = new PaginationResponse<GetListProductResponse>
            {
                Data = productsDto,
                Meta = new Pagination
                {
                    Count = productsDto.Count,
                    CurrentPage = req.Page,
                    Total = totalProducts,
                    TotalPages = totalPage,
                    PerPage = req.Limit
                }
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.ProductVariant)
                .ThenInclude(pv => pv.Options)
                .ThenInclude(vo => vo.OptionType)
                .SingleOrDefaultAsync(p => p.Id == id);

            if (product is null)
            {
                return Problem("Not exist product");
            }

            var variantsResponse = new List<GetProductByIdResponse.Variant>();

            foreach (var productVariant in product.ProductVariant)
            {
                var variantList = productVariant.Options.Select(v => new GetProductByIdResponse.Variant
                {
                    OptionType = v.OptionType.Name,
                    OptionTypeId = v.OptionTypeId,
                    OptionValue = v.Value,
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
                ImageUrl = product.ThumbnailUrl,
                Discount = product.Discount,
                ReviewsCount = product.ReviewCount,
                Star = product.RatingAverage,
                TotalBuyers = product.TotalBuyer,
                Sku = product.Sku,
                ShortDescription = product.ShortDescription,
                Brand = new()
                {
                    BrandId = product.BrandId,
                    BrandName = product.Brand?.Name,
                },
                Category = new()
                {
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category?.Name,
                    ThumbnailUrl = product.Category?.ThumbnailUrl,
                },
                Variants = variantsResponse,
            };

            return Ok(response);
        }


        [HttpPost("")]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var brand = await _context.Brands.SingleOrDefaultAsync(b => b.Id == req.BrandId);
            if (brand is null)
            {
                return Problem("Invalid Brand Id");
            }

            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == req.CategoryId);
            if (category is null)
            {
                return Problem("Invalid Category Id");
            }

            var product = req.Adapt<Product>();
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] int id,
            [FromBody] UpdateProductRequest req)
        {
            var product = await _context.Products.FindAsync(req.Id);

            if (product is null)
            {
                return Problem("Not exist product");
            }

            var brand = await _context.Brands.SingleOrDefaultAsync(b => b.Id == req.BrandId);
            if (brand is null)
            {
                return Problem("Invalid Brand Id");
            }

            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == req.CategoryId);
            if (category is null)
            {
                return Problem("Invalid Category Id");
            }

            product.Sku = req.Sku;
            product.Name = req.Name;
            product.Description = req.Description;
            product.ShortDescription = req.ShortDescription;
            product.Price = req.Price;
            product.ThumbnailUrl = req.ThumbnailUrl;
            product.Discount = req.Discount;
            product.AvailableStock = req.AvailableStock;
            product.CategoryId = req.CategoryId;
            product.BrandId = req.BrandId;
            product.SetTimeLastModified();

            try
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product is null)
            {
                return Problem("Not exists product");
            }

            product.IsDeleted = true;
            product.SetTimeLastModified();

            try
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}

