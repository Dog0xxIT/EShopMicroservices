using MediatR;
using Microsoft.EntityFrameworkCore;
using Ordering.Api.Models;
using Ordering.Domain.Enums;
using Ordering.Infrastructure;

namespace Ordering.Api.Queries
{
    public record GetOrderByUserIdQuery(string BuyerId) : IRequest<List<GetOrdersByUserIdResponse>>;

    public class GetOrderByUserIdQueryHandler : IRequestHandler<GetOrderByUserIdQuery, List<GetOrdersByUserIdResponse>>
    {
        private readonly OrderContext _context;

        public GetOrderByUserIdQueryHandler(OrderContext context)
        {
            _context = context;
        }

        public async Task<List<GetOrdersByUserIdResponse>> Handle(GetOrderByUserIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _context.Orders
                .Include(o => o.OrderItems)
                .AsNoTracking()
                .Where(o => o.BuyerId == request.BuyerId)
                .Select(order => new GetOrdersByUserIdResponse
                {
                    OrderId = order.Id,
                    Date = order.OrderDate,
                    Status = order.OrderStatus,
                    Total = order.OrderItems.Sum(oi => oi.TotalPrice)
                })
                .ToListAsync(cancellationToken);
            return response;
        }
    }
}
