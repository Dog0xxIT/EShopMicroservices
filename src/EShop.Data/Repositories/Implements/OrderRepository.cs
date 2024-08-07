using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Entities;
using EShop.Data.Repositories.Interfaces;

namespace EShop.Data.Repositories.Implements
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(EShopDbContext context) : base(context)
        {
        }
    }
}