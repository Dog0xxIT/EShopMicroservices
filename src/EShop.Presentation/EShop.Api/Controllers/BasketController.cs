using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.RequestModels.Common;
using EShop.Shared.ResponseModels.Basket;
using EShop.Shared.ResponseModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly ILogger<BasketController> _logger;

        public BasketController(ILogger<BasketController> logger, IBasketService basketService)
        {
            _logger = logger;
            _basketService = basketService;
        }

        #region Get method

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetBasketByCustomerId(
            [FromRoute] int customerId, 
            [FromQuery] PaginationRequest paginationReq)
        {
            var response = await _basketService.GetBasketByCustomerId(customerId, paginationReq);

            return Ok(response);
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> AddToBasket(AddToBasketRequest req)
        {
            var serviceResult = await _basketService.AddToBasket(req);
            if (serviceResult.Succeeded)
            {
                return Ok(TypedResult.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateQty(UpdateQtyRequest req)
        {
            var serviceResult = await _basketService.UpdateQty(req.BasketId, req.Qty);
            if (serviceResult.Succeeded)
            {
                return Ok(TypedResult.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        #endregion

        #region Delete method

        [HttpDelete]
        public async Task<IActionResult> Delete(int basketId)
        {
            var serviceResult = await _basketService.Delete(basketId);
            if (serviceResult.Succeeded)
            {
                return Ok(TypedResult.Succeeded);
            }
            return Problem(serviceResult.Errors.First());
        }

        #endregion
    }
}
