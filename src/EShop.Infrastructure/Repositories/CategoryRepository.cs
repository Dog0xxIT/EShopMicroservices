using EShop.Application.Entities;
using EShop.Application.Repositories;

namespace EShop.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EShopDbContext context) : base(context)
        {
        }
    }
}

