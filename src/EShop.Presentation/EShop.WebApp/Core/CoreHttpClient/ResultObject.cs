﻿namespace EShop.Shared.ResponseModels
{
    public class ResultObject<T>
    {
        public int ResultCode { get; set; }
        public string Messages { get; set; }
        public T Data { get; set; }
    }
}