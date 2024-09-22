using System.Collections.ObjectModel;
using Catalog.Api.Infrastructure;
using Catalog.Api.Models.RequestModel;
using Catalog.Api.Models.ResponseModel;
using Catalog.Api.Service;
using EShop.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Controllers
{
    public class BrandController : Controller
    {
        private readonly ILogger<BrandController> _logger;
        private readonly CatalogContext _context;

        public BrandController(ILogger<BrandController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetAllBrands([FromQuery] PaginationRequest paginationReq)
        {
            var queryable = _context.Brands
                .Skip(paginationReq.Page)
                .Take(paginationReq.Limit);

            queryable = paginationReq.SortDescending ?
                queryable.OrderByDescending(p => p.Id) :
                queryable.OrderBy(p => p.Id);

            var brands = await queryable.ToListAsync();

            var brandsDto = new Collection<GetListBrandsResponse>();

            foreach (var brand in brands)
            {
                var countProduct = await _context.Products
                    .Where(product => product.BrandId == brand.Id)
                    .CountAsync();

                brandsDto.Add(new GetListBrandsResponse
                {
                    Code = brand.Code,
                    Description = brand.Description,
                    Id = brand.Id,
                    Name = brand.Name,
                    Thumnai = brand.AvatarUrl,
                    ProductCount = countProduct
                });
            }

            var totalBrand = await _context.Brands.CountAsync();
            var totalPage = paginationReq.Limit != 1 ? totalBrand / paginationReq.Limit + 1 : 0;

            var response = new PaginationResponse<GetListBrandsResponse>
            {
                Data = brandsDto,
                Meta = new Pagination
                {
                    Count = brandsDto.Count(),
                    CurrentPage = paginationReq.Page,
                    Total = totalBrand,
                    TotalPages = totalPage,
                    PerPage = paginationReq.Limit
                }
            };

            return Ok(response);
        }

        [HttpPost("brands")]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var brandEntity = new Brand
            {
                Description = req.Description,
                AvatarUrl = req.AvatarUrl,
                Name = req.Name,
                Code = $"{req.Name.Trim().ToUpper()}-{Guid.NewGuid():N}"
            };

            try
            {
                //await _unitOfWork.BrandRepository.Create(brandEntity);
                //await _unitOfWork.Commit();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPatch("brands/{id}")]
        public async Task<IActionResult> UpdateBrand(
            [FromRoute] int id,
            [FromBody] UpdateBrandRequest req)
        {
            var brandEntity = await _context.Brands.FindAsync(req.Id);

            if (brandEntity is null)
            {
                return Problem("Not exists brand");
            }

            brandEntity.Description = req.Description;
            brandEntity.AvatarUrl = req.AvatarUrl;
            brandEntity.Name = req.Name;
            brandEntity.Code = $"{req.Name.Trim().ToUpper()}-{Guid.NewGuid():N}";
            brandEntity.SetTimeLastModified();

            try
            {
                //_unitOfWork.BrandRepository.Update(brandEntity);
                //await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
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
    }
}
