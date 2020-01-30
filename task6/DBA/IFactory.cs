using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    interface IFactory<T>
    {
        IDao<T> Create();
    }
}
