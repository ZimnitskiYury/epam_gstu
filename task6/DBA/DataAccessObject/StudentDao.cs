using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class StudentDao:IDao<Student>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;";
        private GroupDao groups = new GroupDao();
        public void Create(Student obj)
        {
            string sql = $"INSERT INTO Student VALUES (@CreditBook, @FullName, @DateofBirth, @GroupId, @Gender)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@CreditBook", obj.CreditBook);
            cmd.Parameters.AddWithValue("@FullName", obj.FullName);
            cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId);
            cmd.Parameters.AddWithValue("@Gender", (int)obj.Gender);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Student where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(sql);           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                Student student = new Student(dbreader.GetInt64(1), dbreader.GetString(2), dbreader.GetDateTime(3), (GenderType)dbreader.GetInt32(4), groups.Read(dbreader.GetInt32(5)));
                student.Id = dbreader.GetInt32(0);
                students.Add(student);
            }
            connection.Close();
            return students;
        }

        public Student Read(int id)
        {
            string sql = $"SELECT * FROM Student WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Student student = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                student = new Student(dbreader.GetInt32(1), dbreader.GetString(2), dbreader.GetDateTime(3), (GenderType)dbreader.GetInt32(4), groups.Read(dbreader.GetInt32(5)));
                student.Id = dbreader.GetInt32(0);
            }
            connection.Close();
            return student;
        }

        public void Update(Student obj)
        {
            string sql = $"UPDATE Student SET CreditBook=@CreditBook, FullName=@FullName, DateofBirth=@DateofBirth, GroupId=@GroupId, Gender=@Gender WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@CreditBook", obj.CreditBook);
            cmd.Parameters.AddWithValue("@FullName", obj.FullName);
            cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId);
            cmd.Parameters.AddWithValue("@Gender", (int)obj.Gender);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
