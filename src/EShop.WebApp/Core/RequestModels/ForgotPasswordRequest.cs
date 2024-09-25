using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
{
    public sealed class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}