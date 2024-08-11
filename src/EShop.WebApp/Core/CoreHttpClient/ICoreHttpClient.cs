namespace EShop.WebApp.Core.CoreHttpClient;

public interface ICoreHttpClient
{
    Task<T> GetAsync<T>(string clientName, string uri, object? queryObj = null) where T : class;
    Task<T> PostAsync<T>(string clientName, string uri, object reqObj);
    Task<T> PutAsync<T>(string clientName, string uri, object reqObj);
    Task<T> PatchAsync<T>(string clientName, string uri, object reqObj);
    Task<T> DeleteAsync<T>(string clientName, string uri);
}