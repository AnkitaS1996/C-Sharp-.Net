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

namespace Tab_Control_Assignment
{
    public partial class Frm_Login : Form
    {
        Global_Function_Variable_Code_Class GVObj = new Global_Function_Variable_Code_Class();
        
        public Frm_Login()
        {
            InitializeComponent();
        }
        string AdminKey = "";
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //string AdminKey = "";
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select * From Add_User_Login_db where ID = 1", GVObj.con);
            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                AdminKey = Obj.GetString(Obj.GetOrdinal("Admin_Key"));
            }
            cmd.Dispose();
            GVObj.Con_Close();
        }
        public void Clear_Control_Of_Add_New_User()
        {
            txt_Add_UName.Clear();
            txt_Add_Admin_Hint.Clear();
            txt_Add_Password.Clear();
            txt_Add_Confirm_Pass.Clear();
            lbl_Add_Admin_Key_Error.Visible = false;
            lbl_Add_Confirm_Pass_Error.Visible = false;
            lbl_Add_Invalid_Or_Valid.Visible = false;
            btn_Submit.Enabled = false;
            chkb_Add_Confirm_Show_Password.Checked = false;
            chkb_Add_Show_Key.Checked = false;
            chkb_Add_Show_Pass.Checked = false;    
        }
        public void Clear_Control_Forgot_Password()
        {
            txt_Forgot_User_Name.Clear();
            txt_Forgot_Admin_Key.Clear();
            txt_Forgot_New_Pass.Clear();
            txt_Forgot_New_Pass.Enabled = false;
            txt_Forgot_Confirm_Pass.Clear();
            txt_Forgot_Confirm_Pass.Enabled = false;
            lbl_Forgot_Admin_Key_Error.Visible = false;
            lbl_Forgot_Username_Error.Visible = false;
            lbl_Forgot_Password_Error.Visible = false;
            chkb_Forgot_Show_Key.Checked = false;
            chkb_Forgot_Confirm_Pass_Show.Checked = false;
            chkb_Forgot_New_Show_Password.Checked = false;
        }

        private void chkb_Login_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Login_Show_Pass.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void chkb_Add_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Add_Show_Pass.Checked)
            {
                txt_Add_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Add_Password.PasswordChar = '*';
            }
        }

        private void chkb_Add_Confirm_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Add_Confirm_Show_Password.Checked)
            {
                txt_Add_Confirm_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Add_Confirm_Pass.PasswordChar = '*';
            }

        }

        private void chkb_Add_Show_Key_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Add_Show_Key.Checked)
            {
                txt_Add_Admin_Hint.PasswordChar = '\0';
            }
            else
            {
                txt_Add_Admin_Hint.PasswordChar = '$';
            }
        }

        private void chkb_Forgot_New_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Forgot_New_Show_Password.Checked)
            {
                txt_Forgot_New_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Forgot_New_Pass.PasswordChar = '*';
            }
        }

        private void chkb_Forgot_Show_Key_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Forgot_Show_Key.Checked)
            {
                txt_Forgot_Admin_Key.PasswordChar = '\0';
            }
            else
            {
                txt_Forgot_Admin_Key.PasswordChar = '$';
            }
        }

        private void chkb_Forgot_Confirm_Pass_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_Forgot_Confirm_Pass_Show.Checked)
            {
                txt_Forgot_Confirm_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Forgot_Confirm_Pass.PasswordChar = '*';
            }
        }
        private void tabPage_Add_New_User_Click(object sender, EventArgs e)
        {
            txt_Add_UName.Focus();
            Clear_Control_Of_Add_New_User();
        }

        private void tab_Page_Forgot_Password_Click(object sender, EventArgs e)
        {
            txt_Forgot_User_Name.Focus();
            Clear_Control_Forgot_Password();
        }

        private void txt_Forgot_User_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Forgot_Username_Error.Visible = false;
        }

        private void txt_Forgot_Admin_Key_TextChanged(object sender, EventArgs e)
        {
            lbl_Forgot_Admin_Key_Error.Visible = false;
        }

        private void tabPage_Login_Click(object sender, EventArgs e)
        {
            txt_Username.Focus();
            txt_Username.Enabled = true;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Password.Enabled = true;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void txt_Forgot_User_Name_Leave(object sender, EventArgs e)
        {
            string Forgot_UName = "";
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Username From Add_User_Login_db where Username = '" + txt_Username.Text + "'",GVObj.con);
            var Obj = cmd.ExecuteReader();
            if(Obj.Read())
            {
                Forgot_UName = Obj.GetString(Obj.GetOrdinal("Username"));
            }
            cmd.Dispose();
            GVObj.Con_Close();

            if(txt_Forgot_User_Name.Text == Forgot_UName)
            {
                lbl_Forgot_Username_Error.Visible = true;
                lbl_Forgot_Username_Error.Text = "Matched Username";
                lbl_Forgot_Username_Error.ForeColor = Color.Green;
                txt_Forgot_New_Pass.Enabled = true;
                txt_Forgot_Confirm_Pass.Enabled = true;
            }
            else
            {
                lbl_Forgot_Username_Error.Visible = true;
                lbl_Forgot_Username_Error.Text = "UnMatched Username";
                lbl_Forgot_Username_Error.ForeColor = Color.Red;
                txt_Forgot_User_Name.Focus();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select (ID) From Add_User_Login_db where Username = '" + txt_Username.Text + "' AND Password = '" + txt_Password.Text + "'", GVObj.con);
            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login successfully....!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Matched Username Or Password....!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            chkb_Login_Show_Pass.Checked = false;
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Username.Focus();
            txt_Password.Enabled = false;
            txt_Username.Enabled = false;
        }

        private void txt_Add_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {
            if(txt_Add_Password.Text == txt_Add_Confirm_Pass.Text)
            {
                lbl_Add_Confirm_Pass_Error.Visible = true;
                lbl_Add_Confirm_Pass_Error.Text = "Matched Confirm Password";
                lbl_Add_Confirm_Pass_Error.ForeColor = Color.Green;
                txt_Add_Admin_Hint.Enabled = true;
            }
            else
            {
                lbl_Add_Confirm_Pass_Error.Visible = false;
                lbl_Add_Confirm_Pass_Error.Text = "Invalid Confirm Password";
                lbl_Add_Confirm_Pass_Error.ForeColor = Color.Red;
            }
        }

        private void txt_Add_Admin_Hint_TextChanged(object sender, EventArgs e)
        {
            if (AdminKey == txt_Add_Admin_Hint.Text)
            {
                lbl_Add_Admin_Key_Error.Visible = true;
                lbl_Add_Admin_Key_Error.Text = "Matched Admin Key";
                lbl_Add_Admin_Key_Error.ForeColor = Color.Green;
                btn_Add_User_Submit.Enabled = true;
            }
            else
            {
                lbl_Add_Admin_Key_Error.Visible = true;
                lbl_Add_Admin_Key_Error.Text = "Invalid Admin Key";
                lbl_Add_Admin_Key_Error.ForeColor = Color.Red;
            }
        }

        private void btn_Add_User_Submit_Click(object sender, EventArgs e)
        {
            string UserKey = "";

            string CurrentYear = DateTime.Now.Year.ToString();
            UserKey = txt_Add_UName.Text + "_" + CurrentYear;

            GVObj.Con_Open();

            if(txt_Add_UName.Text != "" && txt_Add_Password.Text != "" && txt_Add_Confirm_Pass.Text != "" && txt_Add_Admin_Hint.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Add_User_Login_db Values('" + txt_Add_UName.Text + "','" + txt_Add_Confirm_Pass.Text + "','" + UserKey + "')",GVObj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Add New User Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear_Control_Of_Add_New_User();
                UserKey = "";
                sda.Dispose();
                dt.Dispose();
                GVObj.Con_Close();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields...!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
