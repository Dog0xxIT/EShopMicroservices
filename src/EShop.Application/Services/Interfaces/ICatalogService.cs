using EShop.Application.Services.ApplicationService;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts(PaginationRequest paginationReq);
    Task<IEnumerable<GetAllCategoriesResponse>> GetAllCategories();
    Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number = 10);
    Task<GetProductByIdResponse?> GetProductById(int productId);
    Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationReq);
    Task<PaginationResponse<GetListProductResponse>> SearchWithSemanticRelevance(string searchText, PaginationRequest paginationRequest);
    Task<ServiceResult> CreateProduct(CreateProductRequest req);
    Task<ServiceResult> CreateBrand(CreateBrandRequest req);
    Task<ServiceResult> UpdateProduct(UpdateProductRequest req);
    Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageReq);
    Task<ServiceResult> UpdateBrand(UpdateBrandRequest req);
    Task<PaginationResponse<GetListProductResponse>> GetProductsByAdvanceFilter(GetProductsByAdvanceFilterRequest advanceFilterReq);
}