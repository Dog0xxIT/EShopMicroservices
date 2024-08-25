using EShop.Application.Dto;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<OrderItem>> GetAllByBuyerId(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<OrderItem>> GetAllCartTypes(int cartType, int pageSize = 10, int pageIndex = 0);
    Task<ServiceResult<int>> CreateOrder(Order order);
    Task<ServiceResult<int>> Cancel(int orderId);
    Task<ServiceResult<int>> Ship(int orderId);
}