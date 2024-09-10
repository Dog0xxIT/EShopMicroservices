using Microsoft.AspNetCore.Identity;

namespace EShop.Application.Entities
{
    public class User : IdentityUser<int>
    {
        public string AvatarUrl { get; set; }

        public ICollection<Order> Orders { get; }

        public ICollection<Payment> Payments { get; }

        public ICollection<Address> Addresses { get; }

    }
}
