using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Api.Models.RequestModels
{
    public class OderItemRequest
    {
        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}
