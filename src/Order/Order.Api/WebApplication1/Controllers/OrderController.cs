using Microsoft.AspNetCore.Mvc;
using Order.Api.Models.RequestModels;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IDbContext _context;

        public OrderController(ILogger<OrderController> logger, IDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        #region Get method

        [HttpGet]
        public async Task<IActionResult> GetAllByBuyerId([FromQuery] int buyerId)
        {
            var orders = await _context.Orders
                .Where(o => o.BuyerId == buyerId)
                .Include(o => o.OrderItems)
                .AsNoTracking()
                .ToListAsync();

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
            var order = await _context.Orders.FindAsync(id);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Cancelled;

            try
            {
                //_unitOfWork.OrderRepository.Update(order);
                //var result = await _unitOfWork.Commit();
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
            var order = await _context.Orders.FindAsync(id);
            if (order is null)
            {
                return NotFound();
            }

            order.OrderStatus = OrderStatus.Shipped;

            try
            {
                //_unitOfWork.OrderRepository.Update(order);
                //var result = await _unitOfWork.Commit();
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
