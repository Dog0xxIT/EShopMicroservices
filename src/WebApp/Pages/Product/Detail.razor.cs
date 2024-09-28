using Microsoft.AspNetCore.Components;

namespace WebApp.Pages.Product;

public partial class Detail
{
    [Parameter] public int ProductId { get; set; }

    private GetProductByIdResponse _productInfo;

    protected override async Task OnInitializedAsync()

    {
        _productInfo = new()
        {
            Brand = new(),
            Category = new(),
        };

        var resultObject = await CatalogService.GetProductById(ProductId);

        _productInfo = resultObject.Data;
    }
}