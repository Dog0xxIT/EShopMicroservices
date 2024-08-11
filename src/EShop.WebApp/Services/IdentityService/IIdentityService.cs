using EShop.Shared.RequestModels.Identity;
using EShop.WebApp.Pages.User;

namespace EShop.WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<int> ConfirmEmail(ConfirmEmailRequest request);
    Task<int> ManageInfo(ManageInfoRequest request);
    Task<int> Register(RegisterRequest request);
    Task<string> SignIn(SignInRequest request);
    Task<string> RefreshToken(RefreshTokenRequest request);
    Task<int> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<int> ForgotPassword(ForgotPasswordRequest request);
    Task<int> ResetPassword(ResetPasswordRequest request);
    Task<int> Manage2Fa(Manage2FaRequest request);
}