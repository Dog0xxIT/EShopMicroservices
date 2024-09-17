using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Common
{
    public sealed class ResponseObject
    {
        public string Message { get; set; } = "Success";

        public static ResponseObject Succeeded => new();
    }
}
