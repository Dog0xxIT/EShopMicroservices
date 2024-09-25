using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using EventBus.Abstractions;

namespace EventStoreEF.Models
{
    public class EventLog
    {
        [Key]
        public Guid EventId { get; private set; }
        public string EventType { get; private set; }
        public string Content { get; private set; }
        public bool IsPublished { get; private set; }
        public Guid TransactionId { get; private set; }
        public DateTime CreationTime { get; private set; }
        public DateTime PublishedTime { get; private set; }

        private EventLog() { }

        public EventLog(IntegrationEvent integrationEvent, Guid transactionId)
        {
            EventId = integrationEvent.Id;
            CreationTime = integrationEvent.CreationDate;
            EventType = integrationEvent.GetType().FullName ?? string.Empty;
            Content = JsonSerializer.Serialize(integrationEvent);
            IsPublished = false;
            PublishedTime = DateTime.UnixEpoch;
            TransactionId = transactionId;
        }

        public void Published()
        {
            IsPublished = true;
            PublishedTime = DateTime.UtcNow;
        }
    }
}
