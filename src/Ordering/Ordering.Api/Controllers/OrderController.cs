using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ordering.Api.Commands;
using Ordering.Api.Models;
using Ordering.Api.Queries;

namespace Ordering.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/orders")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IMediator _mediator;

        public OrderController(ILogger<OrderController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("user/{buyerId}")]
        public async Task<IActionResult> GetOrderByBuyerId([FromRoute] string buyerId)
        {
            var query = new GetOrderByUserIdQuery(buyerId);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById([FromRoute] string id)
        {
            var query = new GetOrderQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("/cartTypes")]
        public async Task<IActionResult> CartTypes()
        {
            var query = new GetCartTypesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDraftCommand req)
        {
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("draft")]
        public async Task<IActionResult> CreateDraft(CreateOrderDraftCommand req)
        {
            //var orderDraft = new Order(req.BuyerId);
            return Ok(ResponseObject.Succeeded);
        }


        [HttpPatch("cancel/{id}")]
        public async Task<IActionResult> Cancel([FromRoute] int id)
        {
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPatch("ship/{id}")]
        public async Task<IActionResult> Ship([FromRoute] int id)
        {
            return Ok(ResponseObject.Succeeded);
        }
    }
}
