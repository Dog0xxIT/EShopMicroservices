namespace Basket.Api.Services.CatalogService
{
    public interface ICatalogService
    {
        Task<GetProductByIdResponse?> GetProductById(string catalogClient, int id);
    }
}
