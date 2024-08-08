using EShop.Data.Entities;
using EShop.Data.UnitOfWork;
using EShop.Shared.RequestModels;
using EShop.Shared.RequestModels.Basket;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BasketController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BasketController> _logger;

        public BasketController(IUnitOfWork unitOfWork, ILogger<BasketController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #region Get method

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetBasketByCustomerId([FromQuery] int customerId, [FromQuery] PaginationRequest paginationReq)
        {
            var basketItems = await _unitOfWork.BasketItemRepository
                .Get
                (
                    filter: b => b.CustomerId == customerId,
                    orderBy: queryable => (IOrderedQueryable<BasketItem>)queryable
                        .OrderBy(p => p.Id)
                        .Skip(paginationReq.PageIndex)
                        .Take(paginationReq.PageSize)
                );

            var response = new PaginationResponse
            {
                PageIndex = paginationReq.PageIndex,
                PageSize = paginationReq.PageSize,
                Count = basketItems.Count(),
                Data = basketItems
            };
            return Ok(response);
        }

        #endregion

        #region Post method

        [HttpPatch]
        public async Task<IActionResult> UpdateQty(UpdateQtyRequest req)
        {
            var basketItem = await _unitOfWork.BasketItemRepository.GetById(req.BasketId);

            if (basketItem is null)
            {
                return BadRequest("Not found Basket");
            }

            if (req.Qty <= 0)
            {
                _unitOfWork.BasketItemRepository.Delete(basketItem);
            }

            var product = await _unitOfWork.ProductRepository.GetById(basketItem.ProductId);
            if (product is null)
            {
                return Problem();
            }

            if (req.Qty > product.AvailableStock)
            {
                return BadRequest("Qty order < AvailableStock");
            }

            basketItem.Quantity = req.Qty;
            _unitOfWork.BasketItemRepository.Update(basketItem);

            try
            {
                var result = await _unitOfWork.Commit();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        #endregion

        #region Delete method

        [HttpDelete]
        public async Task<IActionResult> Delete(int basketId)
        {
            var basketItem = await _unitOfWork.BasketItemRepository.GetById(basketId);

            if (basketItem is null)
            {
                return BadRequest("Not found Basket");
            }

            try
            {
                _unitOfWork.BasketItemRepository.Delete(basketItem);
                var result = await _unitOfWork.Commit();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        #endregion
    }
}
