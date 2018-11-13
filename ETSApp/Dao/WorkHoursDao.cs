using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ETSApp.Entity;
using System.Data.SqlClient;

namespace ETSApp.Dao
{
    public class WorkHoursDao
    {
        public void InsertHours(Hours Hrs)
        {
            //create connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //command
            SqlCommand comm = new SqlCommand("SP_EmpHoursTbl_InsertHours", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameter
            comm.Parameters.Add(new SqlParameter("@empid", Hrs.EmpID));
            comm.Parameters.Add(new SqlParameter("@workdate", Hrs.WorkDate));
            comm.Parameters.Add(new SqlParameter("@hours", Hrs.WorkHours));

            //exercute 
            comm.ExecuteNonQuery();
            //close connection
            conn.Close();
        }

        // select workdate + ID
        public List<Hours> SelectDateHoursByID(string ID)
        {
            List<Hours> list = new List<Hours>();
            //connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //Command
            SqlCommand comm = new SqlCommand("SP_EmpHoursTbl_SelectDateHoursByID", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameters
            comm.Parameters.Add(new SqlParameter("@empid", ID));

            //exercute
            SqlDataReader Reader = comm.ExecuteReader();

            while (Reader.Read())
            {
                Hours Hrs = new Hours();
                //Hrs.EmpID = Convert.ToInt32(Reader["EmpID"]);
                //Hrs.EmpHoursID = Convert.ToInt32(Reader["EmpHoursID"]);
                Hrs.WorkDate = Convert.ToDateTime(Reader["WorkDate"]);
                Hrs.WorkHours = Convert.ToDecimal(Reader["Hours"]);


                list.Add(Hrs); //put al details in to list
            }

            //close connection
            conn.Close();

            return list;
        }

        //sum total worked hours
        public decimal SumHours(string ID)
        {
            Hours Hrs = new Hours();

            //create connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //command
            SqlCommand comm = new SqlCommand("SP_EmpHoursTbl_SumHours", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameter
            comm.Parameters.Add(new SqlParameter("@empid", ID));

            //exercute 
            //SqlDataReader Reader = comm.ExecuteReader();

            //while (Reader.Read())
            //{
            //    Hrs.EmpID = Convert.ToInt32(Reader["EmpID"]);
            //}
            decimal result = (decimal)comm.ExecuteScalar();
            //close connection
            conn.Close();

            //return
            return result;
        }
    }
}
