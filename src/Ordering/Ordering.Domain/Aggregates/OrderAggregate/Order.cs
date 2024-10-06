using System;
using System.Collections.Generic;
using System.Linq;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Common;
using Ordering.Domain.Enums;
using Ordering.Domain.Events;
using Ordering.Domain.Exceptions;

namespace Ordering.Domain.Aggregates.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public string BuyerId { get; private set; }

        public string PaymentId { get; private set; }

        public DateTime OrderDate { get; private set; }

        public OrderStatus OrderStatus { get; private set; }

        public string Description { get; private set; }

        public Buyer Buyer { get; }

        public Address Address { get; private set; }

        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method OrderAggregateRoot.AddOrderItem() which includes behavior.
        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        private Order() { } 

        public Order(
            string id, DateTime orderDate, string buyerId,
            string paymentId, Address address, OrderStatus orderStatus,
            List<OrderItem> orderItems) : base(id)
        {
            _orderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
            OrderDate = orderDate;
            BuyerId = string.IsNullOrWhiteSpace(buyerId) ? throw new ArgumentNullException(nameof(buyerId)) : buyerId;
            PaymentId = string.IsNullOrWhiteSpace(paymentId) ? throw new ArgumentNullException(nameof(paymentId)) : paymentId;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            OrderStatus = orderStatus;
        }

        public void AddOrderItem(
            int productId, string productName, double unitPrice,
            double discount, string pictureUrl, int units = 1)
        {
            var existingOrderForProduct = _orderItems.SingleOrDefault(o => o.ProductId == productId);

            if (existingOrderForProduct != null)
            {
                //if previous line exist modify it with higher discount and units.
                if (discount > existingOrderForProduct.Discount)
                {
                    existingOrderForProduct.SetNewDiscount(discount);
                }

                existingOrderForProduct.AddUnits(units);
            }
            else
            {
                //add validated new order item
                var orderItem = new OrderItem(Guid.NewGuid().ToString(), productId, productName, pictureUrl,
                    unitPrice, discount, units);
                _orderItems.Add(orderItem);
            }
        }

        public void SetAwaitingValidationStatus()
        {
            if (OrderStatus == OrderStatus.Submitted)
            {
                this._domainEvents.Add(new OrderStatusChangedToAwaitingValidationEvent(Id, _orderItems));
                OrderStatus = OrderStatus.AwaitingValidation;
            }
        }

        public void SetStockConfirmedStatus()
        {
            if (OrderStatus == OrderStatus.AwaitingValidation)
            {
                this._domainEvents.Add(new OrderStatusChangedToStockConfirmedEvent(Id));

                OrderStatus = OrderStatus.StockConfirmed;
                Description = "All the items were confirmed with available stock.";
            }
        }

        public void SetPaidStatus()
        {
            if (OrderStatus == OrderStatus.StockConfirmed)
            {
                this._domainEvents.Add(new OrderStatusChangedToPaidEvent(Id, OrderItems));
                OrderStatus = OrderStatus.Paid;
                Description = "The payment was performed at a simulated \"American Bank checking bank account ending on XX35071\"";
            }
        }

        public void SetShippedStatus()
        {
            if (OrderStatus != OrderStatus.Paid)
            {
                StatusChangeException(OrderStatus.Shipped);
            }

            OrderStatus = OrderStatus.Shipped;
            Description = "The order was shipped.";
            this._domainEvents.Add(new OrderShippedEvent(this));
        }

        public void SetCancelledStatus()
        {
            if (OrderStatus == OrderStatus.Paid ||
                OrderStatus == OrderStatus.Shipped)
            {
                StatusChangeException(OrderStatus.Cancelled);
            }

            OrderStatus = OrderStatus.Cancelled;
            Description = $"The order was cancelled.";
            this._domainEvents.Add(new OrderCancelledEvent(this));
        }

        public void SetCancelledStatusWhenStockIsRejected(IEnumerable<int> orderStockRejectedItems)
        {
            if (OrderStatus == OrderStatus.AwaitingValidation)
            {
                OrderStatus = OrderStatus.Cancelled;

                var itemsStockRejectedProductNames = OrderItems
                    .Where(c => orderStockRejectedItems.Contains(c.ProductId))
                    .Select(c => c.ProductName);

                var itemsStockRejectedDescription = string.Join(", ", itemsStockRejectedProductNames);
                Description = $"The product items don't have stock: ({itemsStockRejectedDescription}).";
            }
        }

        private void AddOrderStartedDomainEvent(string userId, string userName, int cardTypeId, string cardNumber,
                string cardSecurityNumber, string cardHolderName, DateTime cardExpiration)
        {
            var orderStartedDomainEvent = new OrderStartedEvent(this, userId, userName, cardTypeId,
                                                                   cardNumber, cardSecurityNumber,
                                                                      cardHolderName, cardExpiration);

            this._domainEvents.Add(orderStartedDomainEvent);
        }

        private void StatusChangeException(OrderStatus orderStatusToChange)
        {
            throw new DomainException($"Is not possible to change the order status from {OrderStatus} to {orderStatusToChange}.");
        }

        public double GetTotal()
        {
            return _orderItems.Sum(o => o.Units * o.UnitPrice);
        }
    }
}
