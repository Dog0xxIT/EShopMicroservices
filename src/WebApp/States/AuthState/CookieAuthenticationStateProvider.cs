using System.Security.Claims;
using EShop.WebApp.States.AuthState;
using Microsoft.AspNetCore.Components.Authorization;
using WebApp.Services.IdentityService;

namespace WebApp.States.AuthState;

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

        var httpClient = _clientFactory.CreateClient(UrlsConfig.IdentityClient);

        try
        {
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
            request.RequestUri = new Uri("api/v1/manageInfo");

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

    public async Task<ResultObject<ResponseObject>> Login(SignInRequest req)
    {
        var resultObject = await _identityService.Login(req);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        return resultObject;
    }

    public async Task<ResultObject<ResponseObject>> Logout()
    {
        var resultObject = await _identityService.Logout();
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        return resultObject;
    }
}