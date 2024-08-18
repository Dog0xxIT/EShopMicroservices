using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Entities
{
    public class OrderItem : Entity
    {
        public string ProductName { get; set; }

        public string? PictureUrl { get; set; }

        public double UnitPrice { get; set; }

        public double Discount { get; set; }

        public int Units { get; set; }

        public int ProductId { get; set; }

        public Product Product { get;  set;}

        public OrderItem(string productName, string pictureUrl, double unitPrice, double discount, int units, int productId)
        {
            ProductName = productName ?? throw new ArgumentNullException(nameof(productName));
            PictureUrl = pictureUrl ?? throw new ArgumentNullException(nameof(pictureUrl));
            UnitPrice = unitPrice;
            Discount = discount;
            Units = units;
            ProductId = productId;
        }
    }
}
