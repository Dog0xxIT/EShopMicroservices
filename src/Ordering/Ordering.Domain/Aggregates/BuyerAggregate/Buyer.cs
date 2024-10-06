using Ordering.Domain.Common;
using Ordering.Domain.Exceptions;

namespace Ordering.Domain.Aggregates.BuyerAggregate
{
    public class Buyer : BaseEntity, IAggregateRoot
    {
        public string BuyerName { get; private set; }

        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method OrderAggregateRoot.AddOrderItem() which includes behavior.
        private readonly List<PaymentMethod> _paymentMethods;

        public IReadOnlyCollection<PaymentMethod> PaymentMethods => _paymentMethods;

        private Buyer() { } 

        public Buyer(string id, string buyerName, List<PaymentMethod> paymentMethods) : base(id)
        {
            BuyerName = string.IsNullOrWhiteSpace(buyerName) ? throw new ArgumentNullException(nameof(buyerName)) : buyerName;
            _paymentMethods = paymentMethods ?? throw new ArgumentNullException(nameof(paymentMethods));
        }

        public PaymentMethod AddPaymentMethod(
            string id, string alias, string cardNumber,
            string securityNumber, string cardHolderName, DateTime expiration,
            string cardTypeId)
        {
            var existingPayment = VerifyPaymentMethod(cardTypeId, cardNumber, expiration);

            if (existingPayment)
            {
                throw DomainException.ExistingPayment;
            }
            var payment = new PaymentMethod(
                id, alias, securityNumber,
                securityNumber, cardHolderName, expiration,
                cardTypeId);
            _paymentMethods.Add(payment);
            return payment;
        }

        public bool VerifyPaymentMethod(string cardTypeId, string cardNumber, DateTime expiration)
        {
            var existingPayment = _paymentMethods
                .Any(p => p.IsEqualTo(cardTypeId, cardNumber, expiration));

            return existingPayment;
        }
    }
}
