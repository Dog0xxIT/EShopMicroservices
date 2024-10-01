namespace WebApp.Models.ResponseModels
{
    public class GetAllCategoriesResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ThumbnailUrl { get; set; }

        public int? ParentId { get; set; }

        public bool HasChild => Childs.Any();

        public List<GetAllCategoriesResponse> Childs { get; set; } = new();
    }
}
