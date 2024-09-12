using EShop.WebApp;
using EShop.WebApp.Core;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.WebApp.Services.AuthenticationService;
using EShop.WebApp.Services.CatalogService;
using EShop.WebApp.Services.IdentityService;
using EShop.WebApp.States;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient(UrlsConfig.ClientName, httpClient =>
{
    httpClient.BaseAddress = new Uri("https://localhost:7093");
});

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<ICoreHttpClient, CoreHttpClient>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<ICatalogService, CatalogService>();
builder.Services.AddSingleton<AlertState>();
await builder.Build().RunAsync();
