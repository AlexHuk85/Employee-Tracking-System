using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using ETSApp.Entity;
using ETSApp.Dao;
using ETSApp.Manager;

namespace ETSApp
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Employees Emp = new Employees();
            Emp.FirstName = txtfirstname.Text;
            Emp.LastName = txtlastname.Text;
            Emp.Email = txtemail.Text;
            Emp.DOB = DateTime.Parse(txtdob.Text);
            Emp.Phone = txtphone.Text;
            //EmployeeDao Dao = new EmployeeDao();

            //testing, calling Dao.Insert without manager
            //try
            //{
            //    Dao.InsertEmployee(Emp);
            //    MessageBox.Show("Added");
            //}
            //catch (Exception EX)
            //{

            //    Console.WriteLine("Error" + EX.Message);
            //}

            //testing, manager select all
            //EmployeeManager Manager = new EmployeeManager();
            //EnumResult Result = Manager.FindEmployees(Emp);

            

        }
    }
}
