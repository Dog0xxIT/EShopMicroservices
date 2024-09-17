using EShop.Application.Entities;
using EShop.Application.Enums;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Order;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IUnitOfWork unitOfWork, ILogger<OrderController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #region Get method

        [HttpGet]
        public async Task<IActionResult> GetAllByBuyerId([FromQuery] int buyerId)
        {
            var orders = await _unitOfWork.OrderRepository
                .Get(
                    filter: o => o.BuyerId == buyerId,
                    includeProperties: new List<string> { nameof(Order.OrderItems) });

            return Ok(orders);
        }

        [HttpGet("/cartTypes")]
        public async Task<IActionResult> CartTypes(int id)
        {
            return null;
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequest req)
        {
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("draft")]
        public async Task<IActionResult> CreateDraft(CreateDraftRequest req)
        {
            //var orderDraft = new Order(req.BuyerId);
            return Ok(ResponseObject.Succeeded);
        }

        #endregion

        #region Patch method

        [HttpPatch("cancel/{id}")]
        public async Task<IActionResult> Cancel([FromRoute] int id)
        {
            var order = await _unitOfWork.OrderRepository.GetById(id);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Cancelled;

            try
            {
                _unitOfWork.OrderRepository.Update(order);
                var result = await _unitOfWork.Commit();
                return Ok(ResponseObject.Succeeded);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPatch("ship/{id}")]
        public async Task<IActionResult> Ship([FromRoute] int id)
        {
            var order = await _unitOfWork.OrderRepository.GetById(id);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Shipped;

            try
            {
                _unitOfWork.OrderRepository.Update(order);
                var result = await _unitOfWork.Commit();
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
