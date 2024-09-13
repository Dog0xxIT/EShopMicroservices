using EShop.Application.Entities;
using EShop.Application.Services.ApplicationService;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;

namespace EShop.Application.Services.Interfaces;

public interface IBasketService
{
    Task<PaginationResponse<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest);
    Task<ServiceResult> UpdateQty(UpdateQtyRequest req);
    Task<ServiceResult> Delete(int basketItemId);
    Task<ServiceResult> AddToBasket(AddToBasketRequest req);
}