using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp;
using WebApp.Core.CoreHttpClient;
using WebApp.Services.CatalogService;
using WebApp.Services.IdentityService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddHttpClient(ClientsConfig.CatalogClient, httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://localhost:7038");
        })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(ClientsConfig.BasketClient, httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7212");
    })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(ClientsConfig.IdentityClient, httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7283");
    })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services
    .AddHttpClient(ClientsConfig.OrderClient, httpClient =>
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
