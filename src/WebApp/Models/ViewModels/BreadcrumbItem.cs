﻿namespace WebApp.Models.ViewModels
{
    public class BreadcrumbItem
    {
        public string Text { get; set; }
        public ISvgIcon Icon { get; set; }
        public string Url { get; set; }
    }
}
