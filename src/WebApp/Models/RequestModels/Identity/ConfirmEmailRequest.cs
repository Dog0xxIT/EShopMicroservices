using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Identity
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