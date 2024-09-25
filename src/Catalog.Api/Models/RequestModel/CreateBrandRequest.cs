namespace Catalog.Api.Models.RequestModel
{
    public sealed class CreateBrandRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
