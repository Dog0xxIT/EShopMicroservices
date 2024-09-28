using Catalog.Api.Infrastructure.Entities;
using Catalog.Api.Models.ResponseModel;
using Mapster;
using System.Linq;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/categories")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CatalogContext _context;

        public CategoryController(CatalogContext context, ILogger<CategoryController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("hierarchy")]
        public async Task<IActionResult> GetCategoriesHierarchy()
        {
            var categories = await _context.Categories
                .AsNoTracking()
                .ToListAsync();

            var categoriesDto = categories.Select(category => new GetAllCategoriesResponse
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                ThumbnailUrl = category.ThumbnailUrl,
                Childs = GetChildCategories(category.Id, categories, 1),
            });

            return Ok(categoriesDto);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();

            var categoriesDto = categories.Select(category => new GetAllCategoriesResponse
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                ThumbnailUrl = category.ThumbnailUrl,
                Childs = new(),
            }).ToList();

            var response = new PaginationResponse<GetAllCategoriesResponse>
            {
                Data = categoriesDto,
                Meta = new Pagination
                {
                    Count = categoriesDto.Count,
                    CurrentPage = 1,
                    Total = categoriesDto.Count,
                    TotalPages = 1,
                    PerPage = 1
                }
            };

            return Ok(response);
        }

        private List<GetAllCategoriesResponse> GetChildCategories(
            int parentCategoryId,
            List<Category> categoryList,
            int level)
        {
            if (level >= 3)
            {
                return new();
            }

            // Tìm danh mục con của danh mục hiện tại (parentCategory)
            var childCategories = categoryList.Where(c => c.ParentId == parentCategoryId);

            return childCategories.Select(child => new GetAllCategoriesResponse
            {
                Id = child.Id,
                Name = child.Name,
                ThumbnailUrl = child.ThumbnailUrl,
                ParentId = child.ParentId,
                Childs = GetChildCategories(child.Id, categoryList, level + 1) // Đệ quy tiếp tục cho các cấp thấp hơn
            }).ToList();
        }
    }
}
