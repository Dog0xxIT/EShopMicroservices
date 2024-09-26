using System.Collections.ObjectModel;
using Catalog.Api.Data.Entities;
using Catalog.Api.Models.ResponseModel;
using Catalog.Api.Service;
using Mapster;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/brands")]
    public class BrandController : Controller
    {
        private readonly ILogger<BrandController> _logger;
        private readonly CatalogContext _context;

        public BrandController(ILogger<BrandController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllBrands([FromQuery] PaginationRequest paginationReq)
        {
            var queryable = _context.Brands
                .Skip(paginationReq.Page)
                .Take(paginationReq.Limit);

            queryable = paginationReq.SortDescending ?
                queryable.OrderByDescending(p => p.Id) :
                queryable.OrderBy(p => p.Id);

            var brands = await queryable.ToListAsync();
            var totalBrand = await _context.Brands.CountAsync();
            var totalPage = paginationReq.Limit != 0 ?
                (totalBrand / paginationReq.Limit) + 1 : 0;
            var brandsDto = brands.Adapt<List<GetListBrandsResponse>>();

            var response = new PaginationResponse<GetListBrandsResponse>
            {
                Data = brandsDto,
                Meta = new Pagination
                {
                    Count = brandsDto.Count,
                    CurrentPage = paginationReq.Page,
                    Total = totalBrand,
                    TotalPages = totalPage,
                    PerPage = paginationReq.Limit
                }
            };

            return Ok(response);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateBrand(CreateBrandRequest req)
        {
            var brand = new Brand
            {
                Name = req.Name,
                Slug = req.Name.ToLower().TrimStart().TrimEnd().Replace(" ", "-"),
            };

            try
            {
                await _context.Brands.AddAsync(brand);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(
            [FromRoute] int id,
            [FromBody] UpdateBrandRequest req)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand is null)
            {
                return Problem("Not exists brand");
            }

            brand.Name = req.Name;
            brand.Slug = req.Name.ToLower().TrimStart().TrimEnd().Replace(" ", "-");
            brand.SetTimeLastModified();

            try
            {
                _context.Brands.Update(brand);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand([FromRoute] int id)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand is null)
            {
                return Problem("Not exists brand");
            }

            brand.IsDeleted = true;
            brand.SetTimeLastModified();

            try
            {
                _context.Brands.Update(brand);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
