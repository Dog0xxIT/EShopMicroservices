namespace WebApp.Models.RequestModels.Identity
{
    public sealed class Manage2FaRequest
    {
        public bool Enable { get; set; }
        public string TwoFactorCode { get; set; }
        public bool ResetSharedKey { get; set; }
        public bool ResetRecoveryCodes { get; set; }
        public bool ForgetMachine { get; set; }
    }
}