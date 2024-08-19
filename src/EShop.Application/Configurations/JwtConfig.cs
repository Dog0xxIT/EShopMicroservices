namespace EShop.Application.Configurations
{
    public sealed record JwtConfig
    {
        public readonly string SectionName = "JwtConfig";

        public string Algorithm { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
        public int Expires { get; set; }
    }
}
