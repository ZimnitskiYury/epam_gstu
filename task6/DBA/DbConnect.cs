using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class DbConnect
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;";
        public DbConnect()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
