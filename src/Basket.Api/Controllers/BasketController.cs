using System.Security.Claims;
using Basket.Api.Configurations;
using Basket.Api.Services.CatalogService;

namespace Basket.Api.Controllers
{
    [Authorize(Roles = RolesConstant.Customer)]
    [ApiController]
    [Route("api/v1/baskets")]
    public class BasketController : Controller
    {
        private readonly BasketContext _context;
        private readonly ILogger<BasketController> _logger;
        private readonly ICatalogService _catalogService;

        public BasketController(ILogger<BasketController> logger, BasketContext context, ICatalogService catalogService)
        {
            _logger = logger;
            _context = context;
            _catalogService = catalogService;
        }



        [HttpPost("createBasket")]
        public async Task<IActionResult> CreateBasket()
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid);
            var isExist = await _context.Baskets.AsNoTracking().AnyAsync(b => b.UserId == userId);
            if (isExist)
            {
                return BadRequest();
            }

            var basket = new Data.Entities.Basket
            {
                UserId = userId,
            };
            try
            {
                await _context.Baskets.AddAsync(basket);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("getBasketByCustomerId")]
        public async Task<IActionResult> GetBasketByCustomerId(
            [FromQuery] PaginationRequest paginationReq)
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid);
            var basket = await _context.Baskets
                .Include(b => b.Items)
                .SingleOrDefaultAsync(b => b.UserId == userId);

            if (basket is null)
            {
                return BadRequest("Not exists basket");
            }

            var basketItems = await _context.BasketItems
                .Where(b => b.BasketId == basket.Id)
                .OrderByDescending(b => b.Id)
                .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                .Take(paginationReq.Limit)
                .AsNoTracking()
                .ToListAsync();

            var baskItemsDto = basketItems.Select(basketItem =>
                new GetBasketByCustomerIdResponse
                {
                    ProductId = basketItem.ProductId,
                    CustomerId = basket.UserId,
                    Id = basketItem.Id,
                    ProductName = basketItem.ProductName,
                    PictureUrl = basketItem.PictureUrl,
                    Quantity = basketItem.Quantity,
                    UnitPrice = basketItem.UnitPrice
                }).ToList();

            return Ok(baskItemsDto);
        }

        [HttpPost("addToBasket")]
        public async Task<IActionResult> AddToBasket(AddToBasketRequest req)
        {
            var product = await _catalogService.GetProductById("CatalogClient", req.ProductId);
            if (product is null)
            {
                return BadRequest("Not exists product");
            }

            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.Sid);
            var basket = await _context.Baskets
                    .Include(b => b.Items)
                    .SingleOrDefaultAsync(b => b.UserId == userId);

            if (basket is null)
            {
                return BadRequest("Not exists basket");
            }

            try
            {
                var basketItem = basket.Items.SingleOrDefault(i => i.ProductId == req.ProductId);
                if (basketItem is null)
                {
                    var newBasketItem = new BasketItem
                    {
                        ProductId = req.ProductId,
                        Quantity = req.Quantity,
                        ProductName = product.Name,
                        UnitPrice = product.Price,
                        PictureUrl = product.ThumbnailUrl,
                    };
                    basket.Items.Add(newBasketItem);
                    basket.SetTimeLastModified();
                    _context.Baskets.Update(basket);
                }
                else
                {
                    basketItem.Quantity = req.Quantity;
                    basketItem.SetTimeLastModified();
                    _context.BasketItems.Update(basketItem);
                }
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPatch("updateQty")]
        public async Task<IActionResult> UpdateQty(UpdateQtyRequest req)
        {
            //Note
            var basketItem = await _context.BasketItems.FindAsync(req.BasketItemId);

            if (basketItem is null)
            {
                return Problem("Not exists basket item");
            }

            try
            {
                if (req.Qty == 0)
                {
                    _context.BasketItems.Remove(basketItem);
                }
                else
                {
                    basketItem.Quantity = req.Qty;
                    basketItem.SetTimeLastModified();
                }
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var basketItem = await _context.BasketItems.FindAsync(id);

            if (basketItem is null)
            {
                return Problem("Not exists basket item");
            }

            try
            {
                _context.BasketItems.Remove(basketItem);
                await _context.SaveChangesAsync();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
