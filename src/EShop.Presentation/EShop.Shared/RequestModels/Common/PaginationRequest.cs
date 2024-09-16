using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Common
{
    public class PaginationRequest
    {
        [Range(1, 1000)]
        public int Limit { get; set; } = 50;

        public int Page { get; set; } = 0;

        public bool SortDescending { get; set; }
    }
}
