using EShop.WebApp.Components.Common;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.WebApp.Services.IdentityService;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels;
using System;
using System.Net.Http.Json;
using EShop.Shared.ResponseModels.Identity;
using EShop.WebApp.Core;

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
            var client = await httpClient.GetAsync(UrlsConfig.Identity.ManageInfo);

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
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public async Task<bool> CheckAuthenticatedAsync()
    {
        await GetAuthenticationStateAsync();
        return _authenticated;
    }
}