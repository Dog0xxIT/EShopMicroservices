using EShop.Domain.Aggregates.BuyerAggregate;
using EShop.Domain.Common;
using EShop.Domain.Enums;
using EShop.Domain.ValueObjects;

namespace EShop.Domain.Aggregates.OrderAggregate
{
    public class Order : IAggregateRoot
    {
        public int OrderId { get; private set; }

        public DateTime OrderDate { get; private set; }

        public Buyer Buyer { get; }

        public int BuyerId { get; private set; }

        public int PaymentId { get; private set; }

        public Address Address { get; private set; }

        public OrderStatus OrderStatus { get; private set; }

        public string Description { get; private set; }

        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method OrderAggregateRoot.AddOrderItem() which includes behavior.
        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public double Total() => _orderItems.Sum(o => o.TotalPrice);

        public Order(
            int orderId, DateTime orderDate, int buyerId,
            int paymentId, Address address, OrderStatus orderStatus,
            List<OrderItem> orderItems)
        {
            _orderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
            OrderId = orderId;
            OrderDate = orderDate;
            BuyerId = buyerId;
            PaymentId = paymentId;
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
                //if previous line exist modify it with higher discount and units..
                if (discount > existingOrderForProduct.Discount)
                {
                    existingOrderForProduct.SetNewDiscount(discount);
                }

                existingOrderForProduct.AddUnits(units);
            }
            else
            {
                //add validated new order item
                var orderItem = new OrderItem(
                    0, productId, productName, pictureUrl,
                    unitPrice, discount, units);
                _orderItems.Add(orderItem);
            }
        }

        public void SetPaymentMethodVerified(int buyerId, int paymentId)
        {
            BuyerId = buyerId;
            PaymentId = paymentId;
        }

        public void SetAwaitingValidationStatus()
        {

        }

        public void SetStockConfirmedStatus()
        {

        }

        public void SetPaidStatus()
        {

        }

        public void SetShippedStatus()
        {

        }

        public void SetCancelledStatus()
        {

        }

        public void SetCancelledStatusWhenStockIsRejected()
        {

        }

        public void StatusChangeException()
        {

        }
    }
}
