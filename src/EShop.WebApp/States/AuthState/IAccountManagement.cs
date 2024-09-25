using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.States.AuthState
{
    public interface IAccountManagement
    {
        public Task<ResultObject<ResponseObject>> SignIn(SignInRequest req);

        public Task<ResultObject<ResponseObject>> SignOut();
    }
}
