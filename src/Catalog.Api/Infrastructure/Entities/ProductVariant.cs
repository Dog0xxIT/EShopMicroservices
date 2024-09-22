using Catalog.Api.Infrastructure.Entites;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure.Entities
{
    public class ProductVariant : Entity
    {
        public string Sku { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int ProductId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Product Product { get; set; }

        public List<VariantOption> VariantOptions { get; set; }
    }
}
