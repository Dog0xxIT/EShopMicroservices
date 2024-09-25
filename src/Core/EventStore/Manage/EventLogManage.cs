using EventBus.Abstractions;
using EventStoreEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStoreEF.Manage
{
    public class EventLogManage<TContext> : IEvenLogManage where TContext : DbContext
    {
        private readonly EventStoreDbContext<TContext> _context;

        public EventLogManage(EventStoreDbContext<TContext> context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EventLog>> GetAllEventNotPublished(Guid transactionId)
        {
            var result = await _context.EventLogs
                .OrderBy(e => e.CreationTime)
                .Where(e => e.TransactionId == transactionId && !e.IsPublished)
                .AsNoTracking()
                .ToListAsync();
            return result;
        }

        public async Task AddEventLog(IntegrationEvent integrationEvent, Guid transactionId)
        {
            var eventLog = new EventLog(integrationEvent, transactionId);

            _context.EventLogs.Add(eventLog);
        }

        public async Task MarkEventAsPublishedAsync(Guid eventId)
        {
            var eventLog = await _context.EventLogs.SingleOrDefaultAsync(e => e.EventId == eventId);
            eventLog?.Published();
        }
    }
}
