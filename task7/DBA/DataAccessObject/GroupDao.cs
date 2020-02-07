using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class GroupDao:IDao<Group>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public GroupDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public GroupDao()
        {

        }
        public void Create(Group obj)
        {
            string sql = $"INSERT INTO [Group] VALUES (@Name)";
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
            string sql = $"Delete from Group where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Group> GetAll()
        {
            List<Group> groups = new List<Group>();
            string sql = $"SELECT * FROM [Group]";
            SqlCommand cmd = new SqlCommand(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                Group group = new Group(dbreader.GetInt32(0), dbreader.GetString(1));
                groups.Add(group);
            }
            connection.Close();
            return groups;
        }

        public Group Read(int id)
        {
            string sql = $"SELECT * FROM [Group] WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Group group = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                group = new Group(dbreader.GetInt32(0), dbreader.GetString(1));
            }
            connection.Close();
            return group;
        }

        public void Update(Group obj)
        {
            string sql = $"UPDATE Group SET Name=@Name WHERE Id=@id";
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
