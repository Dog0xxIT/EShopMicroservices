using System.Security.Claims;
using Basket.Api.Configurations;
using Basket.Api.Services.BasketService;
using Basket.Api.Services.CatalogService;

namespace Basket.Api.Controllers
{
    [Authorize(Roles = RolesConstant.Customer)]
    [ApiController]
    [Route("api/v1/baskets")]
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {

            _basketService = basketService;
        }

        [HttpPost("createBasket")]
        public async Task<IActionResult> CreateBasket()
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid) ?? "";
            var resultService = await _basketService.CreateBasket(userId);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }

            return Problem(resultService.Errors.First());
        }

        [HttpGet("getBasketByCustomerId")]
        public async Task<IActionResult> GetBasketByCustomerId()
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid) ?? "";
            var resultService = await _basketService.GetBasketByCustomerId(userId);
            return Ok(resultService);
        }

        [HttpPost("addToBasket")]
        public async Task<IActionResult> AddToBasket(AddToBasketRequest req)
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid) ?? "";
            var resultService = await _basketService.AddToBasket(userId, req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }

            return Problem(resultService.Errors.First());
        }

        [HttpPatch("updateQty")]
        public async Task<IActionResult> UpdateQty(UpdateQtyRequest req)
        {
            var resultService = await _basketService.UpdateQty(req);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }

            return Problem(resultService.Errors.First());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var resultService = await _basketService.DeleteBasketItem(id);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }

            return Problem(resultService.Errors.First());
        }
    }
}