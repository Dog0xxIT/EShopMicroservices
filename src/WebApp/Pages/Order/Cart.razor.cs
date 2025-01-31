﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using WebApp.Models.RequestModels.Basket;
using WebApp.Models.ResponseModels.Basket;

namespace WebApp.Pages.Order;

public partial class Cart
{
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

    private List<GetBasketByCustomerIdResponse> _basketItemList;
    private bool _visibleLoader;

    protected override async Task OnInitializedAsync()
    {
        _visibleLoader = true;
        _basketItemList = new();
        _basketItemList = await _basketService.GetBasketByCustomerId();
        _visibleLoader = false;
    }

    private async Task UpdateQty(int basketItemId, int qty)
    {
        var req = new UpdateQtyRequest
        {
            Qty = qty,
            BasketItemId = basketItemId,
        };
        _visibleLoader = true;
        var resultObject = await _basketService.UpdateQty(req);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _basketItemList = await _basketService.GetBasketByCustomerId();
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            _visibleLoader = false;
            return;
        }
        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
        _visibleLoader = false;
    }

    private async Task DeleteBasketItem(int basketItemId)
    {
        _visibleLoader = true;
        var resultObject = await _basketService.DeleteBasketItem(basketItemId);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _basketItemList = await _basketService.GetBasketByCustomerId();
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            _visibleLoader = false;
            return;
        }
        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
        _visibleLoader = false;
    }

}