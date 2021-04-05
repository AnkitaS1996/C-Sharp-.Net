using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_Information
{
    public partial class Frm_View_All_Employee_Details : Form
    {
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Frm_View_All_Employee_Details()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Employee_Details_Load(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Assignment5_Add_Employee_db",GVObj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_View_Data.DataSource = dt;
            GVObj.Con_Close();
        }

        
    }
}
