using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Common
{
    public sealed class PaginationResponse<T> where T : class
    {
        public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();
        public Pagination Meta { get; set; } = new();
    }
}
