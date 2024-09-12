namespace EShop.Domain.Aggregates.BuyerAggregate
{
    public class Buyer : IAggregateRoot
    {
        public int BuyerId { get; private set; }

        public string BuyerName { get; private set; }

        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method OrderAggregateRoot.AddOrderItem() which includes behavior.
        private readonly List<PaymentMethod> _paymentMethods;

        public IEnumerable<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();

        public Buyer(int buyerId, string buyerName, List<PaymentMethod> paymentMethods)
        {
            BuyerId = buyerId;
            BuyerName = buyerName ?? throw new ArgumentNullException(nameof(buyerName));
            _paymentMethods = paymentMethods;
        }

        public PaymentMethod AddPaymentMethod(
            string alias, string cardNumber, string securityNumber,
            string cardHolderName, DateTime expiration, int cardTypeId,
            int id)
        {
            var existingPayment = _paymentMethods
                .SingleOrDefault(p => p.IsEqualTo(cardTypeId, cardNumber, expiration));

            if (existingPayment != null)
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

        public bool VerifyPaymentMethod(int cardTypeId, string cardNumber, DateTime expiration)
        {
            var existingPayment = _paymentMethods
                .SingleOrDefault(p => p.IsEqualTo(cardTypeId, cardNumber, expiration));

            return existingPayment != null;
        }
    }
}
