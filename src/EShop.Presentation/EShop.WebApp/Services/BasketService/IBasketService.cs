using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using AddToBasketRequest = EShop.WebApp.Core.RequestModels.Basket.AddToBasketRequest;
using GetBasketByCustomerIdResponse = EShop.WebApp.Core.ResponseModels.Basket.GetBasketByCustomerIdResponse;
using PaginationRequest = EShop.WebApp.Core.RequestModels.Common.PaginationRequest;
using ResponseObject = EShop.WebApp.Core.ResponseModels.Common.ResponseObject;

namespace EShop.WebApp.Services.BasketService;

public interface IBasketService
{
    Task<ResultObject<Core.ResponseModels.Common.PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest);

    Task<ResultObject<ResponseObject>> AddToBasket(AddToBasketRequest request);
}