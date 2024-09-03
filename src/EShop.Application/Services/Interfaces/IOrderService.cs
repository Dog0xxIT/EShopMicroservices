using EShop.Application.Dto;
using EShop.Application.Dto.Order;
using EShop.Application.Entities;
using EShop.Domain.Aggregates.BuyerAggregate;

namespace EShop.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllByBuyerId(int buyerId, int pageSize = 10, int pageIndex = 0);
        Task<OrderDto?> GetById(int orderId);
        Task<ServiceResult> CreateOrder(CreateOrderDto createOrderDto);
        Task<ServiceResult> CreateOrderDraft(CreateOrderDto createOrderDto);
        Task<ServiceResult> CancelOrder(int orderId);
        Task<ServiceResult> ShipOrder(int orderId);
    }
}