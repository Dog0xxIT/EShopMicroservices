namespace Identity.Api.Services
{
    public class ServiceResult
    {
        public int StatusCode { get; private set; }
        public bool Succeeded { get; private set; }
        public string Message { get; private set; }

        private ServiceResult(int statusCode, bool success)
        {
            StatusCode = statusCode;
            Succeeded = success;
            Message = "";
        }

        private ServiceResult(int statusCode, string message)
        {
            StatusCode = statusCode;
            Succeeded = false;
            Message = message;
        }

        public static ServiceResult Success(
            int statusCode = StatusCodes.Status200OK)
            => new(statusCode, true);

        public static ServiceResult Failed(
            string message, 
            int statusCode = StatusCodes.Status500InternalServerError)
            => new(statusCode, message);
    }
}
