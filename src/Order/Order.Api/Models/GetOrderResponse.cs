using Ordering.Domain.Enums;

namespace Ordering.Api.Models
{
    public class GetOrderResponse
    {
        public string OrderId { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public class OrderItem
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int Units { get; set; }
            public double UnitPrice { get; set; }
            public string PictureUrl { get; set; }
        }
    }
}
