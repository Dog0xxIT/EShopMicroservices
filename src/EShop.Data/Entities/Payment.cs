using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Enums;

namespace EShop.Data.Entities
{
    public class Payment : Entity
    {
        public string Alias { get; set; }

        public string CardNumber { get; set; }

        public string SecurityNumber { get; set; }

        public string CardHolderName { get; set; }

        public DateTime Expiration { get; set; }

        public CardType CardType { get; set; }

        public Payment(string alias, string cardNumber, string securityNumber, string cardHolderName,
            DateTime expiration, CardType cardType)
        {
            Alias = alias ?? throw new ArgumentNullException(nameof(alias));
            CardNumber = cardNumber ?? throw new ArgumentNullException(nameof(cardNumber));
            SecurityNumber = securityNumber ?? throw new ArgumentNullException(nameof(securityNumber));
            CardHolderName = cardHolderName ?? throw new ArgumentNullException(nameof(cardHolderName));
            Expiration = expiration;
            CardType = cardType;
        }
    }
}
