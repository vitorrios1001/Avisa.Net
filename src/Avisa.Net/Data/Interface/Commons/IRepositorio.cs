using System.Collections.Generic;

namespace Avisa.Net.Data.Interface.Commons
{
    public interface IRepositorio<T> where T : class
    {
        void Insert(T obj);

        void Edit(T obj);

        void Delete(T obj);

        IEnumerable<T> GetAll();

        T GetById(int id);        
         
    }
}