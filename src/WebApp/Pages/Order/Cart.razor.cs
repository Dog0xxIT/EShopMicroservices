namespace WebApp.Pages.Order;

public partial class Cart
{
    private List<GetBasketByCustomerIdResponse> _basketItemList;

    protected override async Task OnInitializedAsync()
    {
        _basketItemList = new();
        //await GetBasketByCustomerId();
        _basketItemList.Add(new());
        _basketItemList.Add(new());
        _basketItemList.Add(new());
        _basketItemList.Add(new());
    }

    private async Task GetBasketByCustomerId()
    {
        var resultObject = await BasketService.GetBasketByCustomerId(3, new PaginationRequest());
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _basketItemList = resultObject.Data.Data.ToList();
        }
    }
}