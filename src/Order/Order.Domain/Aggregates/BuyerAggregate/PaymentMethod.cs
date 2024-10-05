using System;
using Ordering.Domain.Common;
using Ordering.Domain.Enums;
using Ordering.Domain.Exceptions;

namespace Ordering.Domain.Aggregates.BuyerAggregate
{
    public class PaymentMethod : BaseEntity
    {
        private readonly string _alias;
        private readonly string _cardNumber;
        private readonly string _securityNumber;
        private readonly string _cardHolderName;
        private readonly DateTime _expiration;
        private readonly string _cardTypeId;
        public CardType CardType { get; private set; }

        private PaymentMethod() { }

        public PaymentMethod(string id, string alias, string cardNumber,
            string securityNumber, string cardHolderName, DateTime expiration,
            string cardTypeId) : base(id)
        {
            _alias = string.IsNullOrWhiteSpace(alias) ? throw new ArgumentNullException(nameof(alias)) : alias;
            _cardNumber = string.IsNullOrWhiteSpace(cardNumber) ? throw new ArgumentNullException(nameof(cardNumber)) : cardNumber;
            _securityNumber = string.IsNullOrWhiteSpace(securityNumber) ? throw new ArgumentNullException(nameof(securityNumber)) : securityNumber;
            _cardHolderName = string.IsNullOrWhiteSpace(cardHolderName) ? throw new ArgumentNullException(nameof(cardHolderName)) : cardHolderName;
            if (_expiration < DateTime.UtcNow)
            {
                throw DomainException.CardExpiry;
            }
            _expiration = expiration;
            _cardTypeId = string.IsNullOrWhiteSpace(cardTypeId) ? throw new ArgumentNullException(nameof(cardTypeId)) : cardTypeId;
        }

        public bool IsEqualTo(string cardTypeId, string cardNumber, DateTime expiration)
        {
            return _cardTypeId == cardTypeId
                   && _cardNumber == cardNumber
                   && _expiration == expiration;
        }
    }
}
