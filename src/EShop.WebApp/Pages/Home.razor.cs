using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Pages;

public partial class Home
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
            Limit = 12,
        };
        _productPaginationResponse = new();
        _categoryList = new();

        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        _categoryList = await _catalogService.GetAllCategoriesHierarchy();
        _categoryList = _categoryList.First().Childs;
    }

    private async Task GetProductsByCategoryId(int categoryId)

    {
        _getListProductRequest.Categories = "";

        _getListProductRequest.Categories += categoryId;


        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
    }

    private async Task OnChangedCurrentPage(int newPageIndex)

    {
        _currentPage = newPageIndex;

        _getListProductRequest.Page = _currentPage - 1;

        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);

        StateHasChanged();
    }
}