namespace EShop.Domain.Aggregates.BuyerAggregate
{
    public class PaymentMethod
    {
        public int Id { get; private set; }
        public string Alias { get; private set; }
        public string CardNumber { get; private set; }
        public string SecurityNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public DateTime Expiration { get; private set; }
        public int CardTypeId { get; private set; }
        public CardType CardType { get; private set; }

        public PaymentMethod(int id, string alias, string cardNumber,
            string securityNumber, string cardHolderName, DateTime expiration,
            int cardTypeId)
        {
            if (Expiration < DateTime.UtcNow)
            {
                throw DomainException.CardExpiry;
            }
            Id = id;
            Alias = alias ?? throw new ArgumentNullException(nameof(alias));
            CardNumber = cardNumber ?? throw new ArgumentNullException(nameof(cardNumber));
            SecurityNumber = securityNumber ?? throw new ArgumentNullException(nameof(securityNumber));
            CardHolderName = cardHolderName ?? throw new ArgumentNullException(nameof(cardHolderName));
            Expiration = expiration;
            CardTypeId = cardTypeId;
        }

        public bool IsEqualTo(int cardTypeId, string cardNumber, DateTime expiration)
        {
            return CardTypeId == cardTypeId
                   && CardNumber == cardNumber
                   && Expiration == expiration;
        }
    }
}
