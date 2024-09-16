using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;

namespace EShop.WebApp.Pages.Product;

public partial class ProductList
{
    private GetAllProductRequest _getAllProductRequest;
    private PaginationResponse<GetListProductResponse> _productPaginationResponse;
    private List<GetAllCategoriesResponse> _categoryList;
    private bool _visibleFilterModal;
    private int _totalPage;
    private int _currentPage;

    protected override async Task OnInitializedAsync()
    {
        _getAllProductRequest = new()
        {
            Page = 0,
            Limit = 33
        };

        _productPaginationResponse = new()
        {
            Data = new List<GetListProductResponse>()
        };
        _categoryList = new();

        await GetTopCategories(16);
        _productPaginationResponse = await CatalogService.GetAllProducts(_getAllProductRequest);
    }

    private async Task GetTopCategories(int number)
    {
        var response = await CatalogService.GetTopCategories(number);
        _categoryList = response.ToList();
    }

    private async Task GetProductsByCategoryId(int categoryId)
    {
        _getAllProductRequest.Category = categoryId;
    }

    private async Task OnChangedCurrentPage(int newPageIndex)
    {
        _currentPage = newPageIndex;
        _getAllProductRequest.Page = _currentPage - 1;
        _productPaginationResponse = await CatalogService.GetAllProducts(_getAllProductRequest);
        StateHasChanged();
    }
}