using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedElements.DB
{
    public static class DbConnection
    {
        private static string connectionString = "Data Source=PCX;Initial Catalog=testowanie;Integrated Security=True;MultipleActiveResultSets=true";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new(connectionString);
            return connection;
        }
    }
}