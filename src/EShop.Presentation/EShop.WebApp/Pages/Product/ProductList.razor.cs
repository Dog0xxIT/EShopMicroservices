using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;

namespace EShop.WebApp.Pages.Product;

public partial class ProductList
{
    private PaginationRequest _paginationRequest;
    private PaginationResponse<GetListProductResponse> _productPaginationResponse;
    private List<GetAllCategoriesResponse> _categoryList;
    private bool _visibleFilterModal;
    private int _totalPage;
    private int _currentPage;

    protected override async Task OnInitializedAsync()
    {
        _paginationRequest = new()
        {
            Page = 0,
            Limit = 10
        };

        _productPaginationResponse = new()
        {
            Data = new List<GetListProductResponse>()
        };
        _categoryList = new();

        await GetTopCategories(16);
        await GetAllProduct();
    }

    private async Task GetAllProduct()
    {
        var resultObject = await CatalogService.GetAllProducts(_paginationRequest);

        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _productPaginationResponse = resultObject.Data;
            if (_productPaginationResponse.PageSize != 0)
            {
                _totalPage = _productPaginationResponse.Total / _productPaginationResponse.PageSize;
            }

            _currentPage = _productPaginationResponse.PageIndex + 1;
        }
    }

    private async Task GetTopCategories(int number)
    {
        var resultObject = await CatalogService.GetTopCategories(number);

        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _categoryList = resultObject.Data.ToList();
        }
    }

    private async Task GetProductsByCategoryId(int categoryId)
    {
        var req = new GetProductsByAdvanceFilterRequest
        {
            Page = _paginationRequest.Page,
            Limit = _paginationRequest.Limit,
            CategoryIdList = [categoryId],
            BrandIdList = []
        };

        var resultObject = await CatalogService.GetProductsByAdvanceFilter(req);

        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _productPaginationResponse = resultObject.Data;
        }
    }

    private async Task OnChangedCurrentPage(int newPageIndex)
    {
        _currentPage = newPageIndex;
        _paginationRequest.Page = _currentPage - 1;
        await GetAllProduct();
        StateHasChanged();
    }
}