using EShop.WebApp.States;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor;
using Telerik.Blazor.Components;
using WebApp.Models.Common;

namespace WebApp.Pages;

public partial class Home
{
    [CascadingParameter(Name = "SearchText")]
    private string? _searchText { get; set; }
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }
    private bool _visibleLoader;
    private GetListProductRequest _getListProductRequest;
    private PaginationResponse<GetListProductResponse> _productPaginationResponse;
    private List<GetAllCategoriesResponse> _categoryList;
    private List<string> _sortOptions = ["Price Low to High", "Price High to Low", "Newest", "Best Seller"];
    private string SelectedSortOption;
    private double _minPrice = 0;
    private double _maxPrice = 300;

    protected override async Task OnInitializedAsync()
    {
        _getListProductRequest = new()
        {
            Page = 1,
            Limit = 36,
        };
        _productPaginationResponse = new();
        _categoryList = new();

        _visibleLoader = true;
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        _categoryList = await _catalogService.GetAllCategoriesHierarchy();
        _visibleLoader = false;
    }

    protected override async Task OnParametersSetAsync()
    {
        _getListProductRequest = new()
        {
            Keyword = _searchText,
            Page = 1,
            Limit = 36,
        };
        _visibleLoader = true;
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        _visibleLoader = false;
    }

    private async Task OnClickAddToCartButton(int productId)
    {
        var req = new AddToBasketRequest
        {
            ProductId = productId,
            Quantity = 1,
        };
        var resultObject = await _basketService.AddToBasket(req);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            return;
        }
        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
    }
    private async Task OnClickCategory(PanelBarItemClickEventArgs args)
    {
        var item = (GetAllCategoriesResponse)args.Item;
        _getListProductRequest.Categories = "";
        _getListProductRequest.Categories += item.Id;
        _visibleLoader = true;
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        _visibleLoader = false;
    }

    private async Task PageChangedHandler(int page)
    {
        if (page < 1)
        {
            return;
        }
        _getListProductRequest = new()
        {
            Page = page,
            Limit = 54,
        };
        _visibleLoader = true;
        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
        _visibleLoader = false;
    }

    private async Task GetProductsByCategoryId(int categoryId)

    {
        _getListProductRequest.Categories = "";

        _getListProductRequest.Categories += categoryId;


        _productPaginationResponse = await _catalogService.GetListProducts(_getListProductRequest);
    }

    private void OnSortOptionChange(string value)
    {
        SelectedSortOption = value;
    }
}