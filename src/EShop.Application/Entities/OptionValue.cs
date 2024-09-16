using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Entities
{
    public class OptionValue : Entity
    {
        public int OptionTypeId { get; set; }
        public string Value { get; set; }

        public OptionType OptionType { get; set; }
    }
}
