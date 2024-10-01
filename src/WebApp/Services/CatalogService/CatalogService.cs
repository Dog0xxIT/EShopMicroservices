using WebApp.Core.CoreHttpClient;
using WebApp.Models.RequestModels.Common;
using WebApp.Models.ResponseModels;
using WebApp.Models.ResponseModels.Common;

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
                clientName: ClientsConfig.CatalogClient,
                uri: "api/v1/products",
                queryObj: paginationRequest);

            return resultObject.Data;
        }

        public async Task<List<GetAllCategoriesResponse>> GetAllCategoriesHierarchy()
        {
            var resultObject = await _coreHttpClient.GetAsync<List<GetAllCategoriesResponse>>(
                clientName: ClientsConfig.CatalogClient,
                uri: "api/v1/categories/hierarchy");

            return resultObject.Data;
        }

        public async Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories()
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetAllCategoriesResponse>>(
                clientName: ClientsConfig.CatalogClient,
                uri: "api/v1/categories");

            return resultObject.Data;
        }

        public async Task<PaginationResponse<GetListProductResponse>> GetListProducts(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                 clientName: ClientsConfig.CatalogClient,
                 uri: "api/v1/products",
                 queryObj: paginationRequest);

            return resultObject.Data;
        }


        public async Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<GetProductByIdResponse>(
                clientName: ClientsConfig.CatalogClient,
                uri: $"api/v1/products/{productId}");
        }
    }
}
