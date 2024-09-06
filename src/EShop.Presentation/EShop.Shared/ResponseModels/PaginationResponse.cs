using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels
{
    public sealed class PaginationResponse<T>
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
