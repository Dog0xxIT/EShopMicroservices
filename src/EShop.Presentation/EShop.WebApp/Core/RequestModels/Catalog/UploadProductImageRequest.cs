using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EShop.WebApp.Core.RequestModels.Catalog
{
    public sealed class UploadProductImageRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public IFormFile FormFile { get; set; }
    }
}
