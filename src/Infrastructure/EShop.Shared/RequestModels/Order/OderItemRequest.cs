using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Order
{
    public class OderItemRequest
    {
        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}
