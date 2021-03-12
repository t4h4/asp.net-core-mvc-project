using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}