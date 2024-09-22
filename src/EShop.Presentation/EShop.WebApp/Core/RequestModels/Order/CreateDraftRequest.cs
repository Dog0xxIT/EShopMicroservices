using System.ComponentModel.DataAnnotations;
using EShop.Shared.RequestModels.Order;

namespace EShop.WebApp.Core.RequestModels.Order
{
    public sealed class CreateDraftRequest
    {
        public int BuyerId { get; set; }

        [Required]
        public List<OderItemRequest> OrderItems { get; set; }
    }
}
