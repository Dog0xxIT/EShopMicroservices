using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core.Core;
using EShop.WebApp.Services.CatalogService;

namespace EShop.WebApp.Core.Services.CatalogService
{
    public class CatalogService : ICatalogService
    {
        private readonly ICoreHttpClient _coreHttpClient;

        public CatalogService(ICoreHttpClient coreHttpClient)
        {
            _coreHttpClient = coreHttpClient;
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllProducts(PaginationRequest paginationRequest)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                  clientName: UrlsConfig.ClientName,
                  uri: UrlsConfig.Catalog.GetAllProducts,
                  queryObj: paginationRequest);
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByAdvanceFilter(GetProductsByAdvanceFilterRequest request)
        {
            return await _coreHttpClient.PostAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByAdvanceFilter,
                reqObj: request);
        }


        public async Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<GetProductByIdResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductById + $"/{productId}");
        }

        public async Task<ResultObject<PaginationResponse<GetListBrandsResponse>>> GetAllBrands(PaginationRequest paginationRequest)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListBrandsResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllBrands,
                queryObj: paginationRequest);
        }

        public async Task<ResultObject<IEnumerable<GetAllCategoriesResponse>>> GetAllCategories()
        {
            return await _coreHttpClient.GetAsync<IEnumerable<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllCategories);
        }

        public async Task<ResultObject<IEnumerable<GetAllCategoriesResponse>>> GetTopCategories(int number)
        {
            return await _coreHttpClient.GetAsync<IEnumerable<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetTopCategories,
                queryObj: new { number });
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> SearchWithSemanticRelevance(
            string text)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.SearchWithSemanticRelevance,
                queryObj: text);
        }

        public async Task<ResultObject<TypedResult>> UploadProductImage(UploadProductImageRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultObject<TypedResult>> CreateProduct(CreateProductRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.CreateProduct,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> CreateBrand(CreateBrandRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.CreateBrand,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> UpdateProduct(UpdateProductRequest request)
        {
            return await _coreHttpClient.PostAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.UpdateProduct,
                reqObj: request);
        }

        public async Task<ResultObject<TypedResult>> UpdateBrand(UpdateBrandRequest request)
        {
            return await _coreHttpClient.PutAsync<TypedResult>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.UpdateBrand,
                reqObj: request);
        }
    }
}
