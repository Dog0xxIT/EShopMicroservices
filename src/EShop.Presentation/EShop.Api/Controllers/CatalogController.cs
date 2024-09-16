using System.ComponentModel.DataAnnotations;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CatalogController> _logger;
        private readonly ICloudinaryService _cloudinaryService;

        public CatalogController(IUnitOfWork unitOfWork, ILogger<CatalogController> logger, ICloudinaryService cloudinaryService, ICatalogService catalogService)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
            _catalogService = catalogService;
        }

        #region Get method
        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] PaginationRequest paginationReq)
        {
            var response = await _catalogService.GetAllProducts(paginationReq);

            return Ok(response);
        }


        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById([FromRoute] int productId)
        {
            var product = await _catalogService.GetProductById(productId);

            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands([FromQuery] PaginationRequest paginationReq)
        {
            var response = await _catalogService.GetAllBrands(paginationReq);
         
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _catalogService.GetAllCategories();

            return Ok(categories);
        }

        [HttpGet]
        public async Task<IActionResult> GetTopCategories(int number = 10)
        {
            var categories = await _catalogService.GetTopCategories(number);
            return Ok(categories);
        }

        [HttpGet]
        public async Task<IActionResult> SearchWithSemanticRelevance(
            [FromQuery][Required] string text,
            [FromQuery] PaginationRequest paginationReq)
        {
            var response = await _catalogService.SearchWithSemanticRelevance(text, paginationReq);

            return Ok(response);
        }

        #endregion

        #region Post method
        [HttpPost]
        public async Task<IActionResult> GetProductsByAdvanceFilter(
            [FromBody] GetProductsByAdvanceFilterRequest getProductsByAdvanceFilterRequest)
        {
            var response = await _catalogService.GetProductsByAdvanceFilter(getProductsByAdvanceFilterRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> UploadProductImage(UploadProductImageRequest req)
        {
            var serviceResult = await _catalogService.UpdateImageProduct(req);
            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var serviceResult = await _catalogService.CreateProduct(req);

            if (serviceResult.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPost]
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

        #region Put method

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductRequest req)
        {
            var serviceResult = await _catalogService.UpdateProduct(req);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandRequest req)
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

        #endregion
    }
}
