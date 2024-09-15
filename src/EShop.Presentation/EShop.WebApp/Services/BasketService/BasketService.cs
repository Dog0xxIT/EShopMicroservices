using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;
using EShop.WebApp.Core.Core;

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
            uri: UrlsConfig.Basket.GetBasketByCustomerId + $"/{customerId}",
            queryObj: paginationRequest);
    }
}