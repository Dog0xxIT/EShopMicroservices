using EShop.Application.Entities;
using EShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Repositories
{
    public class OptionValueRepository : GenericRepository<OptionValue>, IOptionValueRepository
    {
        public OptionValueRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
