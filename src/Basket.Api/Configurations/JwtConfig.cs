namespace Basket.Api.Configurations
{
    public sealed record JwtConfig
    {
        public static readonly string SectionName = "JwtConfig";

        public string Algorithm { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
        public int Expires { get; set; } // minutes
        public int RefreshTokenExpiryTime { get; set; } // days
    }
}
