﻿namespace WebApp.Core
{
    public class ResultObject<T>
    {
        public int ResultCode { get; set; }
        public string Messages { get; set; }
        public T Data { get; set; }
    }

    public class ResultObject
    {
        public int ResultCode { get; set; }
        public string Messages { get; set; }
    }
}