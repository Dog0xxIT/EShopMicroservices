using EShop.WebApp.Components.Common;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;

namespace EShop.WebApp.States;

public class JwtAuthenticationStateProvider : AuthenticationStateProvider
{
    private bool _authenticated;

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return new AuthenticationState(new());
    }
}