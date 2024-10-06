using MediatR;

namespace Ordering.Domain.Events
{
    public class OrderCancelledEvent : INotification
    { 
        public Aggregates.OrderAggregate.Order Order { get; }

        public OrderCancelledEvent(Aggregates.OrderAggregate.Order order)
        {
            Order = order;
        }
    }
}
