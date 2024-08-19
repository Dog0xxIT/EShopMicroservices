using EShop.Application.Enums;

namespace EShop.Application.Entities
{
    public class Payment : Entity
    {
        public string Alias { get; set; }

        public string CardNumber { get; set; }

        public string SecurityNumber { get; set; }

        public string CardHolderName { get; set; }

        public DateTime Expiration { get; set; }

        public CardType CardType { get; set; }
    }
}
