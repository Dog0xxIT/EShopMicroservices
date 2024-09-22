namespace EShop.WebApp.Core.ResponseModels.Catalog
{
    public sealed class GetListBrandsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Thumnai { get; set; }
        public int ProductCount { get; set; }
    }
}
