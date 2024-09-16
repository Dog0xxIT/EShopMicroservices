using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EShop.Shared.RequestModels.Common;

namespace EShop.Shared.RequestModels.Catalog
{
    public class GetAllProductRequest : PaginationRequest
    {
        [Range(0.001, double.MaxValue)]
        public double? Min { get; set; }

        [Range(0.001, double.MaxValue)]
        public double? Max { get; set; }

        public int? BrandId { get; set; }

        public string? Keyword { get; set; }

        public string? Sku { get; set; }

        public string? Name { get; set; }

        //public List<int>? Categories { get; set; }

        public int? Category { get; set; }

        [RegularExpression("^(id|price|date_modified)$",
            ErrorMessage = "Sort direction. Acceptable values are: id, price, date_modified.")]
        public string SortBy { get; set; } = "id";
    }
}
