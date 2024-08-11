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

        public async Task<int> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ConfirmEmail,
                reqObj: request);
        }

        public async Task<int> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ManageInfo,
                reqObj: request);
        }

        public async Task<int> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.Register,
                reqObj: request);
        }

        public async Task<string> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<string>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<string> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<string>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<int> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<int> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<int> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<int> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<int>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }
    }
}
