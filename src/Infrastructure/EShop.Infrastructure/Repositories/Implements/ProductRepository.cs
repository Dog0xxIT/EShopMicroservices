using EShop.Data.Entities;
using EShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Repositories.Implements
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
