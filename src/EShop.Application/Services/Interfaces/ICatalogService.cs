using EShop.Application.Dto;
using EShop.Application.Dto.Catalog;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<IEnumerable<ProductDto>> GetAllProducts(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<ProductDto>> GetProductsByBrandId(int brandId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<ProductDto>> GetProductsByCategoryId(int categoryId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<CategoryDto>> GetAllCategories();
    Task<IEnumerable<ProductDto>> GetProductsByBrandAndCategoryId(int brandId, int categoryId, int pageSize = 10, int pageIndex = 0);
    Task<ProductDto?> GetProductById(int productId);
    Task<IEnumerable<BrandDto>> GetAllBrands(int pageSize = 10, int pageIndex = 0);
    Task<ProductDto> SearchWithSemanticRelevance(string searchText);
    Task<ServiceResult> CreateProduct(CreateProductDto createProductDto);
    Task<ServiceResult> CreateBrand(string name, string code);
    Task<ServiceResult> UpdateProduct(UpdateProductDto updateProductDto);
    Task<ServiceResult> UpdateImageUrlProduct(int productId, string url);
    Task<ServiceResult> UpdateBrand(int brandId, string name, string code);
}