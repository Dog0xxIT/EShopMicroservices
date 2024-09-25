using Basket.Api.Infrastructure.Entities;

namespace Basket.Api.Data.Entities
{
    public class Basket : Entity
    {
        public int UserId { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
