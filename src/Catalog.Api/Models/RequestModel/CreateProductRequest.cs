namespace Catalog.Api.Models.RequestModel
{
    public sealed class CreateProductRequest
    {
        [Required]
        public string Sku { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        public string ThumbnailUrl { get; set; }

        public double Discount { get; set; }

        [Required]
        public int? AvailableStock { get; set; }

        [Required]
        public int? CategoryId { get; set; }

        [Required]
        public int? BrandId { get; set; }
    }
}
