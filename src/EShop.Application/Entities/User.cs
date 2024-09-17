using Microsoft.AspNetCore.Identity;

namespace EShop.Application.Entities
{
    public class User : IdentityUser<int>
    {
        public string AvatarUrl { get; set; }

        public List<Order> Orders { get; set; }

        public List<Payment> Payments { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
