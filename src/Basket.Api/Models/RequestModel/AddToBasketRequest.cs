namespace Basket.Api.Models.RequestModel
{
    public class AddToBasketRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
