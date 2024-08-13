using EShop.Shared.RequestModels.Identity;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.WebApp.Pages.User;

namespace EShop.WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject<int>> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject<int>> ManageInfo(ManageInfoRequest request);
    Task<ResultObject<int>> Register(RegisterRequest request);
    Task<ResultObject<string>> SignIn(SignInRequest request);
    Task<ResultObject<string>> RefreshToken(RefreshTokenRequest request);
    Task<ResultObject<int>> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject<int>> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject<int>> ResetPassword(ResetPasswordRequest request);
    Task<ResultObject<int>> Manage2Fa(Manage2FaRequest request);
}