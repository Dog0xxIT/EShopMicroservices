using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;
using EShop.WebApp.Core.Core;

namespace EShop.WebApp.Services.IdentityService
{
    public class IdentityService : IIdentityService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public IdentityService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<ResultObject<ResponseObject>> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/confirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/manageInfo",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/register",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/login",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> SignOut()
        {
            return await _coreHttpClient.GetAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/logout");
        }

        public async Task<ResultObject<ResponseObject>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/refreshToken",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/resendConfirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/forgotPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/resetPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.ClientName,
                uri: "/resetManage2Fa",
                reqObj: request);
        }
    }
}
