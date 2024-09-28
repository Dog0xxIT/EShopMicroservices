namespace Basket.Api.Data.Entities
{
    public class BasketItem : BaseEntity
    {
        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string PictureUrl { get; set; }

        public int BasketId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Basket Basket { get; set; }
    }
}
