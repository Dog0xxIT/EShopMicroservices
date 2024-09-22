using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Api.Models.RequestModel
{
    public sealed class UpdateProductRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }

        [Required]
        public string Sku { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }

        public double Discount { get; set; }

        public string OtherAttributes { get; set; }

        public string ImageUrl { get; set; }
    }
}
