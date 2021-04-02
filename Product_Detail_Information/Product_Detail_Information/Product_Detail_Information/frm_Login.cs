using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Detail_Information
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true ;
            tb_Username.Focus();
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Product_Detail_Information_db;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select Count(*) From Login Where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'",con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                this.Hide();

                Add_Product_Detail_Information obj = new Add_Product_Detail_Information();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login And Password","Failure",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
