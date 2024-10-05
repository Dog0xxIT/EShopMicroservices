using System;
using System.Threading.Tasks;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Domain.Common
{
    public interface IUnitOfWork : IDisposable
    {
         IBuyerRepository BuyerRepository { get; }
         IOrderRepository OrderRepository { get; }
         Task<int> Commit(CancellationToken cancellationToken);
    }
}
