using Catalog.Api.Infrastructure;
using Catalog.Api.Service.CloudinaryService;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("resources")]
    public class ResourceController : Controller
    {
        private readonly CatalogContext _context;
        private readonly ILogger<ResourceController> _logger;
        private readonly ICloudinaryService _cloudinaryService;

        public ResourceController(CatalogContext context, ILogger<ResourceController> logger, ICloudinaryService cloudinaryService)
        {
            _context = context;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
        }

        [HttpPost("productImages")]
        public async Task<IActionResult> UploadProductImage(UploadProductImageRequest req)
        {
            //var serviceResult = await _catalogService.UpdateImageProduct(req);
            //if (serviceResult.Succeeded)
            //{
            //    return Ok(ResponseObject.Succeeded);
            //}
            //return Problem(serviceResult.Errors.First());
            return Ok();
        }

        [HttpDelete("productImages/{id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] int id)
        {
            //var serviceResult = await _catalogService.DeleteImageProduct(id);
            //if (serviceResult.Succeeded)
            //{
            //    return Ok(ResponseObject.Succeeded);
            //}
            //return Problem(serviceResult.Errors.First());
            return Ok();
        }
    }
}

