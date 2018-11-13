using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;

namespace ETSApp.Dao
{
    public class ConnectionHelper
    {
        //for reuse connection code
        public static SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-4O857MQ; Initial Catalog=EmployeeTrackingDB; Integrated Security=True"; //Home PC
            //conn.ConnectionString = "Data Source=.; Initial Catalog=EmployeeTrackingDB; Integrated Security=True"; //school PC
            conn.Open();
            return conn;
        }
    } 
}
