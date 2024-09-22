namespace EShop.WebApp.Core.ResponseModels.Catalog
{
    public class GetProductByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public List<string> DescriptionSections { get; set; } = new();
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double Discount { get; set; }
        public int ReviewsCount { get; set; }
        public double Star { get; set; }
        public _Brand Brand { get; set; } = new();
        public _Category Category { get; set; } = new();
        public int TotalBuyers { get; set; }
        public string Sku { get; set; }
        public List<Variant> Variants { get; set; } = new();

        public class _Brand
        {
            public int BrandId { get; set; }
            public string BrandName { get; set; }
            public string ThumbnailUrl { get; set; }
            public string Code { get; set; }
        }

        public class _Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string ThumbnailUrl { get; set; }
            public string Code { get; set; }
        }

        public class Variant
        {
            public int ProductId { get; set; }
            public int ProductVariantId { get; set; }
            public string Sku { get; set; }
            public int OptionTypeId { get; set; }
            public string OptionType { get; set; }
            public string OptionValue { get; set; }
        }
    }
}
