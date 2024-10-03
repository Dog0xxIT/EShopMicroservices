namespace Basket.Api.Services.BasketService;

public interface IBasketService
{
    Task<ServiceResult> CreateBasket(string userId);
    Task<List<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(string userId);
    Task<ServiceResult> AddToBasket(string userId,AddToBasketRequest req);
    Task<ServiceResult> UpdateQty(UpdateQtyRequest req);
    Task<ServiceResult> DeleteBasketItem(int id);
}