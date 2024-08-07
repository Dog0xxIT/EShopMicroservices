using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Catalog
{
    public sealed class UpdateProductRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [Required]
        public int CatalogTypeId { get; set; }

        [Required]
        public int CatalogBrandId { get; set; }
    }
}
