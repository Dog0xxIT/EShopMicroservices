using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using GetAllBrandsResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetAllBrandsResponse;
using GetAllCategoriesResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetAllCategoriesResponse;
using GetAllProductRequest = EShop.WebApp.Core.RequestModels.Catalog.GetAllProductRequest;
using GetListProductResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetListProductResponse;
using GetProductByIdResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetProductByIdResponse;
using PaginationRequest = EShop.WebApp.Core.RequestModels.Common.PaginationRequest;

namespace EShop.WebApp.Services.CatalogService;

public interface ICatalogService
{
    Task<Core.ResponseModels.Common.PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req);
    Task<ResultObject<GetProductByIdResponse>> GetProductById(int productId);
    Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number);
    Task<Core.ResponseModels.Common.PaginationResponse<GetAllBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest);
    Task<Core.ResponseModels.Common.PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationRequest);
}