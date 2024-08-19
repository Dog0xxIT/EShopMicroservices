using EShop.Application.Repositories;

namespace EShop.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(EShopDbContext context)
        {
        }
    }
}
