using Basket.Api.Infrastructure;
using Basket.Api.Models.RequestModel;
using Basket.Api.Models.ResponseModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Basket.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("baskets")]
    public class BasketController : Controller
    {
        private readonly BasketContext _context;
        private readonly ILogger<BasketController> _logger;

        public BasketController(ILogger<BasketController> logger, BasketContext context)
        {
            _logger = logger;
            _context = context;
        }

        #region Get method

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetBasketByCustomerId(
            [FromRoute] int customerId,
            [FromQuery] PaginationRequest paginationReq)
        {
            var response = new PaginationResponse<GetBasketByCustomerIdResponse>();

            var basketOfCustomer = await _context.Baskets
                //.Include(b => b.User)
                .SingleOrDefaultAsync(b => b.UserId == customerId);

            if (basketOfCustomer is null)
            {
                return Ok(response);
            }

            var basketItems = await _context.BasketItems
                .OrderByDescending(b => b.Id)
                .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                .Take(paginationReq.Limit)
                //.Include(b => b.Product)
                .Where(b => b.BasketId == basketOfCustomer.Id)
                .AsNoTracking()
                .ToListAsync();

            var baskItemsDto = new List<GetBasketByCustomerIdResponse>();

            foreach (var basketItem in basketItems)
            {
                //var product = await _context.Products.FindAsync(basketItem.ProductId);

                baskItemsDto.Add(new GetBasketByCustomerIdResponse
                {
                    ProductId = basketItem.ProductId,
                    //CustomerId = basketOfCustomer.User?.Id ?? 0,
                    //CustomerName = basketOfCustomer.User?.UserName ?? "",
                    Id = basketItem.Id,
                    //ProductName = product?.Name ?? "",
                    //PictureUrl = product?.ImageUrl ?? "",
                    Quantity = basketItem.Quantity,
                    UnitPrice = basketItem.UnitPrice
                });
            }

            var totalBasketItems = await _context.BasketItems.CountAsync();
            var totalPages = paginationReq.Limit != 1 ? totalBasketItems / paginationReq.Limit + 1 : 0;

            response.Data = baskItemsDto;
            response.Meta.CurrentPage = paginationReq.Page;
            response.Meta.PerPage = paginationReq.Limit;
            response.Meta.Count = baskItemsDto.Count;
            response.Meta.Total = totalBasketItems;
            response.Meta.TotalPages = totalPages;

            return Ok(response);
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> AddToBasket(AddToBasketRequest req)
        {
            return Ok();

            /*
            var product = await _context.Products.FindAsync(req.ProductId);

            if (product is null)
            {
                return Problem("Not found product");
            }

            var newBasketItem = new BasketItem
            {
                ProductId = req.ProductId,
                Quantity = req.Quantity,
                UnitPrice = product.Price,
            };

            var baskets = await _context.Baskets
                .Where(b => b.UserId == req.CustomerId)
                .Include(b => b.Items)
                .AsNoTracking()
                .ToListAsync();

            if (!baskets.Any())
            {
                var newBasket = new Infrastructure.Entities.Basket
                {
                    UserId = req.CustomerId,
                    Items = new() { newBasketItem }
                };
                try
                {
                    //await _unitOfWork.BasketRepository.Create(newBasket);
                    //await _unitOfWork.Commit();
                    return Ok(ResponseObject.Succeeded);
                }
                catch (Exception ex)
                {
                    return Problem(ex.Message);
                }

            }
            else
            {
                var basketOfCustomer = baskets.First();
                var existsBasketItem = basketOfCustomer.Items.Any(i => i.ProductId == req.ProductId);
                if (existsBasketItem)
                {
                    return Problem("Product exists in basket");
                }

                basketOfCustomer.Items.Add(newBasketItem);
                try
                {
                    //_unitOfWork.BasketRepository.Update(basketOfCustomer);
                    //await _unitOfWork.Commit();
                    return Ok(ResponseObject.Succeeded);
                }
                catch (Exception ex)
                {
                    return Problem(ex.Message);
                }
            }
                  */
        }

        [HttpPatch("updateQty")]
        public async Task<IActionResult> UpdateQty(UpdateQtyRequest req)
        {
            //Note
            var basketEntity = await _context.BasketItems.FindAsync(req.BasketItemId);

            if (basketEntity is null)
            {
                return Problem("Not exists basket");
            }

            if (req.Qty == 0)
            {
                try
                {
                    //_unitOfWork.BasketItemRepository.Update(basketEntity);
                    //await _unitOfWork.Commit();
                    return Ok(ResponseObject.Succeeded);

                }
                catch (Exception ex)
                {
                    return Problem(ex.Message);
                }
            }
            else
            {
                basketEntity.Quantity = req.Qty;
                basketEntity.SetTimeLastModified();
                try
                {
                    //_unitOfWork.BasketItemRepository.Update(basketEntity);
                    //await _unitOfWork.Commit();
                    return Ok(ResponseObject.Succeeded);

                }
                catch (Exception ex)
                {
                    return Problem(ex.Message);
                }
            }
        }

        #endregion

        #region Delete method

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                //await _unitOfWork.BasketItemRepository.Delete(basketItemId);
                //await _unitOfWork.Commit();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        #endregion
    }
}
