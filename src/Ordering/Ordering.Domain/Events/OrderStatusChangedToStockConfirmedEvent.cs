using MediatR;

namespace Ordering.Domain.Events
{
    public class OrderStatusChangedToStockConfirmedEvent : INotification
    {
        public string OrderId { get; }

        public OrderStatusChangedToStockConfirmedEvent(string orderId)
        {
            OrderId = orderId;
        }
    }
}
