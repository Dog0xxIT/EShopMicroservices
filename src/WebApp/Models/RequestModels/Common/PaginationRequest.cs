using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Common
{
    public class PaginationRequest
    {
        [Range(1, 1000)]
        public int Limit { get; set; } = 50;

        [Range(1, 1000)]
        public int Page { get; set; } = 1;

        public bool SortDescending { get; set; }
    }
}
