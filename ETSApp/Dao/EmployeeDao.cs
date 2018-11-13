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
    public class EmployeeDao
    {
        // insert new employee into EmployeeTbl
        public void InsertEmployee(Employees Emp)
        {
            //open connection with Database
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=DESKTOP-VQB9IAD; Initial Catalog=EmployeeTrackingDB; Integrated Security=True";
            //conn.Open();

            //Code about can be reuse, create Connection helper
            SqlConnection conn = ConnectionHelper.CreateConnection();


            //create command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_InsertEmployee", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //Parameters in Store procedure
            comm.Parameters.Add(new SqlParameter("@firstname", Emp.FirstName));
            comm.Parameters.Add(new SqlParameter("@lastname", Emp.LastName));
            comm.Parameters.Add(new SqlParameter("@email", Emp.Email));
            comm.Parameters.Add(new SqlParameter("@dob", Emp.DOB));
            comm.Parameters.Add(new SqlParameter("@phone", Emp.Phone));

            //exercute
            comm.ExecuteNonQuery();

            //close connection
            conn.Close();
        }

        //find all Employees
        public List<Employees> SelectAll()
        {
            List<Employees> list = new List<Employees>();
            //connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //Command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_SelectAll", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameters
            //NA

            //exercute
            SqlDataReader Reader = comm.ExecuteReader();

            while (Reader.Read())
            {
                Employees Emp = new Employees();
                Emp.EmpID = Convert.ToInt32(Reader["EmpID"]);
                Emp.FirstName = Convert.ToString(Reader["FirstName"]);
                Emp.LastName = Convert.ToString(Reader["LastName"]);
                Emp.Email = Convert.ToString(Reader["Email"]);
                Emp.DOB = Convert.ToDateTime(Reader["DOB"]);
                Emp.Phone = Convert.ToString(Reader["Phone"]);

                list.Add(Emp); //put al details in to list
            }

            //close connection
            conn.Close();

            return list;
        }

        //Select employee by ID
        public Employees SelectByID(int ID)
        {
            Employees Emp = new Employees();
            //connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //Command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_SelectByID", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameters
            comm.Parameters.Add(new SqlParameter("@empid", ID));

            //exercute
            SqlDataReader Reader = comm.ExecuteReader();

            while (Reader.Read())
            {
                //Employees Emp = new Employees();
                Emp.EmpID = Convert.ToInt32(Reader["EmpID"]);
                Emp.FirstName = Convert.ToString(Reader["FirstName"]);
                Emp.LastName = Convert.ToString(Reader["LastName"]);
                Emp.Email = Convert.ToString(Reader["Email"]);
                Emp.DOB = Convert.ToDateTime(Reader["DOB"]);
                Emp.Phone = Convert.ToString(Reader["Phone"]);

                
            }

            //close connection
            conn.Close();

            return Emp;
        }

        //select employee by email
        public Employees SelectByEmail(string email)
        {
            Employees Emp = new Employees();
            //connection
            SqlConnection conn = ConnectionHelper.CreateConnection();

            //Command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_SelectByEmail", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //parameters
            comm.Parameters.Add(new SqlParameter("@email", email));

            //exercute
            SqlDataReader Reader = comm.ExecuteReader();

            while (Reader.Read())
            {
                
                Emp.EmpID = Convert.ToInt32(Reader["EmpID"]);
                Emp.FirstName = Convert.ToString(Reader["FirstName"]);
                Emp.LastName = Convert.ToString(Reader["LastName"]);
                Emp.Email = Convert.ToString(Reader["Email"]);
                Emp.DOB = Convert.ToDateTime(Reader["DOB"]);
                Emp.Phone = Convert.ToString(Reader["Phone"]);

                
            }

            //close connection
            conn.Close();

            return Emp;
        }
        //update EWmployee
        public void UpdateEmployee(Employees Emp)
        {
            SqlConnection con = ConnectionHelper.CreateConnection();

            //exercute command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_UpdateEmployeeTbl", con);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.Add(new SqlParameter("@empid", Emp.EmpID));
            comm.Parameters.Add(new SqlParameter("@firstname", Emp.FirstName));
            comm.Parameters.Add(new SqlParameter("@lastname", Emp.LastName));
            comm.Parameters.Add(new SqlParameter("@dob", Emp.DOB));
            comm.Parameters.Add(new SqlParameter("@email", Emp.Email));
            comm.Parameters.Add(new SqlParameter("@phone", Emp.Phone));

            comm.ExecuteNonQuery();

            con.Close();
        }

        //delete detail
        public void DeleteAll(Employees Emp)
        {
            SqlConnection con = ConnectionHelper.CreateConnection();

            //exercute command
            SqlCommand comm = new SqlCommand("SP_EmployeeTbl_Delete", con);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.Add(new SqlParameter("@empid", Emp.EmpID));

            comm.ExecuteNonQuery();

            con.Close();
        }

        
    }
}
