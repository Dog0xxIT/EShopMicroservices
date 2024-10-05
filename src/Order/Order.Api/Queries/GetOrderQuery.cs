using MediatR;
using Microsoft.EntityFrameworkCore;
using Ordering.Api.Models;
using Ordering.Infrastructure;

namespace Ordering.Api.Queries
{
    public record GetOrderQuery(string Id) : IRequest<GetOrderResponse>;

    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderResponse>
    {
        private readonly OrderContext _context;

        public GetOrderQueryHandler(OrderContext context)
        {
            _context = context;
        }

        public async Task<GetOrderResponse> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .AsNoTracking()
                .Select(order => new GetOrderResponse
                {
                    OrderId = order.Id,
                    Date = order.OrderDate,
                    Status = order.OrderStatus,
                    Description = order.Description,
                    Total = order.OrderItems.Sum(oi => oi.TotalPrice),
                    Street = order.Address.Street,
                    City = order.Address.City,
                    State = order.Address.State,
                    ZipCode = order.Address.ZipCode,
                    Country = order.Address.Country,
                    OrderItems = order.OrderItems.Select(oi => new GetOrderResponse.OrderItem
                    {
                        PictureUrl = oi.PictureUrl,
                        ProductName = oi.ProductName,
                        UnitPrice = oi.UnitPrice,
                        ProductId = oi.ProductName,
                        Units = oi.Units,
                    }).ToList()
                })
                .SingleOrDefaultAsync(o => o.OrderId == request.Id, cancellationToken);

            return order ?? new();
        }
    }
}
