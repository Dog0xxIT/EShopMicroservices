namespace Basket.Api.Data.Entities
{
    public class Basket : BaseEntity
    {
        public string UserId { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
