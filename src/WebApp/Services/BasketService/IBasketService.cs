﻿using WebApp.Models.RequestModels.Basket;
using WebApp.Models.ResponseModels.Basket;
using WebApp.Models.ResponseModels.Common;

namespace WebApp.Services.BasketService;

public interface IBasketService
{
    Task<List<GetBasketByCustomerIdResponse>> GetBasketByCustomerId();
    Task<ResultObject<ResponseObject>> AddToBasket(AddToBasketRequest request);
    Task<ResultObject<ResponseObject>> UpdateQty(UpdateQtyRequest request);
    Task<ResultObject<ResponseObject>> DeleteBasketItem(int id);
}