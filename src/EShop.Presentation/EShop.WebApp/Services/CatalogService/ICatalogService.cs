using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core.CoreHttpClient;

namespace EShop.WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetAllProducts(PaginationRequest paginationRequest);
    Task<ResultObject<PaginationResponse<GetListProductResponse>>> GetProductsByAdvanceFilter(GetProductsByAdvanceFilterRequest request);
    Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId);
    Task<ResultObject<PaginationResponse<GetListBrandsResponse>>> GetAllBrands(PaginationRequest paginationRequest);
    Task<ResultObject<IEnumerable<GetAllCategoriesResponse>>> GetAllCategories();
    Task<ResultObject<IEnumerable<GetAllCategoriesResponse>>> GetTopCategories(int number);
}