using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string name);
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}