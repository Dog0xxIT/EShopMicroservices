using Basket.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basket.Api.Infrastructure.Entities
{
    public class BasketItem : Entity
    {
        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int BasketId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Data.Entities.Basket Basket { get; set; }
    }
}
