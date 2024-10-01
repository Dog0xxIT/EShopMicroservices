using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Basket
{
    public sealed class UpdateQtyRequest
    {
        public int BasketItemId { get; set; }

        [Range(0, int.MaxValue)]
        public int Qty { get; set; }
    }
}
