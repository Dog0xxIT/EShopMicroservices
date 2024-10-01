using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Identity
{
    public sealed class ResendConfirmEmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}