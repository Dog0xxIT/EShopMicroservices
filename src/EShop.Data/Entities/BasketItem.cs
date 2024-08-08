using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Entities
{
    public class BasketItem : Entity
    {
        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string? PictureUrl { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CustomerId { get; set; }

        public User Customer { get; set; }

        public BasketItem(double unitPrice, int quantity, string pictureUrl, int productId, int customerId)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
            PictureUrl = pictureUrl;
            ProductId = productId;
            CustomerId = customerId;
        }
    }
}
