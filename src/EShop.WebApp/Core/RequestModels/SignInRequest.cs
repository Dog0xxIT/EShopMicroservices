using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
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