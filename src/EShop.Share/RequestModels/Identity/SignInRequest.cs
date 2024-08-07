using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.RequestModels.Identity
{
    public sealed class SignInRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        public string? TwoFactorCode { get; set; }
        public string? TwoFactorRecoveryCode { get; set; }
    }
}