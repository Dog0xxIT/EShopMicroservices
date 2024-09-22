using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core.CoreHttpClient;
using AddToBasketRequest = EShop.WebApp.Core.RequestModels.Basket.AddToBasketRequest;
using GetBasketByCustomerIdResponse = EShop.WebApp.Core.ResponseModels.Basket.GetBasketByCustomerIdResponse;
using PaginationRequest = EShop.WebApp.Core.RequestModels.Common.PaginationRequest;
using ResponseObject = EShop.WebApp.Core.ResponseModels.Common.ResponseObject;

namespace EShop.WebApp.Services.BasketService;

public class BasketService : IBasketService
{

    private readonly ICoreHttpClient _coreHttpClient;

    public BasketService(ICoreHttpClient coreHttpClient)
    {
        _coreHttpClient = coreHttpClient;
    }

    public async Task<ResultObject<Core.ResponseModels.Common.PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest)
    {
        return await _coreHttpClient.GetAsync<Core.ResponseModels.Common.PaginationResponse<GetBasketByCustomerIdResponse>>(
            clientName: UrlsConfig.ClientName,
            uri: $"/baskets/{customerId}",
            queryObj: paginationRequest);
    }

    public async Task<ResultObject<ResponseObject>> AddToBasket(AddToBasketRequest request)
    {
        return await _coreHttpClient.PostAsync<ResponseObject>(
            clientName: UrlsConfig.ClientName,
            uri: $"/baskets",
            reqObj: request);
    }
}