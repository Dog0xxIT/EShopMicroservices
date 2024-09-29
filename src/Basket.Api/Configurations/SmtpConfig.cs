namespace Basket.Api.Configurations
{
    public sealed record SmtpConfig
    {
        public static readonly string SectionName = "SmtpConfig";

        public string From { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}