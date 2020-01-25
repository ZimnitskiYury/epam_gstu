using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    interface IDbFactory<T>
    {
        SqlCommand GetAll();
        SqlCommand Create(T obj);
        SqlCommand Read(int id);
        SqlCommand Update(T obj);
        SqlCommand Delete(int id);
    }
}
