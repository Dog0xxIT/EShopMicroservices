using EShop.Api.Services.CloudinaryService;
using EShop.Data.Entities;
using EShop.Data.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels.Catalog;
using System.Linq;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CatalogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CatalogController> _logger;
        private readonly ICloudinaryService _cloudinaryService;

        public CatalogController(IUnitOfWork unitOfWork, ILogger<CatalogController> logger, ICloudinaryService cloudinaryService)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
        }

        #region Get method
        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] PaginationRequest paginationReq)
        {
            var products = await _unitOfWork.ProductRepository
                .Get(orderBy: queryable => queryable
                    .Order()
                    .Skip(paginationReq.PageIndex)
                    .Take(paginationReq.PageSize) as IOrderedQueryable<Product>);


            var response = new PaginationResponse
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
            //var products = await _unitOfWork.ProductRepository.GetProductByBrandId(brandId, paginationReq.PageSize, paginationReq.PageIndex);
            //var response = new PaginationResponse
            //{
            //    PageIndex = paginationReq.PageIndex,
            //    PageSize = paginationReq.PageSize,
            //    Count = products?.Count() ?? 0,
            //    Data = products ?? new()
            //};
            //return Ok(response);
            return Ok();
        }

        [HttpGet("{typeId}")]
        public async Task<IActionResult> GetProductsByTypeId([FromRoute] int typeId, [FromQuery] PaginationRequest paginationReq)
        {
            //var products = await _unitOfWork.ProductRepository.GetProductByTypeId(typeId, paginationReq.PageSize, paginationReq.PageIndex);
            //var response = new PaginationRes
            //{
            //    PageIndex = paginationReq.PageIndex,
            //    PageSize = paginationReq.PageSize,
            //    Count = products?.Count() ?? 0,
            //    Data = products ?? new()
            //};
            //return Ok(response);
            return Ok();
        }

        [HttpGet("type/{typeId}/brand/{brandId}")]
        public async Task<IActionResult> GetProductsByBrandAndTypeId([FromRoute] int typeId, [FromRoute] int brandId, [FromQuery] PaginationRequest paginationReq)
        {
            //var products = await _unitOfWork.ProductRepository.GetProductByBrandAndTypeId(brandId, typeId, paginationReq.PageSize, paginationReq.PageIndex);
            //var response = new PaginationRes
            //{
            //    PageIndex = paginationReq.PageIndex,
            //    PageSize = paginationReq.PageSize,
            //    Count = products?.Count() ?? 0,
            //    Data = products ?? new()
            //};
            //return Ok(response);
            return Ok();
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById([FromRoute] int productId)
        {
            //var referenceNavigation = new List<string>
            //{
            //    nameof(Product.CatalogBrand),
            //    nameof(Product.CatalogType)
            //};
            //var product = await _unitOfWork.ProductRepository.GetById(
            //    id: productId,
            //    referenceNavigations: referenceNavigation
            // );
            //return product is null ? NotFound() : Ok(product);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands([FromQuery] PaginationRequest paginationReq)
        {
            //var brands = await _unitOfWork.CatalogBrandRepository.GetAll(paginationReq.PageSize, paginationReq.PageIndex);
            //var response = new PaginationRes
            //{
            //    PageIndex = paginationReq.PageIndex,
            //    PageSize = paginationReq.PageSize,
            //    Count = brands?.Count() ?? 0,
            //    Data = brands ?? new()
            //};
            //return Ok(response);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypes()
        {
            var categories = await _unitOfWork.CategoryRepository.Get();
            return Ok(categories);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetAllImagesOfProduct([FromRoute] int productId)
        {
            //var isExists = await _unitOfWork.ProductRepository.IsExists(productId);
            //if (!isExists)
            //{
            //    return NotFound();
            //}

            try
            {
                await _cloudinaryService.GetAllProductImages(productId);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult SearchWithSemanticRelevance([FromQuery][Required] string text, [FromQuery] PaginationRequest paginationReq)
        {
            return Ok();
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> UploadProductImage(UploadProductImageRequest req)
        {

            //var isExists = await _unitOfWork.ProductRepository.IsExists(req.ProductId);
            //if (!isExists)
            //{
            //    return NotFound();
            //}

            try
            {
                await _cloudinaryService.UploadProductImage(req.ProductId, req.FormFile.FileName, req.FormFile.OpenReadStream());
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest req)
        {
            //var product = new Product
            //{
            //    Name = req.Name,
            //    Price = req.Price,
            //    StockQuantity = req.StockQuantity,
            //    Description = req.Description,
            //    CatalogBrandId = req.CatalogBrandId,
            //    CatalogTypeId = req.CatalogTypeId,
            //};
            try
            {
                //await _unitOfWork.ProductRepository.Create(product);
                var result = await _unitOfWork.Commit();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var brand = new Brand(req.Name, "");
            
            try
            {
                await _unitOfWork.BrandRepository.Create(brand);
                var result = await _unitOfWork.Commit();
                return Ok(result);
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

            product.Name = req.Name;
            product.Price = req.Price;
            //product.StockQuantity = req.StockQuantity;
            //product.Description = req.Description;
            //product.CatalogBrandId = req.CatalogBrandId;
            //product.CatalogTypeId = req.CatalogTypeId;

            try
            {
                _unitOfWork.ProductRepository.Update(product);
                var result = await _unitOfWork.Commit();
                return Ok(result);
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

            brand.Name = req.Name;

            try
            {
                _unitOfWork.BrandRepository.Update(brand);
                var result = await _unitOfWork.Commit();
                return Ok(result);
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
