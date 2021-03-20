using System.Collections.Generic;
using System.Linq;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using (var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                                .Where(i => i.ProductId == id) //product tablosundan ilgili id ürünü al
                                .Include(i => i.ProductCategories) //product categories'i dahil ediyoruz.
                                .ThenInclude(i => i.Category) // product categories'den sonra category'e geçiyoruz. ikinci geçiş oldugu için then include kullanıldı.
                                .FirstOrDefault(); //product id'ye göre kayıt varsa buldugun ilk kaydı bana getir. getirirkende ekstra yukarda yapılan join işlemini yap
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}