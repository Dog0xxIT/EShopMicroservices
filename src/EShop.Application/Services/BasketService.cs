using EShop.Shared.RequestModels.Common;
using Microsoft.Extensions.Logging;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.ResponseModels.Basket;
using EShop.Application.Interfaces;
using EShop.Application.Models;

namespace EShop.Application.Services;

public class BasketService : IBasketService
{
    private readonly IDbContext _context;
    private readonly ILogger<BasketService> _logger;

    public BasketService(IDbContext context, ILogger<BasketService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<PaginationResponse<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(int customerId, PaginationRequest paginationReq)
    {
        var response = new PaginationResponse<GetBasketByCustomerIdResponse>();

        var basketOfCustomer = await _context.Baskets
            .Include(b => b.User)
            .SingleOrDefaultAsync(b => b.UserId == customerId);

        if (basketOfCustomer is null)
        {
            return response;
        }

        var basketItems = await _context.BasketItems
            .OrderByDescending(b => b.Id)
            .Skip((paginationReq.Page - 1) * paginationReq.Limit)
            .Take(paginationReq.Limit)
            .Include(b => b.Product)
            .Where(b => b.BasketId == basketOfCustomer.Id)
            .AsNoTracking()
            .ToListAsync();

        var baskItemsDto = new List<GetBasketByCustomerIdResponse>();

        foreach (var basketItem in basketItems)
        {
            var product = await _context.Products.FindAsync(basketItem.ProductId);

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

        var totalBasketItems = await _context.BasketItems.CountAsync();
        var totalPages = paginationReq.Limit != 1 ? totalBasketItems / paginationReq.Limit + 1 : 0;

        response.Data = baskItemsDto;
        response.Meta.CurrentPage = paginationReq.Page;
        response.Meta.PerPage = paginationReq.Limit;
        response.Meta.Count = baskItemsDto.Count;
        response.Meta.Total = totalBasketItems;
        response.Meta.TotalPages = totalPages;
        return response;
    }

    public async Task<ServiceResult> UpdateQty(UpdateQtyRequest req)
    {
        var basketEntity = await _context.BasketItems.FindAsync(req.BasketItemId);

        if (basketEntity is null)
        {
            return ServiceResult.Failed("Not exists basket");
        }

        if (req.Qty == 0)
        {
            try
            {
                //await _unitOfWork.BasketItemRepository.Delete(req.BasketItemId);
                //await _unitOfWork.Commit();
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
                //_unitOfWork.BasketItemRepository.Update(basketEntity);
                //await _unitOfWork.Commit();
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
            //await _unitOfWork.BasketItemRepository.Delete(basketItemId);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> AddToBasket(AddToBasketRequest req)
    {
        var product = await _context.Products.FindAsync(req.ProductId);
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

        var baskets = await _context.Baskets
            .Where(b => b.UserId == req.CustomerId)
            .Include(b => b.Items)
            .AsNoTracking()
            .ToListAsync();

        if (!baskets.Any())
        {
            var newBasket = new Basket
            {
                UserId = req.CustomerId,
                Items = new() { newBasketItem }
            };
            try
            {
                //await _unitOfWork.BasketRepository.Create(newBasket);
                //await _unitOfWork.Commit();
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
                //_unitOfWork.BasketRepository.Update(basketOfCustomer);
                //await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }
    }

    public async Task<bool> CheckExistBasket(int basketId)
    {
        var basket = await _context.Baskets.FindAsync(basketId);
        return basket != null;
    }
}