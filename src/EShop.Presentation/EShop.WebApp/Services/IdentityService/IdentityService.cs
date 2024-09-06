using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels;
using EShop.WebApp.Core;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.Services.IdentityService
{
    public class IdentityService : IIdentityService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public IdentityService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<ResultObject> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ConfirmEmail,
                reqObj: request);
        }

        public async Task<ResultObject> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ManageInfo,
                reqObj: request);
        }

        public async Task<ResultObject> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.Register,
                reqObj: request);
        }

        public async Task<ResultObject> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ForgotPassword,
                reqObj: request);
        }

        public async Task<ResultObject> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }
    }
}
