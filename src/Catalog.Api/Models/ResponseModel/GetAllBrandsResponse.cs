using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Api.Models.ResponseModel
{
    public class GetAllBrandsResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }

        public int ProductCount { get; set; }
    }
}
