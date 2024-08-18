using EShop.Data.Entities;
using EShop.Data.Repositories.Interfaces;

namespace EShop.Data.Repositories.Implements;

public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(EShopDbContext context) : base(context)
    {
    }
}

