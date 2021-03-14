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
    public partial class frm_Emp_Login : Form
    {
        public frm_Emp_Login()
        {
            InitializeComponent();
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            lbl_ERROR.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Sumit.Enabled = true;
        }

        private void btn_Sumit_Click(object sender, EventArgs e)
        {

           
            if (tb_UserName.Text == "Admin" && tb_Password.Text == "a")
            {
                Global_Varible.UName = "Welcome " + tb_UserName.Text;
                MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MDI_frm_Employee_Management MDIObj = new MDI_frm_Employee_Management();
                MDIObj.Show();
                this.Hide();
            }
            else
            {
                //lbl_ERROR.Visible = true;
                lbl_ERROR.Text = "InValid UserName && Password";
            }

            tb_UserName.Text = "";
            tb_Password.Text = "";
            tb_UserName.Focus();
        }
    }
}
