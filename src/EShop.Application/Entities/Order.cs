using EShop.Application.Enums;

namespace EShop.Application.Entities
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

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
