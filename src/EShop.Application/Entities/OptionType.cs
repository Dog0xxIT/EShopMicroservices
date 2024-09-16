using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Entities
{
    public class OptionType : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<int> OptionValues { get; set; }
    }
}
