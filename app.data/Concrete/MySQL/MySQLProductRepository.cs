using System.Collections.Generic;
using app.data.Abstract;
using app.entity;

namespace app.data.Concrete.MySQL
{
    public class MySQLProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}