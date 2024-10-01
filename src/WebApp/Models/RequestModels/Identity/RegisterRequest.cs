using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Identity
{
    public sealed class RegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}