using EShop.Application.Entities;
using EShop.Application.Services.ApplicationService;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts(PaginationRequest paginationRequest);
    Task<IEnumerable<GetAllCategoriesResponse>> GetAllCategories();
    Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number = 10);
    Task<GetProductByIdResponse?> GetProductById(int productId);
    Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest);
    Task<PaginationResponse<GetListProductResponse>> SearchWithSemanticRelevance(string searchText, PaginationRequest paginationRequest);
    Task<ServiceResult> CreateProduct(CreateProductDto createProductDto);
    Task<ServiceResult> CreateBrand(string name, string code);
    Task<ServiceResult> UpdateProduct(UpdateProductDto updateProductDto);
    Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageRequest);
    Task<ServiceResult> UpdateBrand(int brandId, string name, string code);
    Task<PaginationResponse<GetListProductResponse>> GetProductsByAdvanceFilter(GetProductsByAdvanceFilterRequest advanceFilterRequest);
}