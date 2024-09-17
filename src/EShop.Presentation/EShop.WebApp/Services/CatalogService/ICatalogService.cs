using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp;
using EShop.WebApp.Core;

namespace EShop.WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req);
    Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId);
    Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number);
    Task<PaginationResponse<GetAllBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest);
    Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationRequest);
}