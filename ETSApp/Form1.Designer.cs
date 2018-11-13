namespace ETSApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDateAndHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDeatilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAndDeleteByIDOrEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addDateAndHoursToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addDateAndHoursToolStripMenuItem
            // 
            this.addDateAndHoursToolStripMenuItem.Name = "addDateAndHoursToolStripMenuItem";
            this.addDateAndHoursToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addDateAndHoursToolStripMenuItem.Text = "Add Date and Hours";
            this.addDateAndHoursToolStripMenuItem.Click += new System.EventHandler(this.addDateAndHoursToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployeeDeatilToolStripMenuItem,
            this.updateAndDeleteByIDOrEmailToolStripMenuItem});
            this.manageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // updateEmployeeDeatilToolStripMenuItem
            // 
            this.updateEmployeeDeatilToolStripMenuItem.Name = "updateEmployeeDeatilToolStripMenuItem";
            this.updateEmployeeDeatilToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.updateEmployeeDeatilToolStripMenuItem.Text = "Update and Delete By Name";
            this.updateEmployeeDeatilToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeDeatilToolStripMenuItem_Click);
            // 
            // updateAndDeleteByIDOrEmailToolStripMenuItem
            // 
            this.updateAndDeleteByIDOrEmailToolStripMenuItem.Name = "updateAndDeleteByIDOrEmailToolStripMenuItem";
            this.updateAndDeleteByIDOrEmailToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.updateAndDeleteByIDOrEmailToolStripMenuItem.Text = "Update and Delete By ID or Email";
            this.updateAndDeleteByIDOrEmailToolStripMenuItem.Click += new System.EventHandler(this.updateAndDeleteByIDOrEmailToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEmployeesReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // showEmployeesReportToolStripMenuItem
            // 
            this.showEmployeesReportToolStripMenuItem.Name = "showEmployeesReportToolStripMenuItem";
            this.showEmployeesReportToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showEmployeesReportToolStripMenuItem.Text = "Show Employees Report";
            this.showEmployeesReportToolStripMenuItem.Click += new System.EventHandler(this.showEmployeesReportToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.contactToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Employee Tracking System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select function about to begin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracking System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDateAndHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDeatilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAndDeleteByIDOrEmailToolStripMenuItem;
    }
}

