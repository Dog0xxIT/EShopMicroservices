using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Api.Models.RequestModel
{
    public sealed class CreateBrandRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }
    }
}
