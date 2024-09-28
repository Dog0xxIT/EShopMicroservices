using WebApp.Core.CoreHttpClient;

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
            clientName: UrlsConfig.CatalogClient,
            uri: "" + $"/{customerId}",
            queryObj: paginationRequest);
    }
}