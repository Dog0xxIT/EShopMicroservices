using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using WebApp.Models.RequestModels.Identity;
using WebApp.Models.ResponseModels.Common;
using WebApp.Models.ResponseModels.Identity;
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

        var httpClient = _clientFactory.CreateClient(ClientsConfig.IdentityClient);
        var response1 = await httpClient.GetAsync("/api/v1/manageInfo");

        if (!response1.IsSuccessStatusCode)
        {
            var response2 = await httpClient.GetAsync("/api/v1/refreshToken");
            if (!response2.IsSuccessStatusCode)
            {
                return new AuthenticationState(user);
            }
        }

        var resultData = await response1.Content.ReadFromJsonAsync<ManageInfoResponse>();
        if (resultData == null)
        {
            return new AuthenticationState(user);
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Sid, resultData.UserId),
            new(ClaimTypes.Email, resultData.Email)
        };

        claims.AddRange(resultData.Roles.Select(role =>
            new Claim(ClaimTypes.Role, role)));
        var id = new ClaimsIdentity(claims, nameof(CookieAuthenticationStateProvider));
        user = new ClaimsPrincipal(id);
        _authenticated = true;
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