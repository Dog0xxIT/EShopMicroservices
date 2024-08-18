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

        public async Task<ResultObject<SuccessObjectResponse>> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ConfirmEmail,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ManageInfo,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.Register,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ForgotPassword,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }
    }
}
