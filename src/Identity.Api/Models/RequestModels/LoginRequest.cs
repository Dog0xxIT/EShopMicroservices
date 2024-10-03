using System.ComponentModel;

namespace Identity.Api.Models.RequestModels
{
    public sealed class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}