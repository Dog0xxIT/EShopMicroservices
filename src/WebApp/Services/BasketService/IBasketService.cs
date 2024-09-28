namespace WebApp.Services.BasketService;

public interface IBasketService
{
    Task<ResultObject<PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest);
}