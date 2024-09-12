using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Identity
{
    public class ManageInfoResponse
    {
        public string Email { get; set; }
        public List<string> Roles { get; set; }
    }
}
