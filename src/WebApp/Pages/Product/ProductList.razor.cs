using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Pages.Product;

public partial class ProductList
{
    private GetListProductRequest _getListProductRequest;
    private PaginationResponse<GetListProductResponse> _productPaginationResponse;
    private List<GetAllCategoriesResponse> _categoryList;
    private bool _visibleFilterModal;
    private int _totalPage;
    private int _currentPage;

    protected override async Task OnInitializedAsync()
    {
        _getListProductRequest = new()
        {
            Page = 1,
            Limit = 33
        };

        _productPaginationResponse = new()
        {
            Data = new List<GetListProductResponse>()
        };
        _categoryList = new();

        _categoryList = await _catalogService.GetAllCategoriesHierarchy();
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
    }

    private async Task GetProductsByCategoryId(int categoryId)
    {
        _getListProductRequest.Categories = "";
        _getListProductRequest.Categories += categoryId;
    }

    private async Task OnChangedCurrentPage(int newPageIndex)
    {
        _currentPage = newPageIndex;
        _getListProductRequest.Page = _currentPage - 1;
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        StateHasChanged();
    }
}