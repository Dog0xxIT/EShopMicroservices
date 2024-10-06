using Ordering.Domain.Aggregates.BuyerAggregate;

namespace Ordering.Infrastructure.Repositories
{
    public class BuyerRepository : GenericRepository<Buyer>, IBuyerRepository
    {
        public BuyerRepository(OrderContext context) : base(context)
        {
        }
    }
}
