using EShop.Shared.RequestModels.Catalog;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Catalog;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Basket;

namespace EShop.WebApp.Services.BasketService;

public interface IBasketService
{
    Task<ResultObject<PaginationResponse<GetBasketByCustomerIdResponse>>> GetBasketByCustomerId(int customerId, PaginationRequest paginationRequest);
}