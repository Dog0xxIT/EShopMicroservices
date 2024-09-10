using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
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

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllProducts(PaginationRequest paginationRequest)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                  clientName: UrlsConfig.ClientName,
                  uri: UrlsConfig.Catalog.GetAllProducts,
                  queryObj: paginationRequest);
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandId(int brandId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByBrandId,
                queryObj: new { brandId });
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByCategoryId(
            int categoryId, PaginationRequest paginationRequest)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByCategoryId + $"/{categoryId}",
                queryObj: paginationRequest);
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandAndCategoryId(
            int brandId, int categoryId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByBrandAndCategoryId,
                queryObj: new { brandId, categoryId });
        }

        public async Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<GetProductByIdResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductById + $"/{productId}");
        }

        public async Task<ResultObject<IEnumerable<GetAllBrandsResponse>>> GetAllBrands()
        {
            return await _coreHttpClient.GetAsync<IEnumerable<GetAllBrandsResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllBrands);
        }

        public async Task<ResultObject<IEnumerable<GetAllCategoriesResponse>>> GetAllCategories()
        {
            return await _coreHttpClient.GetAsync<IEnumerable<GetAllCategoriesResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllCategories);
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllImagesOfProduct(int productId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllImagesOfProduct);
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
