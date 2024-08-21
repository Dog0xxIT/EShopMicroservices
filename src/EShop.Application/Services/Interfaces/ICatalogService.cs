using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<IEnumerable<Product>> GetAllProducts(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> GetProductsByBrandId(int brandId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> GetProductsByBrandAndCategoryId(int brandId, int categoryId, int pageSize = 10,
        int pageIndex = 0);
    Task<Product?> GetProductById(int productId);
    Task<Brand> GetAllBrands();
    Task<Product> GetAllImagesOfProduct();
    Task<Product> SearchWithSemanticRelevance();
    Task<int> UploadProductImage();
    Task<int> CreateProduct();
    Task<int> CreateBrand();
    Task<int> UpdateProduct();
    Task<int> UpdateBrand();
}