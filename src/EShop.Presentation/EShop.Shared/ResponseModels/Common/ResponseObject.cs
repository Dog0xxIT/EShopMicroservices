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
        public const string Message = "Success";

        public static ResponseObject Succeeded => new();
    }
}
