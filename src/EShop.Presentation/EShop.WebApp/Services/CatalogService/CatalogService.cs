using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp;
using EShop.WebApp.Core;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.Services.CatalogService
{
    public class CatalogService : ICatalogService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public CatalogService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                 clientName: UrlsConfig.ClientName,
                 uri: "/catalog/products",
                 queryObj: req);

            return resultObject.Data;
        }


        public async Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<GetProductByIdResponse>(
                clientName: UrlsConfig.ClientName,
                uri: $"/catalog/products/{productId}");
        }

        public async Task<PaginationResponse<GetAllBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetAllBrandsResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: "/catalog/brands",
                queryObj: paginationRequest);
            return resultObject.Data;
        }

        public async Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<PaginationResponse<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: "/catalog/categories",
                queryObj: paginationRequest);

            return resultObject.Data;
        }

        public async Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number)
        {
            var resultObject = await _coreHttpClient.GetAsync<IEnumerable<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: $"/catalog/categories/{number}");
            return resultObject.Data;
        }
    }
}
