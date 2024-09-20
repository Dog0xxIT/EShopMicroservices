using Microsoft.EntityFrameworkCore;

namespace EShop.Application.Entities
{
    public class BasketItem : Entity
    {
        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int BasketId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Product Product { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Basket Basket { get; set; }
    }
}
