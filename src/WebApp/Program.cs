using EShop.WebApp.States;
using EShop.WebApp.States.AuthState;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp;
using WebApp.Core.CoreHttpClient;
using WebApp.Services.CatalogService;
using WebApp.Services.IdentityService;
using WebApp.States.AuthState;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddHttpClient(UrlsConfig.CatalogClient, httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://localhost:7038");
        })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(UrlsConfig.BasketClient, httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7212");
    })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(UrlsConfig.IdentityClient, httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7283");
    })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(UrlsConfig.OrderClient, httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7038");
    })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services.AddTelerikBlazor();
builder.Services.AddTransient<CookieHandler>();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CookieAuthenticationStateProvider>();
builder.Services.AddScoped(sp => (IAccountManagement)sp.GetRequiredService<AuthenticationStateProvider>());
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<ICoreHttpClient, CoreHttpClient>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<ICatalogService, CatalogService>();
builder.Services.AddScoped<IBasketService, BasketService>();
await builder.Build().RunAsync();
