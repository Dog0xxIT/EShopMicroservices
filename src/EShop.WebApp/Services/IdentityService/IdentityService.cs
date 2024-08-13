using EShop.Shared.RequestModels.Identity;
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

        public async Task<ResultObject<int>> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ConfirmEmail,
                reqObj: request);
        }

        public async Task<ResultObject<int>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ManageInfo,
                reqObj: request);
        }

        public async Task<ResultObject<int>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.Register,
                reqObj: request);
        }

        public async Task<ResultObject<string>> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<string>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<string>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<string>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<int>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<int>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<int>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<int>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }
    }
}
