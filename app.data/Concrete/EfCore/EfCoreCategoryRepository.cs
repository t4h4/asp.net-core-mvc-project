using System.Collections.Generic;
using app.data.Abstract;
using app.entity;

namespace app.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : ICategoryRepository
    {
        private ShopContext db = new ShopContext();
        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}