namespace Order.Api.Models.ResponseModels
{
    public sealed class ResponseObject
    {
        public string Message { get; set; } = "Success";

        public static ResponseObject Succeeded => new();
    }
}
