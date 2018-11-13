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
using ETSApp.Manager;

namespace ETSApp
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //read input
            Employees Emp = new Employees();
            Emp.FirstName = txtFirstName.Text;
            Emp.LastName = txtLastName.Text;
            Emp.Email = txtEmail.Text;
            Emp.DOB = Convert.ToDateTime(txtDOB.Text);
            Emp.Phone = txtPhone.Text;

            //call manager
            EmployeeManager manager = new EmployeeManager();
            EnumResult result = manager.Add(Emp);

            //return
            switch (result)
            {
                case EnumResult.Success:
                    MessageBox.Show("New employee Added");
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, please double check the detail and try again.");
                    break;
            }
        }

    }
}
