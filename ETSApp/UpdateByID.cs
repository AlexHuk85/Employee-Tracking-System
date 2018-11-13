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
using ETSApp.Manager;
using ETSApp.Dao;
using ETSApp.Entity;

namespace ETSApp
{
    public partial class UpdateByID : Form
    {
        public UpdateByID()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtSearchID.Text);
            EmployeeManager manager = new EmployeeManager();
            Result<Employees> result = manager.SearchByID(ID);

            switch (result.Status)
            {
                case EnumResult.Success:
                    txtFirstName.Text = result.Data.FirstName;
                    txtLastName.Text = result.Data.LastName;
                    txtEmail.Text = result.Data.Email;
                    txtDOB.Text = result.Data.DOB.ToString("yyyy/MM/dd");
                    txtPhone.Text = result.Data.Phone;
                    lblID.Text = result.Data.EmpID.ToString();
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, try again.");
                    break;
            }
            txtSearchID.Clear();
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            string Email = txtSearchEmail.Text;
            EmployeeManager manager = new EmployeeManager();
            Result<Employees> result = manager.SearchByEmail(Email);

            switch (result.Status)
            {
                case EnumResult.Success:
                    txtFirstName.Text = result.Data.FirstName;
                    txtLastName.Text = result.Data.LastName;
                    txtEmail.Text = result.Data.Email;
                    txtDOB.Text = result.Data.DOB.ToString("yyyy / MM / dd");
                    txtPhone.Text = result.Data.Phone;
                    lblID.Text = result.Data.EmpID.ToString();
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, make sure email address is correct.");
                    break;
            }
            txtSearchEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //add new information
            Employees UpdateEmployee = new Employees();
            UpdateEmployee.EmpID = Convert.ToInt32(lblID.Text);
            UpdateEmployee.FirstName = txtFirstName.Text;
            UpdateEmployee.LastName = txtLastName.Text;
            UpdateEmployee.DOB = Convert.ToDateTime(txtDOB.Text);
            UpdateEmployee.Email = txtEmail.Text;
            UpdateEmployee.Phone = txtPhone.Text;

            //calling manager update method
            EmployeeManager manager = new EmployeeManager();
            EnumResult result = manager.Edit(UpdateEmployee);

            switch (result)
            {
                case EnumResult.Success:
                    MessageBox.Show("New detail added.");
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, try again.");
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dispaly warning to confirm before delete
            DialogResult dr = MessageBox.Show("Are you sure want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Employees Emp = new Employees();
                Emp.EmpID = int.Parse(lblID.Text);

                EmployeeManager manager = new EmployeeManager();
                EnumResult result = manager.Remove(Emp);

                switch (result)
                {
                    case EnumResult.Success:
                        MessageBox.Show("Delete success!");
                        break;
                    case EnumResult.Fail:
                        MessageBox.Show("Error, try again later");
                        break;

                }
            }
        }
    }
}
