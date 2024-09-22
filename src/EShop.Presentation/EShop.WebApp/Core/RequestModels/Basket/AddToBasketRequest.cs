using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Basket
{
    public class AddToBasketRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
