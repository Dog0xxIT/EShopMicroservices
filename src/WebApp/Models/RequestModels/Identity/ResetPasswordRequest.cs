﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.RequestModels.Identity
{
    public sealed class ResetPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string ResetCode { get; set; }

        [Required]
        [PasswordPropertyText]
        public string NewPassword { get; set; }
    }
}