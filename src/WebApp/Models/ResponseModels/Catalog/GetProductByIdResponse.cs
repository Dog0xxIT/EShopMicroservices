namespace WebApp.Models.ResponseModels
{
    public class GetProductByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string EmbedDescription { get; set; }
        public double Price { get; set; }
        public string ThumbnailUrl { get; set; }
        public double Discount { get; set; }
        public int ReviewCount { get; set; }
        public double RatingAverage { get; set; }
        public _Brand Brand { get; set; } = new();
        public _Category Category { get; set; } = new();
        public int TotalBuyer { get; set; }
        public string Sku { get; set; }
        public List<Variant> Variants { get; set; } = new();
        public List<ConfigOption> ConfigOptions { get; set; } = new();

        public class _Brand
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Slug { get; set; }
        }

        public class _Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ThumbnailUrl { get; set; }
        }

        public class Variant
        {
            public int ProductVariantId { get; set; }
            public int ProductId { get; set; }
            public double Price { get; set; }
            public int AvailableStock { get; set; }
            public string Sku { get; set; }
            public string Option1 { get; set; }
            public string Option2 { get; set; }
        }

        public class ConfigOption
        {
            public int OptionTypeId { get; set; }
            public string OptionType { get; set; }
            public List<string> Values { get; set; }
        }
    }
}
