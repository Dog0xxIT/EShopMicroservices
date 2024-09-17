using EShop.Application.Services.ApplicationService;
using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;

namespace EShop.Application.Services.Interfaces;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req);
    Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationReq);
    Task<GetProductByIdResponse?> GetProductById(int productId);
    Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationReq);
    Task<ServiceResult> CreateProduct(CreateProductRequest req);
    Task<ServiceResult> CreateBrand(CreateBrandRequest req);
    Task<ServiceResult> UpdateProduct(UpdateProductRequest req);
    Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageReq);
    Task<ServiceResult> DeleteImageProduct(int productId);
    Task<ServiceResult> UpdateBrand(UpdateBrandRequest req);
    Task<bool> CheckExistBrand(int brandId);
    Task<bool> CheckExistProduct(int productId);
    Task<bool> CheckExistCategory(int categoryId);
}