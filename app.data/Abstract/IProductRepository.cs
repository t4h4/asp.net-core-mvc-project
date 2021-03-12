using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(int id);
    }
}