using EShop.Application.Repositories;
using EShop.Application.Services.Interfaces;
using EShop.Infrastructure.Repositories;

namespace EShop.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EShopDbContext _context;
        public IAddressRepository AddressRepository { get; private set; }
        public IBasketItemRepository BasketItemRepository { get; private set; }
        public IBasketRepository BasketRepository { get; private set; }
        public IBrandRepository BrandRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IOrderItemRepository OrderItemRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public IPaymentRepository PaymentRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IRatingRepository RatingRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(EShopDbContext context)
        {
            _context = context;
            AddressRepository = new AddressRepository(context);
            BasketItemRepository = new BasketItemRepository(context);
            BasketRepository = new BasketRepository(context);
            BrandRepository = new BrandRepository(context);
            CategoryRepository = new CategoryRepository(context);
            OrderItemRepository = new OrderItemRepository(context);
            OrderRepository = new OrderRepository(context);
            PaymentRepository = new PaymentRepository(context);
            ProductRepository = new ProductRepository(context);
            RatingRepository = new RatingRepository(context);
            UserRepository = new UserRepository(context);
        }

        public async Task<int> Commit(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
    }
}
