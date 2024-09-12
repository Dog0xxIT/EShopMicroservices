using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels;
using EShop.WebApp.Core;
using EShop.WebApp.Core.CoreHttpClient;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels.Identity;

namespace EShop.WebApp.Services.IdentityService
{
    public class IdentityService : IIdentityService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public IdentityService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<ResultObject<TypedResult>> ConfirmEmail(ConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ConfirmEmail,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ManageInfo,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.Register,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.ForgotPassword,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Identity.SignIn,
                reqObj: request);
        }
    }
}
