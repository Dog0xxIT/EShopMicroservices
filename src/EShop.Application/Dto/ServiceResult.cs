using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Dto
{
    public class ServiceResult<T>
    {
        public bool Success { get; set; }
        public string MessageError { get; set; }
        public T Data { get; set; }

        public ServiceResult()
        {
        }

        public ServiceResult(string messageError)
        {
            MessageError = messageError;
            Success = false;
            Data = default(T);
        }

        public ServiceResult(T data)
        {
            Success = true;
            Data = data;
            MessageError = string.Empty;
        }
    }
}
