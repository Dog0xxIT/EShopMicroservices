﻿namespace Order.Api.Models.ResponseModels
{
    public class CreateOrderDto
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string Description { get; set; }

        public int BuyerId { get; set; }

        public int PaymentId { get; set; }

        public ICollection<OrderItemDto> OrderItems { get; set; }

        public class OrderItemDto
        {
            public int ProductId { get; set; }

            public int Units { get; set; }
        }
    }
}