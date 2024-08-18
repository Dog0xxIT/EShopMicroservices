using EShop.Data.Entities;
using EShop.Data.Enums;
using EShop.Data.UnitOfWork;
using EShop.Shared.RequestModels.Order;
using EShop.Shared.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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

        [HttpGet("{buyerId}")]
        public async Task<IActionResult> GetAllByBuyerId(int buyerId)
        {
            var orders = await _unitOfWork.OrderRepository
                .Get(
                    filter: o => o.BuyerId == buyerId,
                    includeProperties: new List<string> { nameof(Order.OrderItems) });

            return Ok(orders);
        }

        [HttpGet]
        public async Task<IActionResult> CartTypes(int id)
        {
            return null;
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequest req)
        {
            return Ok(new SuccessObjectResponse());
        }

        [HttpPost]
        public async Task<IActionResult> CreateDraft(CreateDraftRequest req)
        {
            var orderDraft = new Order(req.BuyerId);
            return Ok(new SuccessObjectResponse());
        }

        #endregion

        #region Patch method

        [HttpPatch]
        public async Task<IActionResult> Cancel(int orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetById(orderId);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Cancelled;

            try
            {
                _unitOfWork.OrderRepository.Update(order);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPatch]
        public async Task<IActionResult> Ship(int orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetById(orderId);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Shipped;

            try
            {
                _unitOfWork.OrderRepository.Update(order);
                var result = await _unitOfWork.Commit();
                return Ok(new SuccessObjectResponse());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        #endregion
    }
}
