using EShop.Shared.ResponseModels.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Basket
{
    public class GetBasketByCustomerIdResponse
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
