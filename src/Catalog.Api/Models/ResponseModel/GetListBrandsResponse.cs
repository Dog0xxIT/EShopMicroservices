namespace Catalog.Api.Models.ResponseModel
{
    public sealed class GetListBrandsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }
    }
}
