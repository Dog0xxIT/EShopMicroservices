using WebApp.Core.CoreHttpClient;
using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Services.CatalogService
{
    public class CatalogService : ICatalogService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public CatalogService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<PaginationResponse<GetListBrandsResponse>> GetListBrands(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetListBrandsResponse>>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/products",
                queryObj: paginationRequest);

            return resultObject.Data;
        }

        public async Task<List<GetAllCategoriesResponse>> GetAllCategoriesHierarchy()
        {
            var resultObject = await _coreHttpClient.GetAsync<List<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/categories/hierarchy");

            return resultObject.Data;
        }

        public async Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories()
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.CatalogClient,
                uri: "/categories");

            return resultObject.Data;
        }

        public async Task<PaginationResponse<GetListProductResponse>> GetListProducts(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                 clientName: UrlsConfig.CatalogClient,
                 uri: "/products",
                 queryObj: paginationRequest);

            return resultObject.Data;
        }


        public async Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<GetProductByIdResponse>(
                clientName: UrlsConfig.CatalogClient,
                uri: $"/products/{productId}");
        }
    }
}
