using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;

namespace EShop.WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject<TypedResult>> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject<TypedResult>> ManageInfo(ManageInfoRequest request);
    Task<ResultObject<TypedResult>> Register(RegisterRequest request);
    Task<ResultObject<TypedResult>> SignIn(SignInRequest request);
    Task<ResultObject<TypedResult>> SignOut();
    Task<ResultObject<TypedResult>> RefreshToken(RefreshTokenRequest request);
    Task<ResultObject<TypedResult>> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject<TypedResult>> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject<TypedResult>> ResetPassword(ResetPasswordRequest request);
    Task<ResultObject<TypedResult>> Manage2Fa(Manage2FaRequest request);
}