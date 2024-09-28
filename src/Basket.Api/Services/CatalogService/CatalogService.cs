namespace Basket.Api.Services.CatalogService
{
    public class CatalogService : ICatalogService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<CatalogService> _logger;

        public CatalogService(IHttpClientFactory clientFactory, ILogger<CatalogService> logger)
        {
            _clientFactory = clientFactory;
            _logger = logger;
        }

        public async Task<GetBaseInfoProductResponse?> GetBaseInfoProduct(string catalogClient, int id)
        {
            var httpClient = _clientFactory.CreateClient(catalogClient);

            try
            {
                var client = await httpClient.GetAsync($"api/v1/products/{id}");

                if (client.IsSuccessStatusCode)
                {
                    var resultData = await client.Content.ReadFromJsonAsync<GetBaseInfoProductResponse>();
                    _logger.LogInformation($"StatusCode: {client.StatusCode}");
                    return resultData;
                }
                else
                {
                    var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                    _logger.LogWarning($"StatusCode: {client.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex.Message}");
            }

            return null;
        }
    }
}
