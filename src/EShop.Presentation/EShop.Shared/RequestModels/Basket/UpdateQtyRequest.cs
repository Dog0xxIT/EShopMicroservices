using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Basket
{
    public sealed class UpdateQtyRequest
    {
        public int BasketId { get; set; }

        public int ProductId { get; set; }

        [Range(0, Int32.MaxValue)]
        public int Qty { get; set; }
    }
}
