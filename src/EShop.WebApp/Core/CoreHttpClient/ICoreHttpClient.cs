namespace EShop.WebApp.Core.CoreHttpClient;

public interface ICoreHttpClient
{
    Task<ResultObject<T>> GetAsync<T>(string clientName, string uri, object? queryObj = null) where T : class;
    Task<ResultObject<T>> PostAsync<T>(string clientName, string uri, object reqObj);
    Task<ResultObject<T>> PutAsync<T>(string clientName, string uri, object reqObj);
    Task<ResultObject<T>> PatchAsync<T>(string clientName, string uri, object reqObj);
    Task<ResultObject<T>> DeleteAsync<T>(string clientName, string uri);
}