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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        //this method will display selected employee
        public void DisplayEmployee()
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

        // this method will display selected employee work date
        public void DisplayDate()
        {
            WorkHoursManager manager = new WorkHoursManager();
            Result<List<Hours>> result = manager.DisplayByID(lblID.Text);

            switch (result.Status)
            {
                case EnumResult.Success:
                    listBox1.DataSource = result.Data;

                    listBox1.DisplayMember = "WorkDate";
                    lblDays.Text = "Total Days: " + result.Data.Count();
                    break;
                case EnumResult.Fail:
                    MessageBox.Show("Error, try again.");
                    break;

            }
        }


        //for display Total worked hours
        public void DisplayTotalHours()
        {
            WorkHoursManager manager = new WorkHoursManager();
            Result<decimal> result = manager.DisplayHours(lblID.Text);

            try
            {
                lblTotalHours.Text = result.Data.ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error");
            }

        }


        private void Report_Load(object sender, EventArgs e)
        {
            DisplayEmployee(); //run this method when page load
        }

        //employee list box, select and display
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display detail
            Employees Emp = (Employees)listBox.SelectedItem;
            lblID.Text = Emp.EmpID.ToString();
            lblFirstName.Text = Emp.FirstName;
            lblLastName.Text = Emp.LastName;
            lblEmail.Text = Emp.Email;

            DisplayDate();

            DisplayTotalHours();
        }

        //workdate list box, select and display
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hours Hrs = (Hours)listBox1.SelectedItem;
            lblSelectedDate.Text = Hrs.WorkDate.ToString("yyyy/MM/dd");
            lblHours.Text = Hrs.WorkHours.ToString();
        }
    }
}
