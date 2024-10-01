using Microsoft.AspNetCore.Components;
using WebApp.Models.RequestModels.Basket;
using WebApp.Models.ResponseModels;

namespace WebApp.Components.Product;

public partial class ProductCart
{
    [Parameter, EditorRequired] public GetListProductResponse ProductInfo { get; set; }

    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

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
}