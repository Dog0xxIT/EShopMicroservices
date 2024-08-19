using EShop.Application.Entities;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllProducts();
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandId(int brandId);
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByCategoryId(int categoryId);
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByBrandAndCategoryId(int brandId,
        int categoryId);
    Task<ResultObject<Product>> GetProductById(int productId);
    Task<ResultObject<IEnumerable<Brand>>> GetAllBrands();
    Task<ResultObject<IEnumerable<Category>>> GetAllCategories();
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllImagesOfProduct(int productId);
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> SearchWithSemanticRelevance(string text);
    Task<ResultObject<SuccessObjectResponse>> UploadProductImage(UploadProductImageRequest request);
    Task<ResultObject<SuccessObjectResponse>> CreateProduct(CreateProductRequest request);
    Task<ResultObject<SuccessObjectResponse>> CreateBrand(CreateBrandRequest request);
    Task<ResultObject<SuccessObjectResponse>> UpdateProduct(UpdateProductRequest request);
    Task<ResultObject<SuccessObjectResponse>> UpdateBrand(UpdateBrandRequest request);
}