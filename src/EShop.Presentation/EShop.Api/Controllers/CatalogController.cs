using System.ComponentModel.DataAnnotations;
using EShop.Application.Constants;
using EShop.Application.Dto.Catalog;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels;
using Mapster;
using Microsoft.AspNetCore.Authorization;
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
            var products = await _catalogService.GetAllProducts(paginationReq.PageSize, paginationReq.PageIndex);

            var response = new PaginationResponse<ProductDto>
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = products.Count(),
                Data = products
            };
            return Ok(response);
        }

        [HttpGet("{brandId}")]
        public async Task<IActionResult> GetProductsByBrandId([FromRoute] int brandId, [FromQuery] PaginationRequest paginationReq)
        {
            var products = await _catalogService.GetProductsByBrandId(brandId, paginationReq.PageSize, paginationReq.PageIndex);

            var response = new PaginationResponse<ProductDto>
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = products.Count(),
                Data = products
            };
            return Ok(response);
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetProductsByCategoryId([FromRoute] int categoryId, [FromQuery] PaginationRequest paginationReq)
        {
            var products = await _catalogService.GetProductsByCategoryId(categoryId, paginationReq.PageSize, paginationReq.PageIndex);

            var response = new PaginationResponse<ProductDto>
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = products.Count(),
                Data = products
            };
            return Ok(response);
        }

        [HttpGet("category/{categoryId}/brand/{brandId}")]
        public async Task<IActionResult> GetProductsByBrandAndCategoryId(
            [FromRoute] int categoryId,
            [FromRoute] int brandId,
            [FromQuery] PaginationRequest paginationReq)
        {
            var products = await _catalogService.GetProductsByBrandAndCategoryId(
                brandId, categoryId,
                paginationReq.PageSize, paginationReq.PageIndex);

            var response = new PaginationResponse<ProductDto>
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = products.Count(),
                Data = products
            };
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
            var brands = await _catalogService.GetAllBrands();

            var response = new PaginationResponse<BrandDto>
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = brands.Count(),
                Data = brands
            };
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _catalogService.GetAllCategories();
            return Ok(categories);
        }

        //[HttpGet("{productId}")]
        //public async Task<IActionResult> GetAllImagesOfProduct([FromRoute] int productId)
        //{
        //    try
        //    {
        //        await _cloudinaryService.GetAllImagesByProductId(productId);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Problem(ex.Message);
        //    }
        //}

        //[HttpGet]
        //public IActionResult SearchWithSemanticRelevance([FromQuery][Required] string text, [FromQuery] PaginationRequest paginationReq)
        //{
        //    return Ok();
        //}

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> UploadProductImage(UploadProductImageRequest req)
        {

            var product = await _unitOfWork.ProductRepository.GetById(req.ProductId);
            if (product is null)
            {
                return Problem("Not found product");
            }

            var uri = await _cloudinaryService.UploadProductImage(req.ProductId, req.FormFile.FileName, req.FormFile.OpenReadStream());
            product.PictureFileName = uri.AbsoluteUri;
            var serviceResult = await _catalogService.UpdateImageUrlProduct(product.Id, uri.AbsoluteUri);
            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var createProductDto = req.Adapt<CreateProductDto>();

            var serviceResult = await _catalogService.CreateProduct(createProductDto);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var serviceResult = await _catalogService.CreateBrand(req.Name, req.Code);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        #endregion

        #region Put method

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductRequest req)
        {
            var updateProductDto = req.Adapt<UpdateProductDto>();

            var serviceResult = await _catalogService.UpdateProduct(updateProductDto);

            if (serviceResult.Succeeded)
            {
                return Ok();
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandRequest req)
        {
            var serviceResult = await _catalogService.UpdateBrand(req.Id, req.Name, req.Code);

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
