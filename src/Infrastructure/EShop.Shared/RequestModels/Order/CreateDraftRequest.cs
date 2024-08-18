using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.RequestModels.Order
{
    public sealed class CreateDraftRequest
    {
        public int BuyerId { get; set; }

        [Required]
        public List<OderItemRequest> OrderItems { get; set; }
    }
}
