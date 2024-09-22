using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Catalog
{
    public sealed class UpdateBrandRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }
    }
}
