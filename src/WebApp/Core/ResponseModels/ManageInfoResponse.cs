﻿namespace WebApp.Core.ResponseModels
{
    public class ManageInfoResponse
    {
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string UserId { get; set; }
    }
}
