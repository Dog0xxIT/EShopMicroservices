using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.WebApp.Pages.User;

namespace EShop.WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject> ManageInfo(ManageInfoRequest request);
    Task<ResultObject> Register(RegisterRequest request);
    Task<ResultObject> SignIn(SignInRequest request);
    Task<ResultObject> RefreshToken(RefreshTokenRequest request);
    Task<ResultObject> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject> ResetPassword(ResetPasswordRequest request);
    Task<ResultObject> Manage2Fa(Manage2FaRequest request);
}