using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Repositories.Interfaces;

namespace EShop.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IBasketItemRepository BasketItemRepository { get; }
        public IBrandRepository BrandRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IOrderItemRepository OrderItemRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IPaymentRepository PaymentRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IRatingRepository RatingRepository { get; }
        public IUserRepository UserRepository { get; }
        Task<int> Commit(CancellationToken cancellationToken = default);
    }
}
