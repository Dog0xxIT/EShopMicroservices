using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Net.Http.Json;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels.Identity;
using EShop.WebApp.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.States;

public class JwtAuthenticationStateProvider : AuthenticationStateProvider
{

    private readonly IHttpClientFactory _clientFactory;


    /// <summary>
    /// Authentication state.
    /// </summary>
    private bool _authenticated = false;

    /// <summary>
    /// Default principal for anonymous (not authenticated) users.
    /// </summary>
    private readonly ClaimsPrincipal _unauthenticated = new(new ClaimsIdentity());

    public JwtAuthenticationStateProvider(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        _authenticated = false;
        // default to not authenticated
        var user = _unauthenticated;

        var httpClient = _clientFactory.CreateClient(UrlsConfig.ClientName);

        try
        {
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            //request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
            request.RequestUri = new Uri("https://localhost:7093/Identity/ManageInfo");

            var client = await httpClient.SendAsync(request);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<ManageInfoResponse>();
                if (resultData != null)
                {
                    var claims = new List<Claim>
                    {
                        new(ClaimTypes.Email, resultData.Email)
                    };

                    foreach (var role in resultData.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var id = new ClaimsIdentity(claims, nameof(JwtAuthenticationStateProvider));
                    user = new ClaimsPrincipal(id);
                    _authenticated = true;
                }
            }
        }
        catch (Exception ex)
        {
            _authenticated = false;
        }

        return new AuthenticationState(user);
    }

    public async Task LogoutAsync()
    {
        var httpClient = _clientFactory.CreateClient(UrlsConfig.ClientName);

        try
        {
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            //request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
            request.RequestUri = new Uri("https://localhost:7093/Identity/SignOut");

            var client = await httpClient.SendAsync(request);

            if (client.IsSuccessStatusCode)
            {
                var resultData = await client.Content.ReadFromJsonAsync<TypedResult>();
                if (resultData?.Status == 200)
                {
                    NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                }
            }
        }
        catch (Exception ex)
        {
            
        }
    }

    public async Task<bool> CheckAuthenticatedAsync()
    {
        await GetAuthenticationStateAsync();
        return _authenticated;
    }
}