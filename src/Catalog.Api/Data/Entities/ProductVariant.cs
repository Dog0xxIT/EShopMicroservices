namespace Catalog.Api.Data.Entities
{
    public class ProductVariant : BaseEntity
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public int AvailableStock { get; set; }
        
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Product Product { get; set; }

        public List<ProductOption> Options { get; set; }
    }
}
