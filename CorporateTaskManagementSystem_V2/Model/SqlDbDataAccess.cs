using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class SqlDbDataAccess
    {
        private const string connectionString = @"Data Source=LAPTOP-zireael\SQLEXPRESS;Initial Catalog=CorpTaskMS_V2;Integrated Security=True;Encrypt=False";

        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;

            return cmd;
        }
    }
}
