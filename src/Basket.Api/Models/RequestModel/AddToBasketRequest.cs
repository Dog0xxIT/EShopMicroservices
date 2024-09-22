using System.ComponentModel.DataAnnotations;

namespace Basket.Api.Models.RequestModel
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
