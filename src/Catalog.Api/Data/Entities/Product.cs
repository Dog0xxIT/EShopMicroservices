namespace Catalog.Api.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Sku { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public double Price { get; set; }

        public string ThumbnailUrl { get; set; }

        public double Discount { get; set; }

        public int TotalBuyer { get; set; }

        public int ReviewCount { get; set; }

        public double RatingAverage { get; set; }

        public int AvailableStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public List<ProductVariant> ProductVariant { get; set; }

        //[JsonIgnore]
        //public Vector Embedding { get; set; }
    }
}
