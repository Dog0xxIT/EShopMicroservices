using EShop.Data.Entities;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;

namespace EShop.WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts();
    Task<PaginationResponse<GetListProductResponse>> GetProductsByBrandId(int brandId);
    Task<PaginationResponse<GetListProductResponse>> GetProductsByCategoryId(int categoryId);
    Task<PaginationResponse<GetListProductResponse>> GetProductsByBrandAndCategoryId(int brandId, int categoryId);
    Task<Product> GetProductById(int productId);
    Task<IEnumerable<Brand>> GetAllBrands();
    Task<IEnumerable<Category>> GetAllCategories();
    Task<PaginationResponse<GetListProductResponse>> GetAllImagesOfProduct(int productId);
    Task<PaginationResponse<GetListProductResponse>> SearchWithSemanticRelevance(string text);
    Task<int> UploadProductImage(UploadProductImageRequest request);
    Task<int> CreateProduct(CreateProductRequest request);
    Task<int> CreateBrand(CreateBrandRequest request);
    Task<int> UpdateProduct(UpdateProductRequest request);
    Task<int> UpdateBrand(UpdateBrandRequest request);
}