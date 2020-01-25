using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    abstract class baseDao <T>: IDao<T>
    {
        abstract public void Create(T obj);

        void IDao<T>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<T> IDao<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IDao<T>.Read(int id)
        {
            throw new NotImplementedException();
        }

        void IDao<T>.Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
