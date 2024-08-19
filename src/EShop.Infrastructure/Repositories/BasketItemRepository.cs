using EShop.Application.Entities;
using EShop.Application.Repositories;

namespace EShop.Infrastructure.Repositories
{
    public class BasketItemRepository : GenericRepository<BasketItem>, IBasketItemRepository
    {
        public BasketItemRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
