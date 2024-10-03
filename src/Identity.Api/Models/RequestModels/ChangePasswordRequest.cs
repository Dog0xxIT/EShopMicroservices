namespace Identity.Api.Models.RequestModels
{
    public sealed class ChangePasswordRequest
    {
        [Required]
        public string NewPassword { get; set; }

        [Required]
        public string OldPassword { get; set; }
    }
}