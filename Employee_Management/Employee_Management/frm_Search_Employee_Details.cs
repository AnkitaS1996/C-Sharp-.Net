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
    public partial class frm_Search_Employee_Details : Form
    {
        string Qualification = "", Gender = "", Lang = "";
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

        public frm_Search_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Search_Emp_Search_Click(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Detail_Add WHERE ID = " + tb_ID.Text + "",con);

            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                MessageBox.Show("Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                tb_MobNo.Text = (Obj["MobNo"].ToString());
                tb_DOB.Text = (Obj["DOB"].ToString());
                tb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));
                Gender = Obj.GetString(Obj.GetOrdinal("Gender"));
                Qualification = Obj.GetString(Obj.GetOrdinal("Qualification"));
                Lang = Obj.GetString(Obj.GetOrdinal("KnownLanguage"));

                bRet = Gender.Contains("Male");
                if (bRet)
                {
                    rbtn_Search_Male.Checked = true;  
                }

                bRet = Gender.Contains("Female");
                if (bRet)
                {
                    rbtn_Search_Female.Checked = true;
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

                Qualification = "";
                Lang = "";
                Gender = "";
            }
            else
            {
                MessageBox.Show("Invalid Id...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ID.Enabled = true;
                tb_ID.Clear();
                tb_ID.Focus();
            }

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_MobNo.Clear();
            
            tb_DOB.Clear();
            tb_City.Clear();
            
            tb_ID.Enabled = true;
            tb_ID.Focus();
        }
    }
}
