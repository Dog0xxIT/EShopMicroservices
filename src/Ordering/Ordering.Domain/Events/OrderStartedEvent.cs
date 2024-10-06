using System;
using MediatR;

namespace Ordering.Domain.Events
{
    public class OrderStartedEvent : INotification
    {
        public Aggregates.OrderAggregate.Order Order { get; }
        public string UserId { get; }
        public string UserName { get; }
        public int CardTypeId { get; }
        public string CardNumber { get; }
        public string CardSecurityNumber { get; }
        public string CardHolderName { get; }
        public DateTime CardExpiration { get; }

        public OrderStartedEvent(
            Aggregates.OrderAggregate.Order order, string userId, string userName,
            int cardTypeId, string cardNumber, string cardSecurityNumber,
            string cardHolderName, DateTime cardExpiration)
        {
            Order = order;
            UserId = userId;
            UserName = userName;
            CardTypeId = cardTypeId;
            CardNumber = cardNumber;
            CardSecurityNumber = cardSecurityNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
        }
    }
}
