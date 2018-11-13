using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ETSApp.Dao;
using ETSApp.Entity;

namespace ETSApp.Manager
{
    public class EmployeeManager
    {
        private EmployeeDao Dao;// secure

        public EmployeeManager()
        {
            Dao = new EmployeeDao(); //create EmployeesDao object when create EmployeeManager
        }

        //add Employee into Database
        public EnumResult Add(Employees Emp)
        {
            try
            {
                Dao.InsertEmployee(Emp);
                return EnumResult.Success;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in Manager/Add " + EX.Message);
                return EnumResult.Fail;
            }
        }

        // find all employees
        public Result<List<Employees>> ShowEmployees()
        {
            Result<List<Employees>> Result = new Result<List<Employees>>();

            try
            {
                Result.Data = Dao.SelectAll();
                Result.Status = EnumResult.Success;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in Manager/FindEmployees, " + EX.Message);
                Result.Status = EnumResult.Fail;
            }

            return Result;
        }

        // find employee by ID
        public Result<Employees> SearchByID(int ID) // from user input
        {
            Result<Employees> Result = new Result<Employees>();

            try
            {
                Result.Data = Dao.SelectByID(ID);
                Result.Status = EnumResult.Success;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in Manager/SearchByID, " + EX.Message);
                Result.Status = EnumResult.Fail;
            }

            return Result;
        }

        // find employee by email
        public Result<Employees> SearchByEmail(string Email) // from user input
        {
            Result<Employees> Result = new Result<Employees>();

            try
            {
                Result.Data = Dao.SelectByEmail(Email);
                Result.Status = EnumResult.Success;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in Manager/SearchByEmail, " + EX.Message);
                Result.Status = EnumResult.Fail;
            }

            return Result;
        }

        //update employee detail
        public EnumResult Edit(Employees Emp)
        {
            try
            {
                Dao.UpdateEmployee(Emp);
                return EnumResult.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur in Manager/Edit " + ex.Message);
                return EnumResult.Fail;
            }
        }

        //delete employee and working detail
        public EnumResult Remove(Employees Emp)
        {
            try
            {
                Dao.DeleteAll(Emp);
                return EnumResult.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur in Manager/Delete " + ex.Message);
                return EnumResult.Fail;
            }
        }
    }
}
