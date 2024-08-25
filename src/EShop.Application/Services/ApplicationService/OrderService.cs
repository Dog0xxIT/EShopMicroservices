using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Dto;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;

namespace EShop.Application.Services.ApplicationService
{
    internal class OrderService : IOrderService
    {
        public async Task<IEnumerable<OrderItem>> GetAllByBuyerId(int pageSize = 10, int pageIndex = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderItem>> GetAllCartTypes(int cartType, int pageSize = 10, int pageIndex = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<int>> CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<int>> Cancel(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<int>> Ship(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
