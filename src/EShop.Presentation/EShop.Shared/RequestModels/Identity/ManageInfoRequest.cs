﻿using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.RequestModels.Identity
{
    public sealed class ManageInfoRequest
    {
        [Required]
        [EmailAddress]
        public string NewEmail { get; set; }
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}