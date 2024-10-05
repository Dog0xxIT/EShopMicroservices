using Ordering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Aggregates.BuyerAggregate
{
    public class CardType : BaseEntity
    {
        public string Name { get; private set; }

        private CardType() { }

        public CardType(string id, string name)
            : base(id)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentNullException(nameof(name)) : name;
        }
    }
}
