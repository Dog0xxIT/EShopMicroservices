using System.ComponentModel.DataAnnotations;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels;
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
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] PaginationRequest paginationReq)
        {
            var products = await _catalogService.GetAllProducts(paginationReq.PageSize, paginationReq.PageIndex);

            var response = new PaginationResponse<Product>
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

            var response = new PaginationResponse<Product>
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

            var response = new PaginationResponse<Product>
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

            var response = new PaginationResponse<Product>
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
            var brands = await _unitOfWork.BrandRepository.Get();

            return Ok(brands);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _unitOfWork.CategoryRepository.Get();
            return Ok(categories);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetAllImagesOfProduct([FromRoute] int productId)
        {
            try
            {
                await _cloudinaryService.GetAllProductImages(productId);
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult SearchWithSemanticRelevance([FromQuery][Required] string text, [FromQuery] PaginationRequest paginationReq)
        {
            return Ok(new SuccessObjectResponse());
        }

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

            try
            {
                var uri = await _cloudinaryService.UploadProductImage(req.ProductId, req.FormFile.FileName, req.FormFile.OpenReadStream());
                product.PictureFileName = uri.AbsoluteUri;
                _unitOfWork.ProductRepository.Update(product);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            var category = await _unitOfWork.CategoryRepository.GetById(req.CategoryId);
            if (category is null)
            {
                return BadRequest("Not found category");
            }

            var brand = await _unitOfWork.BrandRepository.GetById(req.BrandId);
            if (brand is null)
            {
                return BadRequest("Not found brand");
            }

            var product = new Product
            {
                Name = req.Name,
                Price = req.Price,
                CategoryId = req.CategoryId,
                BrandId = req.BrandId,
                AvailableStock = req.AvailableStock,
                RestockThreshold = req.RestockThreshold,
                MaxStockThreshold = req.MaxStockThreshold,
                Description = req.Description,
            };
            product.SetTimeCreated();

            try
            {
                await _unitOfWork.ProductRepository.Create(product);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var duplicateBrandsCode = await _unitOfWork.BrandRepository
                .Get(filter: p => p.Code == req.Code);

            if (duplicateBrandsCode.Any())
            {
                return ValidationProblem(detail: "Brand Code is unique");
            }

            var brand = new Brand
            {
                Name = req.Name,
                Code = req.Code
            };

            try
            {
                await _unitOfWork.BrandRepository.Create(brand);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        #endregion

        #region Put method

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductRequest req)
        {
            var product = await _unitOfWork.ProductRepository.GetById(req.Id);

            if (product is null)
            {
                return NotFound();
            }

            var category = await _unitOfWork.CategoryRepository.GetById(req.CategoryId);
            if (category is null)
            {
                return BadRequest("Not found category");
            }

            var brand = await _unitOfWork.BrandRepository.GetById(req.BrandId);
            if (brand is null)
            {
                return BadRequest("Not found brand");
            }

            product.Name = req.Name;
            product.Price = req.Price;
            product.CategoryId = req.CategoryId;
            product.BrandId = req.BrandId;
            product.AvailableStock = req.AvailableStock;
            product.RestockThreshold = req.RestockThreshold;
            product.MaxStockThreshold = req.MaxStockThreshold;
            product.Description = req.Description;
            product.SetTimeLastModified();

            try
            {
                _unitOfWork.ProductRepository.Update(product);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandRequest req)
        {
            var brand = await _unitOfWork.BrandRepository.GetById(req.Id);

            if (brand is null)
            {
                return NotFound();
            }

            var duplicateBrandsCode = await _unitOfWork.BrandRepository
                .Get(filter: p => p.Code == req.Code);

            if (duplicateBrandsCode.Any())
            {
                return ValidationProblem(detail: "Brand Code is unique");
            }

            brand.Name = req.Name;
            brand.Code = req.Code;

            try
            {
                _unitOfWork.BrandRepository.Update(brand);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        #endregion

        #region Delete method

        #endregion
    }
}
