using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Identity
{
    public sealed class ConfirmEmailRequest
    {
        [Required]
        public string Code { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}