using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSApp.Entity
{
    public class Hours
    {
        public int EmpHoursID { get; set; }
        public int EmpID { get; set; }
        public DateTime WorkDate { get; set; }
        public decimal WorkHours { get; set; }
        //public decimal TotalHours { get; set; }
    }
}
