using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}