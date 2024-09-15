using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;

namespace EShop.WebApp.States.AuthState
{
    public interface IAccountManagement
    {
        public Task<ResultObject<TypedResult>> SignIn(SignInRequest req);

        public Task<ResultObject<TypedResult>> SignOut();
    }
}
