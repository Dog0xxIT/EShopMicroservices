using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Identity
{
    public sealed class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}