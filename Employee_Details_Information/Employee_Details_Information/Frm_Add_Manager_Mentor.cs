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
    public partial class Frm_Add_Manager_Mentor : Form
    {
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Frm_Add_Manager_Mentor()
        {
            InitializeComponent();
        }

        void Clear_Control()
        {
            //txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Manager_Mentor_db", "Select Max(ID) from Assignment5_Add_Manager_Mentor_db", 101));
            txt_Name.Clear();
            txt_M_No.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cmb_Department.SelectedIndex = -1;
            dtp_DOB.Text = "";
            dtp_Join_Date.Text = "";
            txt_Salary.Clear();
        }
        private void Frm_Add_Manager_Mentor_Load(object sender, EventArgs e)
        {
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Manager_Mentor_db", "Select Max(ID) from Assignment5_Add_Manager_Mentor_db", 101));
            GVObj.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Name from Assignment5_Add_Department", GVObj.con);
            var ExR = cmd.ExecuteReader();
            while (ExR.Read())
            {
                cmb_Department.Items.Add(ExR.GetString(ExR.GetOrdinal("Name")));
            }
            GVObj.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = "";

            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }
            else
            {
                Gender = rb_Female.Text;
            }
            GVObj.Con_Open();
            if (txt_ID.Text != "" && txt_Name.Text != "" && txt_M_No.Text != "" && (rb_Female.Checked || rb_Male.Checked) && cmb_Department.Text != "" && txt_Salary.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Assignment5_Add_Manager_Mentor_db Values (" + txt_ID.Text + ",'" + txt_Name.Text + "', " + txt_M_No.Text + ", '" + Gender + "','" + cmb_Department.Text + "','" + dtp_DOB.Text + "','" + dtp_Join_Date.Text + "'," + txt_Salary.Text + ") ", GVObj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Manager_Mentor_db", "Select Max(ID) from Assignment5_Add_Manager_Mentor_db", 101));
            }
            else
            {
                MessageBox.Show("First Fill All Field", "Fill Data Completely");
            }
            GVObj.Con_Close();


        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Manager_Mentor_db", "Select Max(ID) from Assignment5_Add_Manager_Mentor_db", 101));
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }

        private void txt_M_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_M_No.Focus();
            }
        }

        private void txt_M_No_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                rb_Male.Focus();
            }
        }

        private void rb_Male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Female.Focus();
            }
        }

        private void rb_Female_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Department.Focus();
            }
        }

        private void cmb_Department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Salary.Focus();
            }
        }
    }
}

