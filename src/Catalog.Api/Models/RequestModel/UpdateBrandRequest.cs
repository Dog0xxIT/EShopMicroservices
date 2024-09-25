namespace Catalog.Api.Models.RequestModel
{
    public sealed class UpdateBrandRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
