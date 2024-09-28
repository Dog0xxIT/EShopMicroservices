namespace Basket.Api.Services.CatalogService
{
    public interface ICatalogService
    {
        Task<GetBaseInfoProductResponse?> GetBaseInfoProduct(string catalogClient, int id);
    }
}
