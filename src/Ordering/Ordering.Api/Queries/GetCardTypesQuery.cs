using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ordering.Api.Models;
using Ordering.Infrastructure;

namespace Ordering.Api.Queries
{
    public record GetCartTypesQuery() : IRequest<List<GetCardTypesResponse>>;

    public class GetCartTypesQueryHandler : IRequestHandler<GetCartTypesQuery, List<GetCardTypesResponse>>
    {
        private readonly OrderContext _context;

        public GetCartTypesQueryHandler(OrderContext context)
        {
            _context = context;
        }

        public async Task<List<GetCardTypesResponse>> Handle(GetCartTypesQuery request, CancellationToken cancellationToken)
        {
            var cardTypes = await _context.CardTypes.AsNoTracking().ToListAsync(cancellationToken);
            return cardTypes.Adapt<List<GetCardTypesResponse>>();
        }
    }
}
