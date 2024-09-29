using WebApp.Core.CoreHttpClient;

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
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/confirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ManageInfo(ManageInfoRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/manageInfo",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Register(RegisterRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/register",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Login(SignInRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/login",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Logout()
        {
            return await _coreHttpClient.GetAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/logout");
        }

        public async Task<ResultObject<ResponseObject>> RefreshToken(RefreshTokenRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/refreshToken",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResendConfirmEmail(ResendConfirmEmailRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/resendConfirmEmail",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ForgotPassword(ForgotPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/forgotPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> ResetPassword(ResetPasswordRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/resetPassword",
                reqObj: request);
        }

        public async Task<ResultObject<ResponseObject>> Manage2Fa(Manage2FaRequest request)
        {
            return await _coreHttpClient.PostAsync<ResponseObject>(
                clientName: UrlsConfig.IdentityClient,
                uri: "/api/v1/resetManage2Fa",
                reqObj: request);
        }
    }
}
