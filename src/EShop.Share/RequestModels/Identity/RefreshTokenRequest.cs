using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.RequestModels.Identity
{
    public sealed class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}