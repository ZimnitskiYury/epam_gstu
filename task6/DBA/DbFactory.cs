using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class DbFactory<T>
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;";
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Create(T obj)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sql = new SqlCommand();
            switch (obj.GetType().Name) 
            {
                case "Student":
                    {
                        Student student = obj as Student;
                        StudentDao dao = new StudentDao();
                        sql = dao.Create(student);
                        break;
                    }
            }
            sql.Connection = connection;
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public T Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
