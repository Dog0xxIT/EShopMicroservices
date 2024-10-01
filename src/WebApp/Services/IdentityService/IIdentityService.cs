using WebApp.Models.RequestModels.Identity;
using WebApp.Models.ResponseModels.Common;

namespace WebApp.Services.IdentityService;

public interface IIdentityService
{
    Task<ResultObject<ResponseObject>> ConfirmEmail(ConfirmEmailRequest request);
    Task<ResultObject<ResponseObject>> Logout();
    Task<ResultObject<ResponseObject>> Register(RegisterRequest request);
    Task<ResultObject<ResponseObject>> Login(SignInRequest request);
    Task<ResultObject<ResponseObject>> ResendConfirmEmail(ResendConfirmEmailRequest request);
    Task<ResultObject<ResponseObject>> ForgotPassword(ForgotPasswordRequest request);
    Task<ResultObject<ResponseObject>> ResetPassword(ResetPasswordRequest request);
}