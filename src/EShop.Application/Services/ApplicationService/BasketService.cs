using EShop.Application.Dto;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;

namespace EShop.Application.Services.ApplicationService;

public class BasketService : IBasketService
{
    public async Task<IEnumerable<BasketItem>> GetBasketByCustomerId(int customerId, int pageSize = 10, int pageIndex = 0)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> UpdateQty(int brandId, int pageSize = 10, int pageIndex = 0)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> Delete(int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        throw new NotImplementedException();
    }
}