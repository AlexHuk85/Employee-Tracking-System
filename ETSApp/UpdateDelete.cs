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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        public void reload()
        {
            EmployeeManager manager = new EmployeeManager();
            Result<List<Employees>> result = manager.ShowEmployees();

            switch (result.Status)
            {
                case EnumResult.Success:
                    listBox.DataSource = result.Data;

                    listBox.DisplayMember = "FirstName";
                    lblTotal.Text = "Total: " + result.Data.Count();
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, try again.");
                    break;
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            //EmployeeManager manager = new EmployeeManager();
            //Result<List<Employees>> result = manager.ShowEmployees();

            //switch (result.Status)
            //{
            //    case EnumResult.Success:
            //        listBox.DataSource = result.Data;

            //        listBox.DisplayMember = "FirstName";
            //        lblTotal.Text = "Total: " + result.Data.Count();
            //        break;
            //    case EnumResult.Fail:
            //        MessageBox.Show("Error, try again.");
            //        break;
            //}
            reload();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read selected name and display detail
            Employees SelectedName = (Employees)listBox.SelectedItem;

            txtFirstName.Text = SelectedName.FirstName;
            txtLastName.Text = SelectedName.LastName;
            txtDOB.Text = SelectedName.DOB.ToString("yyyy/MM/dd");
            txtEmail.Text = SelectedName.Email;
            txtPhone.Text = SelectedName.Phone;
            lblID.Text = SelectedName.EmpID.ToString();
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
