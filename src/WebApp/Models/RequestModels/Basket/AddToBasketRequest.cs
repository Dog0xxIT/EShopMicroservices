using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Basket
{
    public class AddToBasketRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
