using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class SubjectDao:IDao<Subject>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public SubjectDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public SubjectDao()
        {
            
        }

        public void Create(Subject obj)
        {
            string sql = $"INSERT INTO Subject VALUES (@Name)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Subject where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Subject> GetAll()
        {
            List<Subject> subjects = new List<Subject>();
            string sql = $"SELECT * FROM Subject";
            SqlCommand cmd = new SqlCommand(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                Subject subject = new Subject(dbreader.GetInt32(0), dbreader.GetString(1));
                subjects.Add(subject);
            }
            connection.Close();
            return subjects;
        }

        public Subject Read(int id)
        {
            string sql = $"SELECT * FROM Subject WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Subject subject = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                subject = new Subject(dbreader.GetInt32(0), dbreader.GetString(1));
            }
            connection.Close();
            return subject;
        }

        public void Update(Subject obj)
        {
            string sql = $"UPDATE Subject SET Name=@Name WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
