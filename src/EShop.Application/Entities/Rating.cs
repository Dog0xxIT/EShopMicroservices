using System.ComponentModel.DataAnnotations;

namespace EShop.Application.Entities
{
    public class Rating : Entity
    {
        public int UserId { get; set; }

        public int ProductId { get; set; }

        [Range(1, 5)]
        public int StarPoint { get; set; }

        public string Comment { get; set; }


        public User User { get; set; }

        public Product Product { get; set; }
    }
}
