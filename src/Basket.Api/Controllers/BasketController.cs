using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using Basket.Api.Services.CatalogService;

namespace Basket.Api.Controllers
{
    [Authorize]
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

        [HttpPost]
        public async Task<IActionResult> GetBasketByCustomerId(
            [FromQuery] PaginationRequest paginationReq)
        {
            var basketOfCustomer = await _context.Baskets
                .Include(b => b.Items)
                .SingleOrDefaultAsync(b => b.UserId == 1);

            if (basketOfCustomer is null)
            {
                return Problem("Not exists basket");
            }

            var basketItems = await _context.BasketItems
                .Where(b => b.BasketId == basketOfCustomer.Id)
                .OrderByDescending(b => b.Id)
                .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                .Take(paginationReq.Limit)
                .AsNoTracking()
                .ToListAsync();

            var baskItemsDto = basketItems.Select(b =>
                new GetBasketByCustomerIdResponse
                {
                    ProductId = b.ProductId,
                    CustomerId = basketOfCustomer.UserId,
                    Id = b.Id,
                    ProductName = b.ProductName,
                    PictureUrl = b.PictureUrl,
                    Quantity = b.Quantity,
                    UnitPrice = b.UnitPrice
                }).ToList();

            var totalBasketItems = await _context.BasketItems.CountAsync();
            var totalPages = paginationReq.Limit != 0 ? (totalBasketItems / paginationReq.Limit) + 1 : 0;
            var response = new PaginationResponse<GetBasketByCustomerIdResponse>
            {
                Data = baskItemsDto,
                Meta = new()
                {
                    Count = baskItemsDto.Count,
                    Total = totalBasketItems,
                    PerPage = paginationReq.Page,
                    CurrentPage = paginationReq.Page,
                    TotalPages = totalPages,
                    Current = "",
                    Next = "",
                    Previous = "",
                }
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddToBasket(AddToBasketRequest req)
        {
            // Call catalog get info product
            var product = await _catalogService.GetBaseInfoProduct("Catalog", req.ProductId);
            if (product is null)
            {
                return BadRequest("Not exists product");
            }


            var newBasketItem = new BasketItem
            {
                ProductId = req.ProductId,
                Quantity = req.Quantity,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                PictureUrl = product.PictureUrl,
            };

            var basket = await _context.Baskets
                    .Include(b => b.Items)
                    .AsNoTracking()
                    .SingleOrDefaultAsync(b => b.UserId == req.CustomerId);

            try
            {
                if (basket is null)
                {
                    var newBasket = new Data.Entities.Basket
                    {
                        UserId = req.CustomerId,
                        Items = new() { newBasketItem }
                    };
                }
                else
                {
                    var existsBasketItem = basket.Items.Any(i => i.ProductId == req.ProductId);
                    if (existsBasketItem)
                    {
                        return Problem("Product exists in basket");
                    }
                    basket.Items.Add(newBasketItem);
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

        private JwtSecurityToken DecodeToken(string accessToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(accessToken);
            return jwtSecurityToken;
        }
    }
}
