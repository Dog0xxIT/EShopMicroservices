using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using GetAllCategoriesResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetAllCategoriesResponse;
using GetAllProductRequest = EShop.WebApp.Core.RequestModels.Catalog.GetAllProductRequest;
using GetListProductResponse = EShop.WebApp.Core.ResponseModels.Catalog.GetListProductResponse;
using PaginationRequest = EShop.WebApp.Core.RequestModels.Common.PaginationRequest;

namespace EShop.WebApp.Pages;

public partial class Home
{
    private GetAllProductRequest _getAllProductReq;
    private List<GetListProductResponse> _productList;
    private List<GetAllCategoriesResponse> _categoryList;

    protected override async Task OnInitializedAsync()
    {
        _getAllProductReq = new()
        {
            Limit = 20,
        };

        _productList = new();
        _categoryList = new();

        await GetAllProducts();
        await GetAllCategories();
    }

    private async Task GetProductsByCategoryId(int categoryId)
    {
        _getAllProductReq.Categories = $"{categoryId}";
        await GetAllProducts();
    }

    private async Task GetAllCategories()
    {
        var req = new PaginationRequest
        {
            Limit = 16
        };
        var response = await CatalogService.GetAllCategories(req);

        _categoryList = response.Data.ToList();
    }

    private async Task GetAllProducts()
    {
        var response = await CatalogService.GetAllProducts(_getAllProductReq);

        _productList = response.Data.ToList();
    }
}