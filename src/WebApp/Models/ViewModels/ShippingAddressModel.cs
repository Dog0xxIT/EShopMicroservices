using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels
{
    public class ShippingAddressModel
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }
    }
}
