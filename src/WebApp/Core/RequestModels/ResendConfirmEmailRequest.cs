using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
{
    public sealed class ResendConfirmEmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}