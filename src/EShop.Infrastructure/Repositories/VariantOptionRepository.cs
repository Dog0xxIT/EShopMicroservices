using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Entities;
using EShop.Application.Repositories;

namespace EShop.Infrastructure.Repositories
{
    public class VariantOptionRepository : GenericRepository<VariantOption>, IVariantOptionRepository
    {
        public VariantOptionRepository(EShopDbContext context) : base(context)
        {
        }
    }
}