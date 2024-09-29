using Microsoft.AspNetCore.Components;
using Telerik.SvgIcons;
using WebApp.Models.Common;

namespace WebApp.Pages.Product;

public partial class Detail
{
    [Parameter]
    public int ProductId { get; set; }

    private GetProductByIdResponse _productInfo;
    private List<BreadcrumbItem> _breadcrumbItems;

    protected override async Task OnInitializedAsync()
    {
        
        _productInfo = new()
        {
            Brand = new(),
            Category = new(),
        };

        var resultObject = await CatalogService.GetProductById(ProductId);

        _productInfo = resultObject.Data;

        _breadcrumbItems = new List<BreadcrumbItem>
        {
            new () { Text = "Home", Icon = SvgIcon.Home },
            new ()  { Text = "Products"},
            new ()  { Text = @_productInfo.Name},
        };
    }
}
