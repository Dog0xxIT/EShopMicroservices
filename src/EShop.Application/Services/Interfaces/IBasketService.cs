using EShop.Application.Dto;
using EShop.Application.Dto.Basket;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IBasketService
{
    Task<IEnumerable<BasketItemDto>> GetBasketByCustomerId(int customerId, int pageSize = 10, int pageIndex = 0);
    Task<ServiceResult> UpdateQty(int basketId,  int quantity);
    Task<ServiceResult> Delete(int basketId);
}