using EShop.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Dto.Catalog;

namespace EShop.Application.Dto.Basket
{
    public class BasketItemDto
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string? PictureUrl { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
