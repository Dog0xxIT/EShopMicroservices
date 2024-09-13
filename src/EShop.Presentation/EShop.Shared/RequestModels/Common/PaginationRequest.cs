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
        public int PageSize { get; set; } = 10;

        public int PageIndex { get; set; } = 0;
    }
}
