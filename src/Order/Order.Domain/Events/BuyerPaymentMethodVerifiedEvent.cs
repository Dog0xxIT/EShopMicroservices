using MediatR;
using Ordering.Domain.Aggregates.BuyerAggregate;

namespace Ordering.Domain.Events
{
    public class BuyerPaymentMethodVerifiedEvent : INotification
    {
        public Buyer Buyer { get; private set; }
        public PaymentMethod Payment { get; private set; }
        public int OrderId { get; private set; }

        public BuyerPaymentMethodVerifiedEvent(Buyer buyer, PaymentMethod payment, int orderId)
        {
            Buyer = buyer;
            Payment = payment;
            OrderId = orderId;
        }
    }
}
