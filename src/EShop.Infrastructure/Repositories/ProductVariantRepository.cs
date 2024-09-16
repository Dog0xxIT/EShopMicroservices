using EShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Entities;

namespace EShop.Infrastructure.Repositories
{
    public class ProductVariantRepository : GenericRepository<ProductVariant>, IProductVariantRepository
    {
        public ProductVariantRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
