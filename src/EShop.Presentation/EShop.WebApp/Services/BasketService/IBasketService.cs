using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp;
using EShop.WebApp.Core;

namespace EShop.WebApp.Services.BasketService;

public interface IBasketService
{
    Task<ResultObject<PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest);

    Task<ResultObject<ResponseObject>> AddToBasket(AddToBasketRequest request);
}