using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Common;
using Microsoft.Extensions.Logging;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;

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

    public async Task<PaginationResponse<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest)
    {
        var response = new PaginationResponse<GetBasketByCustomerIdResponse>();

        var baskets = await _unitOfWork.BasketRepository
            .Get(
                orderBy: queryable => (IOrderedQueryable<Basket>)queryable
                    .OrderBy(b => b.Id)
                    .Skip(paginationRequest.Page)
                    .Take(paginationRequest.Limit),
                filter: b => b.UserId == customerId,
                includeProperties: new List<string> { nameof(Basket.Items), nameof(Basket.User) });

        var basketOfCustomer = baskets.FirstOrDefault();
        if (basketOfCustomer is null)
        {
            return response;
        }

        var baskItemsDto = new List<GetBasketByCustomerIdResponse>();
        foreach (var basketItem in basketOfCustomer.Items)
        {
            var product = await _unitOfWork.ProductRepository.GetById(basketItem.ProductId);

            baskItemsDto.Add(new GetBasketByCustomerIdResponse
            {
                ProductId = basketItem.ProductId,
                CustomerId = basketOfCustomer.User?.Id ?? 0,
                CustomerName = basketOfCustomer.User?.UserName ?? "",
                Id = basketItem.Id,
                ProductName = product?.Name ?? "",
                PictureUrl = product?.ImageUrl ?? "",
                Quantity = basketItem.Quantity,
                UnitPrice = basketItem.UnitPrice
            });
        }
        response.Meta.PerPage = baskItemsDto.Count();
        response.Data = baskItemsDto;
        return response;
    }

    public async Task<ServiceResult> UpdateQty(UpdateQtyRequest req)
    {
        var basketEntity = await _unitOfWork.BasketItemRepository.GetById(req.BasketItemId);

        if (basketEntity is null)
        {
            return ServiceResult.Failed("Not exists basket");
        }

        if (req.Qty == 0)
        {
            try
            {
                await _unitOfWork.BasketItemRepository.Delete(req.BasketItemId);
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }
        else
        {
            basketEntity.Quantity = req.Qty;
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


    }

    public async Task<ServiceResult> Delete(int basketItemId)
    {
        try
        {
            await _unitOfWork.BasketItemRepository.Delete(basketItemId);
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
        var product = await _unitOfWork.ProductRepository.GetById(req.ProductId);
        if (product is null)
        {
            return ServiceResult.Failed("Not found product");
        }

        var newBasketItem = new BasketItem
        {
            ProductId = req.ProductId,
            Quantity = req.Quantity,
            UnitPrice = product.Price,
        };

        var baskets = await _unitOfWork.BasketRepository.Get(
            filter: b => b.UserId == req.CustomerId,
            includeProperties: new List<string> { nameof(Basket.Items) });

        if (!baskets.Any())
        {
            var newBasket = new Basket
            {
                UserId = req.CustomerId,
                Items = new() { newBasketItem }
            };
            try
            {
                await _unitOfWork.BasketRepository.Create(newBasket);
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }

        }
        else
        {
            var basketOfCustomer = baskets.First();
            var existsBasketItem = basketOfCustomer.Items.Any(i => i.ProductId == req.ProductId);
            if (existsBasketItem)
            {
                return ServiceResult.Failed("Product exists in basket");
            }

            basketOfCustomer.Items.Add(newBasketItem);
            try
            {
                _unitOfWork.BasketRepository.Update(basketOfCustomer);
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }
    }
}