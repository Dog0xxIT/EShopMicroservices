using EShop.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Dto.Order
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }

        public int Units { get; set; }
    }
}
