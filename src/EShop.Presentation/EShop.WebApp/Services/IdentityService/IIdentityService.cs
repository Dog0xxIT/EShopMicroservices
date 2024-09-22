using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using ConfirmEmailRequest = EShop.WebApp.Core.RequestModels.Identity.ConfirmEmailRequest;
using ForgotPasswordRequest = EShop.WebApp.Core.RequestModels.Identity.ForgotPasswordRequest;
using ManageInfoRequest = EShop.WebApp.Core.RequestModels.Identity.ManageInfoRequest;
using RefreshTokenRequest = EShop.WebApp.Core.RequestModels.Identity.RefreshTokenRequest;
using RegisterRequest = EShop.WebApp.Core.RequestModels.Identity.RegisterRequest;
using ResetPasswordRequest = EShop.WebApp.Core.RequestModels.Identity.ResetPasswordRequest;
using ResponseObject = EShop.WebApp.Core.ResponseModels.Common.ResponseObject;
using SignInRequest = EShop.WebApp.Core.RequestModels.Identity.SignInRequest;

namespace EShop.WebApp.Services.IdentityService;

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