using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.WebApp.Core;
using Microsoft.AspNetCore.Components;

namespace EShop.WebApp.Components.Product;

public partial class FilterModal
{
    [Parameter, EditorRequired] public bool Visible { get; set; }

    [Parameter] public EventCallback<bool> VisibleChanged { get; set; }

    private TabActive _tabActive;

    private List<IGrouping<char, GetListBrandsResponse>> _groupBrandByFirstChar;

    private async Task OnCloseModal()
    {
        Visible = false;
        await VisibleChanged.InvokeAsync(Visible);
    }

    protected override async Task OnInitializedAsync()
    {
        _groupBrandByFirstChar = new();
        await GetAllBrands();
    }

    private async Task GetAllBrands()
    {
        var req = new PaginationRequest
        {
            Page = 0,
            Limit = 40
        };
        var resultObject = await CatalogService.GetAllBrands(req);

        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _groupBrandByFirstChar = resultObject.Data.Data
                .GroupBy(
                    brand => brand.Name.ToUpper()[0],
                    brand => brand)
                .OrderBy(g => g.Key)
                .ToList();
            ;
        }
    }

    public enum TabActive
    {
        Brand,
        AdvancedFilters
    }
}