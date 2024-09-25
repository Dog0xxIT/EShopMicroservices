using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.RequestModels
{
    public sealed class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}