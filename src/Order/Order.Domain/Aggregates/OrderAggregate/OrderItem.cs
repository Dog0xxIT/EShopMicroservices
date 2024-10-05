using System;
using Ordering.Domain.Common;
using Ordering.Domain.Exceptions;

namespace Ordering.Domain.Aggregates.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; private set; }

        public string ProductName { get; private set; }

        public string PictureUrl { get; private set; }

        public double UnitPrice { get; private set; }

        public double Discount { get; private set; }

        public int Units { get; private set; }

        public double TotalPrice { get; private set; }

        private OrderItem() { }

        public OrderItem(
            string id, int productId, string productName, string pictureUrl,
            double unitPrice, double discount, int units) : base(id)
        {
            ProductName = string.IsNullOrWhiteSpace(productName) ? throw new ArgumentNullException(nameof(productName)) : productName;
            PictureUrl = string.IsNullOrWhiteSpace(pictureUrl) ? throw new ArgumentNullException(nameof(pictureUrl)) : pictureUrl;
            UnitPrice = unitPrice;
            Discount = discount;
            Units = units;
            ProductId = productId;
            TotalPrice = UnitPrice * Units;
        }

        public void SetNewDiscount(double discount)
        {
            if (discount < 0 || discount > this.TotalPrice)
            {
                throw DomainException.InvalidDiscount;
            }

            Discount = discount;
        }

        public void AddUnits(int units)
        {
            if (units < 0)
            {
                throw DomainException.InvalidUnits;
            }

            Units += units;
        }
    }
}
