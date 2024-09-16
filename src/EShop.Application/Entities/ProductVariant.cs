using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Entities
{
    public class ProductVariant : Entity
    {
        public int Sku { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
