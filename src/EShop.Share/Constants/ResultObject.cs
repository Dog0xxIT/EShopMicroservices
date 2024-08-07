namespace EShop.Shared.Constants
{
    public class ResultObject<T>
    {
        public string StatusCode { get; set; }
        public T ResultData { get; set; }
        public string Message { get; set; }

        public ResultObject(string statusCode, T resultData, string message)
        {
            StatusCode = statusCode;
            ResultData = resultData;
            Message = message;
        }
    }

    public class ResultObject
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }

        public ResultObject(string statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}