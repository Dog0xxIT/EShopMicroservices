using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Catalog
{
    public class GetProductsByAdvanceFilterRequest
    {
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public List<int> BrandIdList { get; set; }
    }
}
