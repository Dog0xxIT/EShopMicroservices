namespace Basket.Api.Services.IdentityService;

public interface IIdentityService
{
    Task<bool> CheckExistsUser(string identityClient, int userId);
}