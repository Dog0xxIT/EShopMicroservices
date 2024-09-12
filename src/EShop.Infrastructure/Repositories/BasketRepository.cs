using EShop.Application.Entities;
using EShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Repositories
{
    internal class BasketRepository : GenericRepository<Basket>, IBasketRepository
    {
        public BasketRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
