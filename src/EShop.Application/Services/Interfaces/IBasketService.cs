using EShop.Application.Dto.Basket;
using EShop.Application.Entities;
using EShop.Application.Services.ApplicationService;

namespace EShop.Application.Services.Interfaces;

public interface IBasketService
{
    Task<IEnumerable<BasketItemResponse>> GetBasketByCustomerId(int customerId, int pageSize = 10, int pageIndex = 0);
    Task<ServiceResult> UpdateQty(int basketId,  int quantity);
    Task<ServiceResult> Delete(int basketId);
}