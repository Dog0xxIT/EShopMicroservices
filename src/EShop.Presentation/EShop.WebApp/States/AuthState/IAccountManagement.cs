using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using ResponseObject = EShop.WebApp.Core.ResponseModels.Common.ResponseObject;
using SignInRequest = EShop.WebApp.Core.RequestModels.Identity.SignInRequest;

namespace EShop.WebApp.States.AuthState
{
    public interface IAccountManagement
    {
        public Task<ResultObject<ResponseObject>> SignIn(SignInRequest req);

        public Task<ResultObject<ResponseObject>> SignOut();
    }
}
