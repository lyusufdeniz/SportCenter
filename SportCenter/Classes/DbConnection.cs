using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenter.Classes
{
    class DbConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=SportCenter;Integrated Security=True;MultipleActiveResultSets=true");

        public static void Connect()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }
        public static void Disconnect()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();

        }
    }
}
