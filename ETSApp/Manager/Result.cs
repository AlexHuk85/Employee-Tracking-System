using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSApp.Manager
{
    //return true or false for handling
    //Dao return void = EnumResult
    //Dao return Data(int...) = Result<data>
    public enum EnumResult
    {
        Success,
        Fail
    }

    public class Result<T>
    {
        public EnumResult Status { get; set; }
        public T Data { get; set; }
    }
}
