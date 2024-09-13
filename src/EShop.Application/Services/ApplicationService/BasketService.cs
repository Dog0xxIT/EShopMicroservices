using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Common;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Linq;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using Microsoft.AspNetCore.Identity;

namespace EShop.Application.Services.ApplicationService;

public class BasketService : IBasketService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BasketService> _logger;
    private readonly UserManager<User> _userManager;

    public BasketService(IUnitOfWork unitOfWork, ILogger<BasketService> logger, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _userManager = userManager;
    }

    public async Task<PaginationResponse<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest)
    {
        var response = new PaginationResponse<GetBasketByCustomerIdResponse>
        {
            Total = 0,
            Data = [],
            PageIndex = paginationRequest.PageIndex,
            PageSize = paginationRequest.PageSize,
            ItemsPerPage = 0
        };

        var basketItems = await _unitOfWork.BasketItemRepository
            .Get(
                orderBy: queryable => (IOrderedQueryable<BasketItem>)queryable
                    .OrderBy(bi => bi.Id)
                    .Skip(paginationRequest.PageIndex)
                    .Take(paginationRequest.PageSize),
                filter: bi => bi.Basket.UserId == customerId,
                includeProperties: new List<string> { nameof(BasketItem.Basket), nameof(BasketItem.Product) });

        var user = await _userManager.FindByIdAsync(customerId.ToString());
        if (user is null)
        {
            return response;
        }

        var baskItemsDto = basketItems.Select(bi => new GetBasketByCustomerIdResponse
        {
            ProductId = bi.ProductId,
            CustomerId = user?.Id ?? 0,
            CustomerName = user?.UserName ?? "",
            Id = bi.Id,
            ProductName = bi.Product.Name,
            PictureUrl = bi.Product.ImageUrl,
            Quantity = bi.Quantity,
            UnitPrice = bi.UnitPrice
        }).ToList();

        response.ItemsPerPage = baskItemsDto.Count();
        response.Data = baskItemsDto;
        return response;
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

    public async Task<ServiceResult> AddToBasket(AddToBasketRequest req)
    {
        var basket = await _unitOfWork.BasketRepository.Get(filter: b => b.UserId == req.CustomerId);
        if (!basket.Any())
        {

        }
    }
}