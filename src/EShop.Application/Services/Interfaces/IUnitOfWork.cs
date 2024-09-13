using EShop.Application.Repositories;

namespace EShop.Application.Services.Interfaces
{
    public interface IUnitOfWork
    {
        public IAddressRepository AddressRepository { get;  }
        public IBasketItemRepository BasketItemRepository { get;  }
        public IBasketRepository BasketRepository { get;  }
        public IBrandRepository BrandRepository { get;  }
        public ICategoryRepository CategoryRepository { get;  }
        public IOrderItemRepository OrderItemRepository { get;  }
        public IOrderRepository OrderRepository { get;  }
        public IPaymentRepository PaymentRepository { get;  }
        public IProductRepository ProductRepository { get;  }
        public IRatingRepository RatingRepository { get;  }
        public IUserRepository UserRepository { get;  }
        Task<int> Commit(CancellationToken cancellationToken = default);
    }
}
