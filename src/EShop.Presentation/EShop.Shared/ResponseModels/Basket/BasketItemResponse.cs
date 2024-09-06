using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Shared.ResponseModels.Catalog;

namespace EShop.Application.Dto.Basket
{
    public class BasketItemResponse
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string? PictureUrl { get; set; }
        public int ProductId { get; set; }
        public GetListProductResponse Product { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
