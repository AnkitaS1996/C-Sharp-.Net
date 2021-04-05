using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_Information
{
    public partial class Main_From : Form
    {
        
        public Main_From()
        {
            InitializeComponent();
        }
        private void Main_From_Load(object sender, EventArgs e)
        {

        }

        private void viewSingleEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Single_Employee obj = new Frm_View_Single_Employee();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Employee Form = new Add_Employee();
            Form.MdiParent = this;
            Form.WindowState = FormWindowState.Maximized;
            Form.Show();

        }

        private void addManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Manager_Mentor obj = new Frm_Add_Manager_Mentor();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add_Department obj = new Form_Add_Department();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateEmployeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Employee_Details obj = new Frm_Update_Employee_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void deleteEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Delete_Employee_Details obj = new Frm_Delete_Employee_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewAllEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_All_Employee_Details obj = new Frm_View_All_Employee_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
