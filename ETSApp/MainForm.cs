using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETSApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
        }

        private void updateEmployeeDeatilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDelete ud = new UpdateDelete();
            ud.ShowDialog();
        }

        private void updateAndDeleteByIDOrEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateByID ui = new UpdateByID();
            ui.ShowDialog();
        }

        private void addDateAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDateHours ad = new AddDateHours();
            ad.ShowDialog();
        }

        private void showEmployeesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact ct = new Contact();
            ct.ShowDialog();
        }
    }
}
