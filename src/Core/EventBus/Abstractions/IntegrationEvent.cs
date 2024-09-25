using System.Text.Json.Serialization;

namespace EventBus.Abstractions
{
    public class IntegrationEvent
    {
        public Guid Id { get; } = Guid.NewGuid();

        public DateTime CreationDate { get; } = DateTime.UtcNow;
    }
}
