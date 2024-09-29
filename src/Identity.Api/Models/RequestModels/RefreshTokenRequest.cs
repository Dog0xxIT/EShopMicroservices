namespace Identity.Api.Models.RequestModels
{
    public sealed class RefreshTokenRequest
    {
        public RefreshTokenRequest()
        {
        }

        [Required]
        public string RefreshToken { get; set; }
    }
}