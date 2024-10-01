using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Identity
{
    public sealed class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}