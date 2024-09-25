using Microsoft.AspNetCore.Http;

namespace Catalog.Api.Models.RequestModel
{
    public sealed class UploadProductImageRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public IFormFile FormFile { get; set; }
    }
}
