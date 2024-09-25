namespace Identity.Api.Models.RequestModels
{
    public sealed class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}