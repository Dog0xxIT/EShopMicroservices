using WebApp.Core;
using WebApp.Core.RequestModels;
using WebApp.Core.ResponseModels;

namespace WebApp.Pages.Order;

public partial class Cart
{
    private List<GetBasketByCustomerIdResponse> basketItemList;

    protected override async Task OnInitializedAsync()
    {
        basketItemList = new();
        await GetBasketByCustomerId();
    }

    private async Task GetBasketByCustomerId()
    {
        var resultObject = await BasketService.GetBasketByCustomerId(3, new PaginationRequest());
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            basketItemList = resultObject.Data.Data.ToList();
        }
    }
}