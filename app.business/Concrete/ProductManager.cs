using System.Collections.Generic;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concrete.EfCore;
using app.entity;

namespace app.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            // iş kuralları uygula
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            // iş kuralları
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}