using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Common;
using Ordering.Infrastructure.Repositories;

namespace Ordering.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly IMediator _mediator;
    private readonly OrderContext _context;
    private readonly ILogger<UnitOfWork> _logger;
    public IBuyerRepository BuyerRepository { get; }
    public IOrderRepository OrderRepository { get; }

    public UnitOfWork(OrderContext context, IMediator mediator, ILogger<UnitOfWork> logger)
    {
        _mediator = mediator;
        _logger = logger;
        _context = context;
        BuyerRepository = new BuyerRepository(context);
        OrderRepository = new OrderRepository(context);
    }

    public async Task<int> Commit(CancellationToken cancellationToken)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _logger.LogInformation($"Begin transaction: ");
            await MediatorDispatchDomainEventsAsync();
            var result = await _context.SaveChangesAsync(cancellationToken);
            transaction.Commit();
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Transaction: {ex.Message}");
            transaction.Rollback();
        }

        return -1;
    }

    public async Task MediatorDispatchDomainEventsAsync()
    {
        var domainEntities = _context.ChangeTracker
            .Entries<BaseEntity>()
            .Where(x => x.Entity.DomainEvents.Any())
            .ToList();

        var domainEvents = domainEntities
            .SelectMany(x => x.Entity.DomainEvents)
            .ToList();

        domainEntities.ToList()
            .ForEach(entity => entity.Entity.ClearDomainEvents());

        foreach (var domainEvent in domainEvents)
            await _mediator.Publish(domainEvent);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}