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
    public partial class frm_View_Emp_Details : Form
    {
        public frm_View_Emp_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Emp_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet3.Employee_Detail_Add' table. You can move, or remove it, as needed.
            this.employee_Detail_AddTableAdapter2.Fill(this.employee_Management_System_DBDataSet3.Employee_Detail_Add);
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet2.Employee_Detail_Add' table. You can move, or remove it, as needed.
            //this.employee_Detail_AddTableAdapter1.Fill(this.employee_Management_System_DBDataSet2.Employee_Detail_Add);
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet1.Employee_Detail_Add' table. You can move, or remove it, as needed.
            //this.employee_Detail_AddTableAdapter.Fill(this.employee_Management_System_DBDataSet1.Employee_Detail_Add);
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet.Employee_Detail' table. You can move, or remove it, as needed.
            //this.employee_DetailTableAdapter.Fill(this.employee_Management_System_DBDataSet.Employee_Detail);

        }

        private void dgv_Emp_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
