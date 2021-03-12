using System.Collections.Generic;

namespace app.data.Abstract
{
    //hangi entity tipini gönderirsek o tipe göre metodlar oluşturuluyor.
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}