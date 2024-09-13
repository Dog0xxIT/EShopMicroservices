using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Catalog
{
    public sealed class CreateBrandRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }
    }
}
