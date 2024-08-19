namespace EShop.Application.Entities
{
    public class BasketItem : Entity
    {
        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string? PictureUrl { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CustomerId { get; set; }

        public User Customer { get; set; }
    }
}
