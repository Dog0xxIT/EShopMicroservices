using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core.CoreHttpClient;
using GetAllBrandsResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetAllBrandsResponse;
using GetAllCategoriesResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetAllCategoriesResponse;
using GetAllProductRequest = EShop.WebApp.Core.RequestModels.Catalog.GetAllProductRequest;
using GetListProductResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetListProductResponse;
using GetProductByIdResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetProductByIdResponse;
using PaginationRequest = EShop.WebApp.Core.RequestModels.Common.PaginationRequest;

namespace EShop.WebApp.Services.CatalogService
{
    public class CatalogService : ICatalogService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public CatalogService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<Core.ResponseModels.Common.PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req)
        {
            var resultObject = await _coreHttpClient.GetAsync<Core.ResponseModels.Common.PaginationResponse<GetListProductResponse>>(
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

        public async Task<Core.ResponseModels.Common.PaginationResponse<GetAllBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<Core.ResponseModels.Common.PaginationResponse<GetAllBrandsResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: "/catalog/brands",
                queryObj: paginationRequest);
            return resultObject.Data;
        }

        public async Task<Core.ResponseModels.Common.PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationRequest)
        {
            var resultObject = await _coreHttpClient.GetAsync<Core.ResponseModels.Common.PaginationResponse<GetAllCategoriesResponse>>(
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
