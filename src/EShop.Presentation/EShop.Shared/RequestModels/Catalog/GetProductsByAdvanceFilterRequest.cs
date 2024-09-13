using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Shared.RequestModels.Common;

namespace EShop.Shared.RequestModels.Catalog
{
    public class GetProductsByAdvanceFilterRequest : PaginationRequest
    {
        public double MinPrice { get; set; } = 0;
        public double MaxPrice { get; set; } = double.MaxValue;
        public List<int> BrandIdList { get; set; }
        public List<int> CategoryIdList { get; set; }
    }
}
