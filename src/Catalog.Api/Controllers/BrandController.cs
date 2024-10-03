namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/brands")]
    public class BrandController : Controller
    {
        private readonly ICatalogService _catalogService;

        public BrandController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetListBrands([FromQuery] PaginationRequest paginationReq)
        {
            var resultService = await _catalogService.GetListBrands(paginationReq);
            return Ok(resultService);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var resultService = await _catalogService.CreateBrand(req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(
            [FromRoute] int id,
            [FromBody] UpdateBrandRequest req)
        {
            var resultService = await _catalogService.UpdateBrand(req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand([FromRoute] int id)
        {
            var resultService = await _catalogService.DeleteBrand(id);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }
    }
}
