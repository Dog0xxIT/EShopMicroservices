namespace Basket.Api.Data.Entities
{
    public class Basket : BaseEntity
    {
        public int UserId { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
