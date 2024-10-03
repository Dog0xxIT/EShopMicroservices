namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/categories")]
    public class CategoryController : Controller
    {
        private readonly ICatalogService _catalogService;

        public CategoryController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("hierarchy")]
        public async Task<IActionResult> GetCategoriesHierarchy()
        {
            var resultService = await _catalogService.GetAllCategoriesHierarchy();
            return Ok(resultService);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetCategories()
        {
            var resultService = await _catalogService.GetAllCategories();
            return Ok(resultService);
        }
    }
}
