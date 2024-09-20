using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Entities
{
    public class VariantOption : Entity
    {
        public int ProductVariantId { get; set; }
        public int OptionTypeId { get; set; }
        public string OptionValue { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public ProductVariant ProductVariant { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public OptionType OptionType { get; set; }
    }
}
