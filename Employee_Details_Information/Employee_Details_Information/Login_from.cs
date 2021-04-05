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
using System.Data.SqlClient;


namespace Employee_Details_Information
{
    public partial class Login_from : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Assignment5_Emplaoyee_Management_System_db;Integrated Security=True");
        void Con_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void Con_Close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        

    public Login_from()
        {
            InitializeComponent();
        }

        private void Login_from_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
            txt_Username.Enabled = true;
            btn_Exit.Enabled = true;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Password.Enabled = true;
        }


        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select ID From Login_db where Username = '" + txt_Username.Text + "' And Password = '" + txt_Password.Text + "'", con);
            Con_Open();

            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //Add_Employee obj = new Add_Employee();
                Main_From obj = new Main_From();
                obj.Show();
              
            }
            else
            {
                MessageBox.Show("Invalid Login And Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear_Control();
            cmd.Dispose();
            Con_Close();

        }

        private void Clear_Control()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Password.Enabled = false;
            btn_Save.Enabled = false;
            txt_Username.Focus();
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Save.Focus();
            }
        }

       
    }
}
