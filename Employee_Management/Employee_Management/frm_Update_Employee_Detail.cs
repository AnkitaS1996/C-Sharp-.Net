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
    public partial class frm_Update_Employee_Detail : Form
    {
        string Qualification = "", Symbol = " ", Lang = "", Gender = "";
        bool bRet = false;

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
        public frm_Update_Employee_Detail()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_MobNo.Clear();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            dtp_DOB.Text = "";
            cmb_City.Text = "";
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
            tb_ID.Enabled = true;
            tb_ID.Focus();
        }

        

        private void btn_Update_Emp_Search_Click(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Detail_Add WHERE ID = " + tb_ID.Text + "", con);

            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                MessageBox.Show("Search Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                tb_MobNo.Text = (Obj["MobNo"].ToString());
                dtp_DOB.Text = (Obj["DOB"].ToString());
                cmb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));
                Gender = Obj.GetString(Obj.GetOrdinal("Gender"));
                Qualification = Obj.GetString(Obj.GetOrdinal("Qualification"));
                Lang = Obj.GetString(Obj.GetOrdinal("KnownLanguage"));

                bRet = Gender.Contains("Male");
                if (bRet)
                {
                    rbtn_Male.Checked = true;
                }

                bRet = Gender.Contains("Female");
                if (bRet)
                {
                    rbtn_Female.Checked = true;
                }

                bRet = Qualification.Contains("BCS");
                if (bRet)
                {
                    cb_BCS.Checked = true;
                }

                bRet = Qualification.Contains("BCA");
                if (bRet)
                {
                    cb_BCA.Checked = true;
                }

                bRet = Qualification.Contains("BSC");
                if (bRet)
                {
                    cb_BSC.Checked = true;
                }

                bRet = Qualification.Contains("MSC");
                if (bRet)
                {
                    cb_MSC.Checked = true;
                }

                bRet = Qualification.Contains("MScs");
                if (bRet)
                {
                    cb_MScs.Checked = true;
                }

                bRet = Qualification.Contains("Engg");
                if (bRet)
                {
                    cb_Engg.Checked = true;
                }

                bRet = Lang.Contains("C");
                if (bRet)
                {
                    cb_C.Checked = true;
                }

                bRet = Lang.Contains("C++");
                if (bRet)
                {
                    cb_Cpp.Checked = true;
                }

                bRet = Lang.Contains("Java");
                if (bRet)
                {
                    cb_Java.Checked = true;
                }

                bRet = Lang.Contains("Python");
                if (bRet)
                {
                    cb_Python.Checked = true;
                }

                bRet = Lang.Contains("C#");
                if (bRet)
                {
                    cb_CSharp.Checked = true;
                }

                bRet = Lang.Contains("VB.Net");
                if (bRet)
                {
                    cb_Vb_Net.Checked = true;
                }
               

            }
            else
            {
                MessageBox.Show("Invalid Id...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ID.Enabled = true;
                tb_ID.Clear();
                tb_ID.Focus();
            }
            btn_Update.Enabled = true;
            tb_Name.Focus();
            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (rbtn_Male.Checked)
            {
                Gender = "Male";
            }

            if (rbtn_Female.Checked)
            {
                Gender = "Female";
            }

            if (cb_BCS.Checked)
            {
                Qualification += "BCS" + Symbol;
            }

            if (cb_BCA.Checked)
            {
                Qualification += "BCA" + Symbol;
            }

            if (cb_BSC.Checked)
            {
                Qualification += "BSC" + Symbol;
            }

            if (cb_MSC.Checked)
            {
                Qualification += "MSC"+ Symbol;
            }

            if (cb_MScs.Checked)
            {
                Qualification += "MScs" + Symbol;
            }

            if (cb_Engg.Checked)
            {
                Qualification += "Engg" + Symbol;
            }

            if (cb_C.Checked)
            {
                Lang += "C" + Symbol;
            }

            if (cb_Cpp.Checked)
            {
                Lang += "C++" + Symbol;
            }

            if (cb_Java.Checked)
            {
                Lang += "Java" + Symbol;
            }

            if (cb_Python.Checked)
            {
                Lang += "Python" + Symbol;
            }

            if (cb_CSharp.Checked)
            {
                Lang += "C#" + Symbol;
            }

            if (cb_Vb_Net.Checked)
            {
                Lang += "VB.Net" + Symbol;
            }

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_MobNo.Text != "" && Gender != "" && cmb_City.Text != "" && Qualification != "" && Lang != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Employee_Detail_Add SET Name = '" + tb_Name.Text + "',MobNo = " + tb_MobNo.Text + ",Gender = '" + Gender + "',DOB = '" + dtp_DOB.Text + "',City = '" + cmb_City.Text + "',Qualification = '" + Qualification + "',KnownLanguage = '" + Lang + "' WHERE ID = " + tb_ID.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Update Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("1st Fill All the Fields...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }
    }
}
