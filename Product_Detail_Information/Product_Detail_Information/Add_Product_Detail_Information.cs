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
    public partial class Add_Product_Detail_Information : Form
    {
        public Add_Product_Detail_Information()
        {
            InitializeComponent();
        }
        public void Clear_Control()
        {
            tb_P_ID.Text = "";
            tb_P_Name.Text = "";
            tb_P_P_Price.Text = "";
            tb_P_S_Price.Text = "";
            tb_P_Stock.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Product_Detail_Information_db;Integrated Security=True");
             
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (tb_P_ID.Text != "" && tb_P_Name.Text != "" && tb_P_P_Price.Text != "" && tb_P_S_Price.Text != "" && tb_P_Stock.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(" Insert Into Product_Add Values (" + tb_P_ID.Text + ", '" + tb_P_Name.Text + "'," + tb_P_P_Price.Text + ", " + tb_P_S_Price.Text + ", " + tb_P_Stock.Text + ")", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
                
            }
            else
            {
                MessageBox.Show("1st Fill All The Fileld", "Fill The Data Completely", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
                
            
        }

        private void btn_View_All_Product_Click(object sender, EventArgs e)
        {
            View_Product_Detail obj = new View_Product_Detail();
            obj.Show();

            this.Hide();
            tb_P_ID.Focus();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_Login obj = new frm_Login();

            obj.Show();

        }

        private void Add_Product_Detail_Information_Load(object sender, EventArgs e)
        {
            tb_P_ID.Focus();
        }

        private void btn_Go_Back_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        
    }
}