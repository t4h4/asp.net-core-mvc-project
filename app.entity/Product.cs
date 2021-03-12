using System.Collections.Generic;

namespace app.entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public List<ProductCategory> ProductCategory { get; set; } //Bir product birden fazla kategori içerebilir, bir kategori birden fazla product içerebilir bu yapı.
    }
}