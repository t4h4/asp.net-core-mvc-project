using System.Collections.Generic;

namespace app.entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } //Bir product birden fazla kategori içerebilir, bir kategori birden fazla product içerebilir bu yapı.
    }
}