namespace Basket.Api.Infrastructure.Entities
{
    public class Basket : Entity
    {
        public int UserId { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
