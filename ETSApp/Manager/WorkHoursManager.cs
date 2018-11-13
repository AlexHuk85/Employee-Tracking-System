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
    class WorkHoursManager
    {
        private WorkHoursDao Dao;// secure

        public WorkHoursManager()
        {
            Dao = new WorkHoursDao(); //create Work hourDao object when create EmployeeManager
        }

        public EnumResult Add(Hours Hrs)
        {
            try
            {
                Dao.InsertHours(Hrs);
                return EnumResult.Success;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in WorkHoursManager/Add " + EX.Message);
                return EnumResult.Fail;
            }
        }

        //display date by ID
        public Result<List<Hours>> DisplayByID(string ID)
        {
            Result<List<Hours>> Result = new Result<List<Hours>>();
            try
            {
                Result.Data = Dao.SelectDateHoursByID(ID);
                Result.Status = EnumResult.Success;

            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in WorkHoursManager/DisplayByID " + EX.Message);
                Result.Status = EnumResult.Fail;
            }
            return Result;
        }

        //dispaly worked hours
        public Result<decimal> DisplayHours(string ID)
        {
            Result<decimal> result = new Result<decimal>();
            try
            {
                result.Data = Dao.SumHours(ID);
                result.Status = EnumResult.Success;

            }
            catch (Exception EX)
            {
                Console.WriteLine("Error occur in WorkHoursManager/DisplayHours " + EX.Message);
                result.Status = EnumResult.Fail;
            }
            return result;
        }
    }
}
