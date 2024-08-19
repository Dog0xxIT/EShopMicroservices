using EShop.Application.Entities;
using EShop.Application.Repositories;

namespace EShop.Infrastructure.Repositories;

public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(EShopDbContext context) : base(context)
    {
    }
}

