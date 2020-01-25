using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public interface IDao<T>
    { 
        List<T> GetAll();
        void Create(T obj);
        T Read(int id);
        void Update(T obj);
        void Delete(int id);
    }
}
