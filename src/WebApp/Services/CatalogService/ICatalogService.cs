using WebApp.Models.RequestModels.Common;
using WebApp.Models.ResponseModels;
using WebApp.Models.ResponseModels.Common;

namespace WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<PaginationResponse<GetListBrandsResponse>> GetListBrands(PaginationRequest paginationRequest);
    Task<List<GetAllCategoriesResponse>> GetAllCategoriesHierarchy();
    Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories();
    Task<PaginationResponse<GetListProductResponse>> GetListProducts(PaginationRequest paginationRequest);
    Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId);
}