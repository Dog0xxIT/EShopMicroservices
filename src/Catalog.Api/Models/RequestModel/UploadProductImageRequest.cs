using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
