using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject<ResponseObject>> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject<ResponseObject>> ManageInfo(ManageInfoRequest request);
    Task<ResultObject<ResponseObject>> Register(RegisterRequest request);
    Task<ResultObject<ResponseObject>> SignIn(SignInRequest request);
    Task<ResultObject<ResponseObject>> SignOut();
    Task<ResultObject<ResponseObject>> RefreshToken(RefreshTokenRequest request);
    Task<ResultObject<ResponseObject>> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject<ResponseObject>> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject<ResponseObject>> ResetPassword(ResetPasswordRequest request);
    Task<ResultObject<ResponseObject>> Manage2Fa(Manage2FaRequest request);
}