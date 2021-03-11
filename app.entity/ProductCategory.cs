namespace app.entity
{
    public class ProductCategory
    {
        //Bir product birden fazla kategori içerebilir, bir kategori birden fazla product içerebilir bu yapı.
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}