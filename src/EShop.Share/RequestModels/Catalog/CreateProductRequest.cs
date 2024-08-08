using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Catalog
{
    public sealed class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.001, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }

        [Required]
        public int AvailableStock { get; set; }

        [Required]
        public int RestockThreshold { get; set; }

        [Required]
        public int MaxStockThreshold { get; set; }

        public string Description { get; set; }
    }
}
