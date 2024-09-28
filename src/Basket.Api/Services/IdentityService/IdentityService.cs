namespace Basket.Api.Services.IdentityService;

public class IdentityService : IIdentityService
{

    private readonly IHttpClientFactory _clientFactory;
    private readonly ILogger<IdentityService> _logger;

    public IdentityService(IHttpClientFactory clientFactory, ILogger<IdentityService> logger)
    {
        _clientFactory = clientFactory;
        _logger = logger;
    }

    public async Task<bool> CheckExistsUser(string identityClient, int userId)
    {
        var httpClient = _clientFactory.CreateClient(identityClient);

        try
        {
            var client = await httpClient.GetAsync($"api/v1/users/{userId}");
            if (client.IsSuccessStatusCode)
            {
                _logger.LogInformation($"StatusCode: {client.StatusCode}");
                return true;
            }
            else
            {
                _logger.LogWarning($"StatusCode: {client.StatusCode}");
                return false;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }
        return false;
    }
}