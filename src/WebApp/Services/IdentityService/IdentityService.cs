using WebApp.Core.CoreHttpClient;
using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Services.IdentityService
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
                clientName: UrlsConfig.CatalogClient,
                uri: "/confirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/manageInfo",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/register",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> SignIn(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/login",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> SignOut()
        {
            return await _coreHttpClient.GetAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/logout");
        }

        public async Task<ResultObject<ResponseObject>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/refreshToken",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/resendConfirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/forgotPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/resetPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/resetManage2Fa",
                reqObj: request);
        }
    }
}
