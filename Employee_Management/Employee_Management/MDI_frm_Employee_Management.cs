using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class MDI_frm_Employee_Management : Form
    {
        private int childFormNumber = 0;

        public MDI_frm_Employee_Management()
        {
            InitializeComponent();
        }

        private void MDI_frm_Employee_Management_Load(object sender, EventArgs e)
        {
            lbl_Add_Emp_LoggedUser.Text = Global_Varible.UName;
        }


        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Detail AEObj = new frm_Add_Employee_Detail();

            AEObj.MdiParent = this;
            AEObj.WindowState = FormWindowState.Maximized;
            AEObj.Show();

        }

        private void btn_MDI_Emp_Logout_Click(object sender, EventArgs e)
        {
            frm_Emp_Login LObj = new frm_Emp_Login();
            LObj.Show();
            this.Hide();
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Emp_Details VObj = new frm_View_Emp_Details();

            VObj.MdiParent = this;
            VObj.WindowState = FormWindowState.Maximized;
            VObj.Show();

        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details SObj = new frm_Search_Employee_Details();

            SObj.MdiParent = this;
            SObj.WindowState = FormWindowState.Maximized;
            SObj.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_Update_Employee_Detail UObj = new frm_Update_Employee_Detail();

            UObj.MdiParent = this;
            UObj.WindowState = FormWindowState.Maximized;
            UObj.Show();
        }

       
        
    }
}
