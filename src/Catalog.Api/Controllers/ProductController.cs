using Catalog.Api.Data.Entities;
using Catalog.Api.Models.ResponseModel;
using Catalog.Api.Service.CloudinaryService;
using Mapster;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/products")]
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

            if (req.MinPrice > req.MaxPrice)
            {
                return Ok(new PaginationResponse<GetListProductResponse>());
            }

            var brands = ParseIds(req.Brands);
            var categories = ParseIds(req.Categories);

            var queryable = _context.Products.AsQueryable();
            queryable = ApplyFilters(queryable, req, brands, categories);
            queryable = ApplySorting(queryable, req);

            var products = await queryable
                .Skip((req.Page - 1) * req.Limit)
                .Take(req.Limit)
                .ToListAsync();

            var productsDto = products.Select(product =>
                new GetListProductResponse
                {
                    Id = product.Id,
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    BrandId = product.BrandId,
                    Discount = product.Discount,
                    Name = product.Name,
                    ThumbnailUrl = product.ThumbnailUrl,
                    ReviewCount = product.ReviewCount,
                    RatingAverage = product.RatingAverage,
                    TotalBuyer = product.TotalBuyer,
                    Sku = product.Sku,
                    ShortDescription = product.ShortDescription,
                }).ToList();

            var totalProducts = await _context.Products.CountAsync();
            var totalPage = req.Limit != 0 ? (totalProducts / req.Limit) + 1 : 0;

            var response = new PaginationResponse<GetListProductResponse>
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

            var productOptions = product?.ProductVariant?.SelectMany(pv => pv.Options);
            var groupByOptionType = productOptions?.GroupBy(po => po.OptionType);
            var configOptions = groupByOptionType?.Select(g =>
                new GetProductByIdResponse.ConfigOption
                {
                    OptionTypeId = g.Key.Id,
                    OptionType = g.Key.Name,
                    Values = g.Select(i => i.Value).ToList()
                }).ToList() ?? new();


            var productVariants = product?.ProductVariant?.Select(productVariant =>
                new GetProductByIdResponse.Variant
                {
                    ProductId = productVariant.ProductId,
                    ProductVariantId = productVariant.Id,
                    Sku = productVariant.Sku,
                    AvailableStock = productVariant.AvailableStock,
                    Price = productVariant.Price,
                    Option1 = productVariant?.Options?.ElementAtOrDefault(0)?.Value ?? "",
                    Option2 = productVariant?.Options?.ElementAtOrDefault(1)?.Value ?? "",
                }).ToList() ?? new();

            var response = new GetProductByIdResponse
            {
                Id = product!.Id,
                Name = product.Name,
                EmbedDescription = product.Description,
                Price = product.Price,
                ThumbnailUrl = product.ThumbnailUrl,
                Discount = product.Discount,
                ReviewCount = product.ReviewCount,
                RatingAverage = product.RatingAverage,
                TotalBuyer = product.TotalBuyer,
                Sku = product.Sku,
                ShortDescription = product.ShortDescription,
                Brand = new()
                {
                    Id = product.BrandId,
                    Name = product?.Brand.Name ?? "",
                    Slug = product?.Brand.Slug ?? ""
                },
                Category = new()
                {
                    Id = product!.CategoryId,
                    Name = product?.Category.Name ?? "",
                    ThumbnailUrl = product?.Category.ThumbnailUrl ?? "",
                },
                Variants = productVariants,
                ConfigOptions = configOptions
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

        private IQueryable<Product> ApplySorting(IQueryable<Product> queryable, GetListProductRequest req)
        {
            var sortByList = new Dictionary<string, string>
            {
                ["id"] = nameof(Product.Id),
                ["price"] = nameof(Product.Price),
                ["date_modified"] = nameof(Product.LastModified),
            };

            return sortByList[req.SortBy] switch
            {
                nameof(Product.Id) => req.SortDescending
                    ? queryable.OrderByDescending(product => product.Id)
                    : queryable.OrderBy(product => product.Id),
                nameof(Product.LastModified) => req.SortDescending
                    ? queryable.OrderByDescending(product => product.LastModified)
                    : queryable.OrderBy(product => product.LastModified),
                nameof(Product.Price) => req.SortDescending
                    ? queryable.OrderByDescending(product => product.Price)
                    : queryable.OrderBy(product => product.Price),
                _ => queryable
            };
        }
        private List<int> ParseIds(string? ids)
        {
            return string.IsNullOrEmpty(ids) ?
                new() : ids.Replace(" ", string.Empty).Split(",").Select(int.Parse).ToList();
        }
        private IQueryable<Product> ApplyFilters(IQueryable<Product> queryable,
            GetListProductRequest req,
            List<int> brands,
            List<int> categories)
        {
            if (req.MinPrice != null)
                queryable = queryable.Where(product => product.Price >= req.MinPrice);

            if (req.MaxPrice != null)
                queryable = queryable.Where(product => product.Price <= req.MaxPrice);

            if (brands.Any())
                queryable = queryable.Where(product => brands.Contains(product.BrandId));

            if (categories.Any())
                queryable = queryable.Where(product => categories.Contains(product.CategoryId));

            if (!string.IsNullOrEmpty(req.Sku))
                queryable = queryable.Where(product => product.Sku.Equals(req.Sku));

            if (!string.IsNullOrEmpty(req.Keyword))
                queryable = queryable.Where(product => product.Name.Contains(req.Keyword) || product.Description.Contains(req.Keyword));

            return queryable;
        }
    }
}

