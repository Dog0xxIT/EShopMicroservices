using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
{
    public class AddToBasketRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
