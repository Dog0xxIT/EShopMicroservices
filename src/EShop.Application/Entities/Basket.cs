using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Entities
{
    public class Basket : Entity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
