using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
{
    public class GetListProductRequest : PaginationRequest
    {
        [Range(0.001, double.MaxValue)]
        public double? MinPrice { get; set; }

        [Range(0.001, double.MaxValue)]
        public double? MaxPrice { get; set; }

        [RegularExpression(@"^(\d+)(\,\d+)*$", ErrorMessage = "A comma-separated list of brand IDs")]
        public string? Brands { get; set; }

        public string? Keyword { get; set; }

        public string? Sku { get; set; }

        public string? Name { get; set; }

        public string? Color { get; set; }

        public int? RatingStar { get; set; }

        [RegularExpression(@"^(\d+)(\,\d+)*$", ErrorMessage = "A comma-separated list of category IDs")]
        public string? Categories { get; set; }

        [RegularExpression(@"^(id|price|date_modified)$", ErrorMessage = "Sort direction. Acceptable values are: id, price, date_modified.")]
        public string SortBy { get; set; } = "id";
    }
}
