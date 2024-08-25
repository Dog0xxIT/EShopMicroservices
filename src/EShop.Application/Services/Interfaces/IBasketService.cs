using EShop.Application.Dto;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IBasketService
{
    Task<IEnumerable<BasketItem>> GetBasketByCustomerId(int customerId, int pageSize = 10, int pageIndex = 0);
    Task<ServiceResult<int>> UpdateQty(int brandId, int pageSize = 10, int pageIndex = 0);
    Task<ServiceResult<int>> Delete(int categoryId, int pageSize = 10, int pageIndex = 0);
}