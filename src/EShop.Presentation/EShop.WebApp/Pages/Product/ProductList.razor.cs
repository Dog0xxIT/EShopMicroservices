using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;

namespace EShop.WebApp.Pages.Product;

public partial class ProductList
{
    private GetAllProductRequest _getAllProductReq;
    private PaginationResponse<GetListProductResponse> _productPaginationRes;
    private List<GetAllCategoriesResponse> _categoryList;
    private List<GetAllBrandsResponse> _brandList;

    protected override async Task OnInitializedAsync()
    {
        _getAllProductReq = new()
        {
            Limit = 12
        };
        _productPaginationRes = new();
        _categoryList = new();
        _brandList = new();
        _productPaginationRes = await CatalogService.GetAllProducts(_getAllProductReq);
        await GetAllCategories();
        await GetAllBrands();
    }

    private async Task GetAllCategories()
    {
        var req = new PaginationRequest
        {
            Limit = 12
        };
        var response = await CatalogService.GetAllCategories(req);

        _categoryList = response.Data.ToList();
    }

    private async Task GetAllBrands()
    {
        var req = new PaginationRequest
        {
            Limit = 12
        };
        var response = await CatalogService.GetAllBrands(req);

        _brandList = response.Data.ToList();
    }

    private async Task OnChangedCurrentPage(int newPageIndex)
    {
        _getAllProductReq.Page = newPageIndex;
        _productPaginationRes = await CatalogService.GetAllProducts(_getAllProductReq);
        StateHasChanged();
    }
}