using EShop.Application.Entities;
using EShop.Application.Services.ApplicationService;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<GetAllCategoriesResponse>> GetAllCategories();
    Task<GetProductByIdResponse?> GetProductById(int productId);
    Task<IEnumerable<GetListBrandsResponse>> GetAllBrands(int pageSize = 10, int pageIndex = 0);
    Task<GetListProductResponse> SearchWithSemanticRelevance(string searchText);
    Task<ServiceResult> CreateProduct(CreateProductDto createProductDto);
    Task<ServiceResult> CreateBrand(string name, string code);
    Task<ServiceResult> UpdateProduct(UpdateProductDto updateProductDto);
    Task<ServiceResult> UpdateImageUrlProduct(int productId, string url);
    Task<ServiceResult> UpdateBrand(int brandId, string name, string code);
    Task<PaginationResponse<GetListProductResponse>> GetProductsByAdvanceFilter(GetProductsByAdvanceFilterRequest advanceFilterRequest, int pageSize = 10, int pageIndex = 0);
}