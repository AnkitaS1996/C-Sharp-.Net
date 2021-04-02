namespace Employee_Details_Information
{
    partial class Main_From
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
            this.components = new System.ComponentModel.Container();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSingleEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.viewEmployeeToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1249, 46);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeDetailToolStripMenuItem,
            this.deleteEmployeeDetailsToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(440, 42);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee Details";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeDetailToolStripMenuItem
            // 
            this.updateEmployeeDetailToolStripMenuItem.Name = "updateEmployeeDetailToolStripMenuItem";
            this.updateEmployeeDetailToolStripMenuItem.Size = new System.Drawing.Size(440, 42);
            this.updateEmployeeDetailToolStripMenuItem.Text = "Update Employee Detail";
            this.updateEmployeeDetailToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeDetailToolStripMenuItem_Click);
            // 
            // deleteEmployeeDetailsToolStripMenuItem
            // 
            this.deleteEmployeeDetailsToolStripMenuItem.Name = "deleteEmployeeDetailsToolStripMenuItem";
            this.deleteEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(440, 42);
            this.deleteEmployeeDetailsToolStripMenuItem.Text = "Delete Employee  Details";
            this.deleteEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSingleEmployeeDetailsToolStripMenuItem,
            this.viewAllEmployeeDetailsToolStripMenuItem});
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(232, 42);
            this.viewEmployeeToolStripMenuItem.Text = "View Employee";
            // 
            // viewSingleEmployeeDetailsToolStripMenuItem
            // 
            this.viewSingleEmployeeDetailsToolStripMenuItem.Name = "viewSingleEmployeeDetailsToolStripMenuItem";
            this.viewSingleEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.viewSingleEmployeeDetailsToolStripMenuItem.Text = "View Single Employee ";
            this.viewSingleEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewSingleEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewAllEmployeeDetailsToolStripMenuItem
            // 
            this.viewAllEmployeeDetailsToolStripMenuItem.Name = "viewAllEmployeeDetailsToolStripMenuItem";
            this.viewAllEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.viewAllEmployeeDetailsToolStripMenuItem.Text = "View All Employee ";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem,
            this.addManagerToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(273, 42);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(390, 42);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // addManagerToolStripMenuItem
            // 
            this.addManagerToolStripMenuItem.Name = "addManagerToolStripMenuItem";
            this.addManagerToolStripMenuItem.Size = new System.Drawing.Size(390, 42);
            this.addManagerToolStripMenuItem.Text = "Add Manager Mentor";
            this.addManagerToolStripMenuItem.Click += new System.EventHandler(this.addManagerToolStripMenuItem_Click);
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1249, 770);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main From";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_From_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSingleEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addManagerToolStripMenuItem;
    }
}



