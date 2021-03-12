using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}