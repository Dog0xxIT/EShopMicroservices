using Catalog.Api.Infrastructure.Entites;

namespace Catalog.Api.Infrastructure.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }
    }
}
