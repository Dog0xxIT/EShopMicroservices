using System.Net.Http.Json;
using System.Security.Claims;
using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels.Identity;
using EShop.WebApp.Core;
using EShop.WebApp.Services.IdentityService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace EShop.WebApp.States.AuthState;

public class CookieAuthenticationStateProvider : AuthenticationStateProvider, IAccountManagement
{

    private readonly IHttpClientFactory _clientFactory;
    private readonly IIdentityService _identityService;

    /// <summary>
    /// Authentication state.
    /// </summary>
    private bool _authenticated = false;

    /// <summary>
    /// Default principal for anonymous (not authenticated) users.
    /// </summary>
    private readonly ClaimsPrincipal _unauthenticated = new(new ClaimsIdentity());

    public CookieAuthenticationStateProvider(IHttpClientFactory clientFactory, IIdentityService identityService)
    {
        _clientFactory = clientFactory;
        _identityService = identityService;
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
            request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
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

                    var id = new ClaimsIdentity(claims, nameof(CookieAuthenticationStateProvider));
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

    public async Task<ResultObject<ResponseObject>> SignIn(SignInRequest req)
    {
        var resultObject = await _identityService.SignIn(req);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        return resultObject;
    }

    public async Task<ResultObject<ResponseObject>> SignOut()
    {
        var resultObject = await _identityService.SignOut();
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        return resultObject;
    }
}