using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Catalog
{
    public class PaginationRequest
    {
        public int PageSize { get; set; } = 10;

        public int PageIndex { get; set; } = 0;
    }
}
