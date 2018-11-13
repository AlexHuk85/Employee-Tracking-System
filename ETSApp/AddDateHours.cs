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
    public partial class AddDateHours : Form
    {
        public AddDateHours()
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
                    
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, try again.");
                    break;
            }
        }

        private void AddDateHours_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read selected name and display detail
            Employees SelectedName = (Employees)listBox.SelectedItem;

            txtFirstName.Text = SelectedName.FirstName;
            txtLastName.Text = SelectedName.LastName;
            
            lblID.Text = SelectedName.EmpID.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //create Hours object
            Hours Hrs = new Hours();
            //input
            Hrs.EmpID = int.Parse(lblID.Text);
            Hrs.WorkDate = Convert.ToDateTime(txtDate.Text);
            Hrs.WorkHours = decimal.Parse(txtHours.Text);

            // calling manager
            WorkHoursManager manager = new WorkHoursManager();
            EnumResult result = manager.Add(Hrs);

            switch (result)
            {
                case EnumResult.Success:
                    MessageBox.Show("Work date and hour added.");
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, Try again.");
                    break;

            }
            txtDate.Clear();
            txtHours.Clear();
        }
    }
}
