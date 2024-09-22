using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;

namespace EShop.Application.Interfaces;

public interface IBasketService
{
    Task<PaginationResponse<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(int customerId, PaginationRequest paginationReq);
    Task<ServiceResult> UpdateQty(UpdateQtyRequest req);
    Task<ServiceResult> Delete(int basketItemId);
    Task<ServiceResult> AddToBasket(AddToBasketRequest req);
    Task<bool> CheckExistBasket(int basketId);
}