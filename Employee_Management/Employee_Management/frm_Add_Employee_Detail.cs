using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management
{
    public partial class frm_Add_Employee_Detail : Form
    {
        string Gender = "";
        string Qualification = "", Lang = "", Symbol = " ";
       

        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        void Con_Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void Clear_Data()
        {
            
            tb_Add_Emp_Name.Clear();
            tb_Add_Emp_MobNo.Clear();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            dtp_Add_Emp_DOB.Text = "";
            cmb_Add_Emp_City.Text = "";
            cb_BCA.Checked = false;
            cb_BCS.Checked = false;
            cb_BSC.Checked = false;
            cb_C.Checked = false;
            cb_Cpp.Checked = false;
            cb_CSharp.Checked = false;
            cb_Engg.Checked = false;
            cb_Java.Checked = false;
            cb_MSC.Checked = false;
            cb_MScs.Checked = false;
            cb_Python.Checked = false;
            cb_Vb_Net.Checked = false;
            tb_Add_Emp_Name.Focus();
        }

        int Auto_Increment()
        {
            int iCnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(ID) FROM Employee_Detail_Add ", con);

            iCnt = Convert.ToInt32(cmd.ExecuteScalar());

            iCnt = 1001 + iCnt;

            Con_Close();

            return iCnt;
        }
        public frm_Add_Employee_Detail()
        {
            InitializeComponent();
        }

        private void cb_BCS_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_BCS.CheckState == CheckState.Checked)
            {
                Qualification += "BCS" + Symbol;
            }
        }

        private void cb_BCA_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_BCA.CheckState == CheckState.Checked)
            {
                Qualification += Symbol + "BCA";
            }
        }

        private void cb_BSC_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_BSC.CheckState == CheckState.Checked)
            {
                Qualification += Symbol + "BSC";
            }
        }

        private void cb_MSC_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MSC.CheckState == CheckState.Checked)
            {
                Qualification += Symbol +  "MSC";
            }
        }

        private void cb_MScs_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MScs.CheckState == CheckState.Checked)
            {
                Qualification += Symbol + "MScs";
            }
        }

        private void cb_Engg_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Engg.CheckState == CheckState.Checked)
            {
                Qualification += Symbol + "Engg";
            }
        }

        private void cb_C_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_C.CheckState == CheckState.Checked)
            {
                Lang += "C" + Symbol;
            }
        }

        private void cb_Cpp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Cpp.CheckState == CheckState.Checked)
            {
                Lang += Symbol + "C++";
            }
        }

        private void cb_Java_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Java.CheckState == CheckState.Checked)
            {
                Lang += Symbol + "Java";
            }
        }

        private void cb_Python_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Python.CheckState == CheckState.Checked)
            {
                Lang += Symbol + "Python";
            }
        }

        private void cb_CSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_CSharp.CheckState == CheckState.Checked)
            {
                Lang += Symbol + "C#";
            }
        }

        private void cb_Vb_Net_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Vb_Net.CheckState == CheckState.Checked)
            {
                Lang += Symbol + "VB.Net";
            }
        }


        private void frm_Add_Employee_Detail_Load(object sender, EventArgs e)
        {
            tb_Add_Emp_ID.Text = Convert.ToString(Auto_Increment());
            tb_Add_Emp_Name.Focus();
        }

        private void IsNumeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tb_Add_Emp_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtn_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_Add_Emp_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Add_Emp_ID.Text != "" && tb_Add_Emp_Name.Text != "" && tb_Add_Emp_MobNo.Text != "" && cmb_Add_Emp_City.Text != "" && (rbtn_Male.Checked || rbtn_Female.Checked) && (cb_BCS.Checked || cb_BCA.Checked || cb_BSC.Checked || cb_MSC.Checked || cb_MScs.Checked || cb_Engg.Checked) && (cb_C.Checked || cb_Cpp.Checked || cb_Java.Checked || cb_Python.Checked || cb_CSharp.Checked || cb_Vb_Net.Checked))
            {
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Employee_Detail_Add VALUES(" + tb_Add_Emp_ID.Text + ",'" + tb_Add_Emp_Name.Text + "'," + tb_Add_Emp_MobNo.Text + ",'" + Gender + "','" + dtp_Add_Emp_DOB.Text + "','" + cmb_Add_Emp_City.Text + "','" + Qualification  + "','" + Lang  + "')", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("Saved Information Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Data();
                tb_Add_Emp_ID.Text = Convert.ToString(Auto_Increment());
            }
            else
            {
                MessageBox.Show("1st Fill All Information", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
           
        }

    }
}
