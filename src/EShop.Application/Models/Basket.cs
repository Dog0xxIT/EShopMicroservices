namespace EShop.Application.Models
{
    public class Basket : Entity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
