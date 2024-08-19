using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.RequestModels.Order
{
    public sealed class CreateRequest
    {
        [Required]
        public string Street { get; set; }

        public string? City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public string? Description { get; set; }

        public int BuyerId { get; set; }

        public int PaymentId { get; set; }

        [Required]
        public List<OderItemRequest> OrderItems { get; set; }
    }
}
