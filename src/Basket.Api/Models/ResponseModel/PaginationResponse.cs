namespace Basket.Api.Models.ResponseModel
{
    public sealed class PaginationResponse<T> where T : class
    {
        public Pagination Meta { get; set; } = new();
        public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();
    }
}
