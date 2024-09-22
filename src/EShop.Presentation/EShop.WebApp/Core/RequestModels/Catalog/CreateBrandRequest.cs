using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Catalog
{
    public sealed class CreateBrandRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }
    }
}
