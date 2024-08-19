namespace EShop.WebApp.Services.AuthenticationService;

public interface IAuthenticationService
{
    Task SetTokenInCookie(string token);
    Task<string> GetTokenInCookie();
}