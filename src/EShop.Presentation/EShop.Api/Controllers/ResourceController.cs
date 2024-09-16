using EShop.Application.Services.ApplicationService;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("resources")]
    public class ResourceController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CatalogController> _logger;
        private readonly ICloudinaryService _cloudinaryService;

        public ResourceController(ICatalogService catalogService, IUnitOfWork unitOfWork, ILogger<CatalogController> logger, ICloudinaryService cloudinaryService)
        {
            _catalogService = catalogService;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
        }

        #region Post method
        [HttpPost("productImages")]
        public async Task<IActionResult> UploadProductImage(UploadProductImageRequest req)
        {
            var serviceResult = await _catalogService.UpdateImageProduct(req);
            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }
        #endregion

        #region Delete method
        [HttpDelete("productImages/{id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] int id)
        {
            var serviceResult = await _catalogService.DeleteImageProduct(id);
            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }
        #endregion
    }
}

