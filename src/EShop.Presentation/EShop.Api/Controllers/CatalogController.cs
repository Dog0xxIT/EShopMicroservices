namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("catalog")]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly ILogger<CatalogController> _logger;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IDbContext _context;

        public CatalogController(IDbContext context, ILogger<CatalogController> logger, ICloudinaryService cloudinaryService, ICatalogService catalogService)
        {
            _context = context;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
            _catalogService = catalogService;
        }

        #region Get method
        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductRequest getAllProductRequest)
        {
            var response = await _catalogService.GetAllProducts(getAllProductRequest);

            return Ok(response);
        }

        [HttpGet("products/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _catalogService.GetProductById(id);
            if (product is null)
            {
                return Problem("Not exist product");
            }
            return Ok(product);
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetAllBrands([FromQuery] PaginationRequest paginationReq)
        {
            var response = await _catalogService.GetAllBrands(paginationReq);

            return Ok(response);
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories([FromQuery] PaginationRequest paginationReq)
        {
            var categories = await _catalogService.GetAllCategories(paginationReq);

            return Ok(categories);
        }
        #endregion

        #region Post method
        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var serviceResult = await _catalogService.CreateProduct(req);

            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPost("brands")]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var serviceResult = await _catalogService.CreateBrand(req);

            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        #endregion

        #region Patch method

        [HttpPatch("products/{id}")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] int id,
            [FromBody] UpdateProductRequest req)
        {
            var isExist = await _catalogService.CheckExistProduct(id);
            if (!isExist)
            {
                return Problem("Not exist product");
            }

            var serviceResult = await _catalogService.UpdateProduct(req);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPatch("brands/{id}")]
        public async Task<IActionResult> UpdateBrand(
            [FromRoute] int id,
            [FromBody] UpdateBrandRequest req)
        {
            var serviceResult = await _catalogService.UpdateBrand(req);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        #endregion

        #region Delete method
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            //var serviceResult = await _catalogService.UpdateBrand(req);
            var serviceResult = ServiceResult.Success;
            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpDelete("brands/{id}")]
        public async Task<IActionResult> DeleteBrand([FromRoute] int id)
        {
            //var serviceResult = await _catalogService.UpdateBrand(req);
            var serviceResult = ServiceResult.Success;
            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }
        #endregion
    }
}
