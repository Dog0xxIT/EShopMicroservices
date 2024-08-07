using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Pgvector;

namespace EShop.Data.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string PictureFileName { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get;  set;}

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int AvailableStock { get; set; }

        public int RestockThreshold { get; set; }

        public int MaxStockThreshold { get; set; }

        //[JsonIgnore]
        //public Vector Embedding { get; set; }

        public Product(string name, string description, double price, string pictureFileName, int categoryId,
            int brandId, int availableStock, int restockThreshold, int maxStockThreshold)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            PictureFileName = pictureFileName ?? throw new ArgumentNullException(nameof(pictureFileName));
            CategoryId = categoryId;
            BrandId = brandId;
            AvailableStock = availableStock;
            RestockThreshold = restockThreshold;
            MaxStockThreshold = maxStockThreshold;
        }
    }
}
