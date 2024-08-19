namespace EShop.Application.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public string? PictureFileName { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int AvailableStock { get; set; }

        public int RestockThreshold { get; set; }

        public int MaxStockThreshold { get; set; }

        //[JsonIgnore]
        //public Vector Embedding { get; set; }
    }
}
