using EShop.Application.Enums;

namespace EShop.Application.Models
{
    public class Order : Entity
    {
        public OrderStatus OrderStatus { get; set; }

        public int AddressId { get; set; }

        public double Amount { get; set; }

        public int BuyerId { get; set; }

        public int PaymentId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public User Buyer { get; set; } = new();

        public Address Address { get; set; }

        public Payment Payment { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }
}
