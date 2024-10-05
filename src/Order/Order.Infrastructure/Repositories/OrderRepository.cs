using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext context) : base(context)
        {
        }
    }
}
