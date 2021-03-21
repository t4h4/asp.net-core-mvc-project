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

        public List<Product> GetProductsByCategory(string name)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.AsQueryable(); //AsQueryable demek sorguyu yazdıktan sonra ekstra kriter eklemek istiyorum demek için.

                if (!string.IsNullOrEmpty(name))
                {
                    products = products //sorgumuzda product bilgilerinin product categories'lerini daha sonra category'lerini yükleyeceğiz. yükledikten sonra da where şartı ekliyoruz.  
                                    .Include(i => i.ProductCategories) //product categories'i dahil ediyoruz.
                                    .ThenInclude(i => i.Category) //ilgili product'ın kategorisini yüklemiş oluyoruz.
                                    //ilk başta joinleri oluşturacağız. ilgili kayıtları getireceğiz. sonra where koşulu.
                                    //where ile ilk başta her aldığımız product kayıtlarının, product categories'lerine geçiş yapalım,
                                    // ve product categoryies üzerinde herhangi bi' kayıt var mı yok mu diye any ile kontrol edelim. any true gönderirse herhangi bi'ürün vardır o kategoride. 
                                    .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == name.ToLower()));
                }

                return products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}