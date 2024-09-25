namespace Catalog.Api.Models.RequestModel
{
    public sealed class UpdateProductRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Sku { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        [Range(0.001, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        public string ThumbnailUrl { get; set; }

        [Required]
        [Range(0.001, 1)]
        public double Discount { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int AvailableStock { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }
    }
}
