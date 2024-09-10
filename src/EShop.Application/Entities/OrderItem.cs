namespace EShop.Application.Entities
{
    public class OrderItem : Entity
    {
        public string ProductName { get; set; }

        public string? PictureUrl { get; set; }

        public double UnitPrice { get; set; }

        public double Discount { get; set; }

        public int Units { get; set; }

        public int ProductId { get; set; }


        public Product Product { get; set; }
    }
}
