using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EShop.WebApp.Core.RequestModels.Identity
{
    public sealed class SignInRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }
    }
}