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
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";
        GroupDao groupDao = new GroupDao();

        public StudentDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public StudentDao()
        {
           
        }

        public void Create(Student obj)
        {
            string sql = $"INSERT INTO Student VALUES (@FullName, @DateofBirth, @GroupId, @Gender)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@FullName", obj.FullName);
            cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId.Id);
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
                Student student = new Student(dbreader.GetInt32(0), dbreader.GetString(1), dbreader.GetDateTime(2), groupDao.Read(dbreader.GetInt32(3)), (GenderType)dbreader.GetInt32(4));
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
                student = new Student(dbreader.GetInt32(0), dbreader.GetString(1), dbreader.GetDateTime(2), groupDao.Read(dbreader.GetInt32(3)), (GenderType)dbreader.GetInt32(4));        
            }
            connection.Close();
            return student;
        }

        public void Update(Student obj)
        {
            string sql = $"UPDATE Student SET FullName=@FullName, DateofBirth=@DateofBirth, GroupId=@GroupId, Gender=@Gender WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@FullName", obj.FullName);
            cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId.Id);
            cmd.Parameters.AddWithValue("@Gender", (int)obj.Gender);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
