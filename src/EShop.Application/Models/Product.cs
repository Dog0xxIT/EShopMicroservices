namespace EShop.Application.Models
{
    public class Product : Entity
    {
        public string Sku { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        public double Discount { get; set; }

        public int TotalBuyers { get; set; }

        public int ReviewsCount { get; set; }

        public double Star { get; set; }

        public Category Category { get; set; }

        public Brand Brand { get; set; }

        public List<ProductVariant> ProductVariant { get; set; }

        //[JsonIgnore]
        //public Vector Embedding { get; set; }
    }
}
