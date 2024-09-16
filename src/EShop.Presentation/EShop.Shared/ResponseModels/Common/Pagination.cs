using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Common
{
    public sealed class Pagination
    {
        public int Total { get; set; }
        public int Count { get; set; }
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Previous { get; set; } = string.Empty;
        public string Current { get; set; } = string.Empty;
        public string Next { get; set; } = string.Empty;
    }
}
