using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Entities;
using EShop.Data.Repositories.Interfaces;

namespace EShop.Data.Repositories.Implements
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(EShopDbContext context)
        {
        }
    }
}
