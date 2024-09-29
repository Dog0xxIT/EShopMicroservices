namespace WebApp.States.AuthState
{
    public interface IAccountManagement
    {
        public Task<ResultObject<ResponseObject>> Login(SignInRequest req);

        public Task<ResultObject<ResponseObject>> Logout();
    }
}
