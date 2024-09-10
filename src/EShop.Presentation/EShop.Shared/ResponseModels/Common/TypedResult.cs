using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Common
{
    public class TypedResult
    {
        public int Status { get; private set; } = 200;

        public static TypedResult Succeeded => new();
    }
}

