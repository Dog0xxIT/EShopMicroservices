using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using WebApp.Services.IdentityService;

namespace WebApp.States.AuthState;

public class CookieAuthenticationStateProvider : AuthenticationStateProvider, IAccountManagement
{

    private readonly IIdentityService _identityService;

    /// <summary>
    /// Authentication state.
    /// </summary>
    private bool _authenticated = false;

    /// <summary>
    /// Default principal for anonymous (not authenticated) users.
    /// </summary>
    private readonly ClaimsPrincipal _unauthenticated = new(new ClaimsIdentity());

    public CookieAuthenticationStateProvider(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        _authenticated = false;
        // default to not authenticated
        var user = _unauthenticated;

        var resultObject = await _identityService.ManageInfo();
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            var resultData = resultObject.Data;
            if (resultData != null)
            {
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
            }
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