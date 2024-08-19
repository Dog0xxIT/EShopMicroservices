using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.WebApp.Pages.User;

namespace EShop.WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject<SuccessObjectResponse>> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject<SuccessObjectResponse>> ManageInfo(ManageInfoRequest request);
    Task<ResultObject<SuccessObjectResponse>> Register(RegisterRequest request);
    Task<ResultObject<SuccessObjectResponse>> SignIn(SignInRequest request);
    Task<ResultObject<SuccessObjectResponse>> RefreshToken(RefreshTokenRequest request);
    Task<ResultObject<SuccessObjectResponse>> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject<SuccessObjectResponse>> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject<SuccessObjectResponse>> ResetPassword(ResetPasswordRequest request);
    Task<ResultObject<SuccessObjectResponse>> Manage2Fa(Manage2FaRequest request);
}