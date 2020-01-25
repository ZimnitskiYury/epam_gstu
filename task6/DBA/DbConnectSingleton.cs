using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class DbConnectSingleton
    {
        private static readonly Lazy<DbConnectSingleton> instance =
            new Lazy<DbConnectSingleton>(() => new DbConnectSingleton());
        public static DbConnectSingleton Instance { get { return instance.Value; } }
        private DbConnectSingleton()
        { 
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;Integrated Security=True;" +
            @"Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString); 
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
