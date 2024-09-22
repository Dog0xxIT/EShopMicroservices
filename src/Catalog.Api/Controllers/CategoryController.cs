using Catalog.Api.Infrastructure;
using Catalog.Api.Models.RequestModel;
using Catalog.Api.Models.ResponseModel;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CatalogContext _context;

        public CategoryController(CatalogContext context, ILogger<CategoryController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories([FromQuery] PaginationRequest paginationReq)
        {
            var queryable = _context.Categories
                .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                .Take(paginationReq.Limit);

            queryable = paginationReq.SortDescending
                ? queryable.OrderByDescending(c => c.Id)
                : queryable.OrderBy(c => c.Id);

            var categories = await queryable.ToListAsync();

            var categoriesDto = categories.Adapt<List<GetAllCategoriesResponse>>();

            var totalCategory = await _context.Categories.CountAsync();
            var totalPage = paginationReq.Limit != 1 ? totalCategory / paginationReq.Limit + 1 : 0;

            var response = new PaginationResponse<GetAllCategoriesResponse>
            {
                Data = categoriesDto,
                Meta = new Pagination
                {
                    Count = categoriesDto.Count(),
                    CurrentPage = paginationReq.Page,
                    Total = totalCategory,
                    TotalPages = totalPage,
                    PerPage = paginationReq.Limit
                }
            };
            return Ok(response);
        }
    }
}
