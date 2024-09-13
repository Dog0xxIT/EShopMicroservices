using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Catalog
{
    public class GetProductByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public List<string>? DescriptionSections { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double Discount { get; set; }
        public int ReviewsCount { get; set; }
        public double Star { get; set; }
        public _Brand Brand { get; set; }
        public _Category Category { get; set; }
        public int TotalBuyers { get; set; }
        public string Sku { get; set; }

        public class _Brand
        {
            public int BrandId { get; set; }
            public string BrandName { get; set; }
            public string ThumbnailUrl { get; set; }
            public string Code { get; set; }
        }

        public class _Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string ThumbnailUrl { get; set; }
            public string Code { get; set; }
        }
    }
}
