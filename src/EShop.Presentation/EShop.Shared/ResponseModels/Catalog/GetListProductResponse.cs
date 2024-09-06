using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Shared.ResponseModels.Catalog
{
    public class GetListProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double AvgStarPoint { get; set; }
        public int TotalRating { get; set; }
        public string PictureLink { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int AvailableStock { get; set; }
    }
}
