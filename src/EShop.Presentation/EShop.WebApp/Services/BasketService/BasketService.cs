using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp;
using EShop.WebApp.Core;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.Services.BasketService;

public class BasketService : IBasketService
{

    private readonly ICoreHttpClient _coreHttpClient;

    public BasketService(ICoreHttpClient coreHttpClient)
    {
        _coreHttpClient = coreHttpClient;
    }

    public async Task<ResultObject<PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest)
    {
        return await _coreHttpClient.GetAsync<PaginationResponse<GetBasketByCustomerIdResponse>>(
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