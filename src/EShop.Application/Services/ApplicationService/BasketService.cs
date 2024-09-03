using EShop.Application.Dto;
using EShop.Application.Dto.Basket;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using Mapster;
using Microsoft.Extensions.Logging;

namespace EShop.Application.Services.ApplicationService;

public class BasketService : IBasketService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BasketService> _logger;

    public BasketService(IUnitOfWork unitOfWork, ILogger<BasketService> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<IEnumerable<BasketItemDto>> GetBasketByCustomerId(int customerId, int pageSize = 10, int pageIndex = 0)
    {
        var basketItems = await _unitOfWork.BasketItemRepository
            .Get(
                orderBy: queryable => (IOrderedQueryable<BasketItem>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(pageIndex)
                    .Take(pageSize),
                filter: b => b.CustomerId == customerId);


        var basketItemsDto = basketItems.Adapt<IEnumerable<BasketItemDto>>();

        return basketItemsDto;
    }

    public async Task<ServiceResult> UpdateQty(int basketId, int quantity)
    {
        var basketEntity = await _unitOfWork.BasketItemRepository.GetById(basketId);

        if (basketEntity is null)
        {
            return ServiceResult.Failed("Not exists basket");
        }

        basketEntity.Quantity = quantity;
        basketEntity.SetTimeLastModified();

        try
        {
            _unitOfWork.BasketItemRepository.Update(basketEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> Delete(int basketId)
    {
        try
        {
            await _unitOfWork.BasketItemRepository.Delete(basketId);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }
}