using EShop.Data.Entities;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;
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

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllProducts()
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                  clientName: UrlsConfig.ClientName,
                  uri: UrlsConfig.Catalog.GetAllProducts);
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandId(int brandId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByBrandId,
                queryObj: new { brandId });
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByCategoryId(
            int categoryId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByCategoryId,
                queryObj: new { categoryId });
        }

        public async Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandAndCategoryId(
            int brandId, int categoryId)
        {
            return await _coreHttpClient.GetAsync<PaginationResponse<GetListProductResponse>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductsByBrandAndCategoryId,
                queryObj: new { brandId, categoryId });
        }


        public async Task<ResultObject<Product>> GetProductById(int productId)
        {
            return await _coreHttpClient.GetAsync<Product>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetProductById,
                queryObj: new { productId });
        }


        public async Task<ResultObject<IEnumerable<Brand>>> GetAllBrands()
        {
            return await _coreHttpClient.GetAsync<IEnumerable<Brand>>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.GetAllBrands);
        }

        public async Task<ResultObject<IEnumerable<Category>>> GetAllCategories()
        {
            return await _coreHttpClient.GetAsync<IEnumerable<Category>>(
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


        public async Task<ResultObject<SuccessObjectResponse>> UploadProductImage(UploadProductImageRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultObject<SuccessObjectResponse>> CreateProduct(CreateProductRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.CreateProduct,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> CreateBrand(CreateBrandRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.CreateBrand,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> UpdateProduct(UpdateProductRequest request)
        {
            return await _coreHttpClient.PostAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.UpdateProduct,
                reqObj: request);
        }

        public async Task<ResultObject<SuccessObjectResponse>> UpdateBrand(UpdateBrandRequest request)
        {
            return await _coreHttpClient.PutAsync<SuccessObjectResponse>(
                clientName: UrlsConfig.ClientName,
                uri: UrlsConfig.Catalog.UpdateBrand,
                reqObj: request);
        }
    }
}
