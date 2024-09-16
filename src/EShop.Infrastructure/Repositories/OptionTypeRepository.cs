using EShop.Application.Entities;
using EShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Repositories
{
    internal class OptionTypeRepository : GenericRepository<OptionType>, IOptionTypeRepository
    {
        public OptionTypeRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
