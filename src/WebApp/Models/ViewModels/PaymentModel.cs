using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels
{
    public class PaymentModel
    {
        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]
        public DateTime CardExpiration { get; set; }

        [Required]
        public string CardSecurityNumber { get; set; }

        [Required]
        public int? CardTypeId { get; set; }
    }
}
