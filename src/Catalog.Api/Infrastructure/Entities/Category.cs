using Catalog.Api.Infrastructure.Entites;

namespace Catalog.Api.Infrastructure.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Description { get; set; }
    }
}
