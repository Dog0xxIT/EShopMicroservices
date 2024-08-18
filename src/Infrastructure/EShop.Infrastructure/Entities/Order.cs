using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Enums;

namespace EShop.Data.Entities
{
    public class Order : Entity
    {
        public string? Street { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public string? ZipCode { get; set; }

        public string? Description { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public int BuyerId { get; set; }

        public User Buyer { get; set; }

        public int? PaymentId { get; set; }

        public Payment? Payment { get; set; }

        public IReadOnlyCollection<OrderItem> OrderItems { get; }

        public Order(string street, string city, string state, string country, string zipCode, string description,
            OrderStatus orderStatus, int buyerId, int paymentId)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            OrderStatus = orderStatus;
            BuyerId = buyerId;
            PaymentId = paymentId;
        }

        // Create Draft
        public Order(int buyerId)
        {
            BuyerId = buyerId;
            OrderStatus = OrderStatus.Draft;
        }
    }
}
