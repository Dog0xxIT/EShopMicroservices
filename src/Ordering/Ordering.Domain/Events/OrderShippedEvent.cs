using MediatR;

namespace Ordering.Domain.Events
{
    public class OrderShippedEvent : INotification
    {
        public Aggregates.OrderAggregate.Order Order { get; }

        public OrderShippedEvent(Aggregates.OrderAggregate.Order order)
        {
            Order = order;
        }
    }
}
