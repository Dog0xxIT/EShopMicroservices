using Microsoft.JSInterop;
using System.Xml.Linq;

namespace EShop.WebApp.Services.AuthenticationService;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJSRuntime _jsRuntime;

    public AuthenticationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task SetTokenInCookie(string token)
    {
        await _jsRuntime.InvokeVoidAsync("setCookie", "token", token, 1);
    }

    public async Task<string> GetTokenInCookie()
    {
        return await _jsRuntime.InvokeAsync<string>("getCookie", "token");
    }
}