namespace Basket.Api.Services
{
    public class ServiceResult
    {
        public bool Succeeded { get; private set; }
        public IEnumerable<string> Errors { get; private set; }

        private ServiceResult(bool success)
        {
            Succeeded = success;
            Errors = Enumerable.Empty<string>();
        }

        private ServiceResult(IEnumerable<string> errors)
        {
            Succeeded = false;
            Errors = errors;
        }

        public static ServiceResult Success => new(true);

        public static ServiceResult Failed(params string[] errors) => new(errors);

        public static ServiceResult Failed(IEnumerable<string> errors) => new(errors);
    }
}
