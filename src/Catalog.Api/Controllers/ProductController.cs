namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/products")]
    public class ProductController : Controller
    {
        private readonly ICatalogService _catalogService;

        public ProductController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetListProducts([FromQuery] GetListProductRequest req)
        {
            var resultService = await _catalogService.GetListProducts(req);
            return Ok(resultService);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var resultService = await _catalogService.GetProductById(id);
            return Ok(resultService);
        }


        [HttpPost("")]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var resultService = await _catalogService.CreateProduct(req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] int id,
            [FromBody] UpdateProductRequest req)
        {
            var resultService = await _catalogService.UpdateProduct(req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            var resultService = await _catalogService.DeleteProduct(id);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }
    }
}

