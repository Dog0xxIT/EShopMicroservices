using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace WebApp.Core.CoreHttpClient;

public class CoreHttpClient : ICoreHttpClient
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly ILogger<CoreHttpClient> _logger;

    public CoreHttpClient(IHttpClientFactory clientFactory, ILogger<CoreHttpClient> logger)
    {
        _clientFactory = clientFactory;
        _logger = logger;
    }

    public async Task<ResultObject<T>> GetAsync<T>(string clientName, string uri, object? queryObj = null) where T : class
    {
        if (queryObj != null)
        {
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(queryObj));
            if (dictionary != null)
            {
                dictionary = dictionary.Where(i => !string.IsNullOrEmpty(i.Value)).ToDictionary();

                var queryString = string.Join("&", dictionary.Select(x => $"{x.Key}={HttpUtility.UrlEncode(x.Value)}"));
                uri += $"?{queryString}";
            }
        }

        var httpClient = _clientFactory.CreateClient(clientName);

        try
        {
            var client = await httpClient.GetAsync(uri);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<T>();
                _logger.LogInformation($"StatusCode: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Success,
                    Messages = "Success",
                    Data = resultData!,
                };
            }
            else
            {
                var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                _logger.LogWarning($"StatusCode: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Failed,
                    Messages = resultData!.Detail,
                };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }

        return default!;
    }

    public async Task<ResultObject<T>> PostAsync<T>(string clientName, string uri, object reqObj) where T : class
    {
        var json = JsonConvert.SerializeObject(reqObj);
        var stringContent = new StringContent(json, Encoding.UTF8, mediaType: "application/json");
        var httpClient = _clientFactory.CreateClient(clientName);

        try
        {
            _logger.LogInformation($"Request Object: {json}");
            var client = await httpClient.PostAsync(uri, stringContent);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<T>();
                _logger.LogInformation($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Success,
                    Messages = "Success",
                    Data = resultData!,
                };
            }
            else
            {
                var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                _logger.LogWarning($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Failed,
                    Messages = resultData!.Detail,
                };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }

        return default!;
    }

    public async Task<ResultObject<T>> PutAsync<T>(string clientName, string uri, object reqObj) where T : class
    {
        var json = JsonConvert.SerializeObject(reqObj);
        var stringContent = new StringContent(json, Encoding.UTF8, mediaType: "application/json");
        var httpClient = _clientFactory.CreateClient(clientName);

        try
        {
            _logger.LogInformation($"Request Object: {json}");
            var client = await httpClient.PutAsync(uri, stringContent);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<T>();
                _logger.LogInformation($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Success,
                    Messages = "Success",
                    Data = resultData!,
                };
            }
            else
            {
                var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                _logger.LogWarning($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Failed,
                    Messages = resultData!.Detail,
                };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }

        return default!;
    }

    public async Task<ResultObject<T>> PatchAsync<T>(string clientName, string uri, object reqObj) where T : class
    {
        var json = JsonConvert.SerializeObject(reqObj);
        var stringContent = new StringContent(json, Encoding.UTF8, mediaType: "application/json");
        var httpClient = _clientFactory.CreateClient(clientName);

        try
        {
            _logger.LogInformation($"Request Object: {json}");
            var client = await httpClient.PatchAsync(uri, stringContent);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<T>();
                _logger.LogInformation($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Success,
                    Messages = "Success",
                    Data = resultData!,
                };
            }
            else
            {
                var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                _logger.LogWarning($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Failed,
                    Messages = resultData!.Detail,
                };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }

        return default!;
    }

    public async Task<ResultObject<T>> DeleteAsync<T>(string clientName, string uri) where T : class
    {
        var httpClient = _clientFactory.CreateClient(clientName);

        try
        {
            var client = await httpClient.DeleteAsync(uri);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<T>();
                _logger.LogInformation($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Success,
                    Messages = "Success",
                    Data = resultData!,
                };
            }
            else
            {
                var resultData = await client.Content.ReadFromJsonAsync<ProblemDetailsResponse>();
                _logger.LogWarning($"Status Code: {client.StatusCode}");
                return new ResultObject<T>
                {
                    ResultCode = ResultCode.Failed,
                    Messages = resultData!.Detail,
                };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception: {ex}");
        }

        return default!;
    }
}