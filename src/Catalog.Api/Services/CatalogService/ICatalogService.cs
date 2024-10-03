using Catalog.Api.Service;

namespace Catalog.Api.Services.CatalogService;

public interface ICatalogService
{
    Task<PaginationResponse<GetListBrandsResponse>> GetListBrands(PaginationRequest req);
    Task<ServiceResult> CreateBrand(CreateBrandRequest req);
    Task<ServiceResult> UpdateBrand(UpdateBrandRequest req);
    Task<ServiceResult> DeleteBrand(int id);
    Task<List<GetAllCategoriesResponse>> GetAllCategoriesHierarchy();
    Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories();
    Task<PaginationResponse<GetListProductResponse>> GetListProducts(GetListProductRequest req);
    Task<ServiceResult> CreateProduct(CreateProductRequest req);
    Task<GetProductByIdResponse> GetProductById(int id);
    Task<ServiceResult> UpdateProduct(UpdateProductRequest req);
    Task<ServiceResult> DeleteProduct(int id);
}