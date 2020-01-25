using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class StudentDao:IDbFactory<Student>
    {
        public SqlCommand Create(Student obj)
        {
            string sql = $"INSERT INTO Student (CreditBook, FullName, DateofBirth, GroupID, Gender) VALUES (@CreditBook, '@FullName', '@DateofBirth', @GroupID, @Gender)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@CreditBook", obj.CreditBook);
            cmd.Parameters.AddWithValue("@FullName", obj.FullName);
            cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth.ToString("MM-dd-yyyy"));
            cmd.Parameters.AddWithValue("@GroupID", obj.GroupId);
            cmd.Parameters.AddWithValue("@Gender", (int)obj.Gender);
            return cmd;
        }

        public SqlCommand Delete(int id)
        {
            string sql = $"Delete from Student where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            return cmd;
        }
        public SqlCommand GetAll()
        {
            throw new NotImplementedException();
        }

        public SqlCommand Read(int id)
        {
            string sql = $"SELECT * FROM Student WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            return cmd;
        }

        public SqlCommand Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
