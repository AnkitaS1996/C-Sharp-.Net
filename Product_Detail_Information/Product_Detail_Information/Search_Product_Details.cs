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
    public partial class Search_Product_Details : Form
    {
        public Search_Product_Details()
        {
            InitializeComponent();
        }

        private void Search_Product_Details_Load(object sender, EventArgs e)
        {
            tb_P_ID.Focus();
        }
       

        private void btn_Search_Click(object sender, EventArgs e) 
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Product_Detail_Information_db;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Product_Add where Product_ID = " + tb_P_ID.Text + "",con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            var obj = cmd.ExecuteReader();

            if(obj.Read())
            {
                tb_P_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                tb_P_S_Price.Text = (obj["Product_Sales_Price"].ToString());
                tb_P_P_Price.Text = (obj["Product_Purchase_Price"].ToString());
                tb_P_Stock.Text = (obj["Product_Stock"].ToString());
                tb_P_ID.Enabled = false;

                MessageBox.Show("Search Details Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Invalid Product ID","Failure", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                tb_P_ID.Focus();
            }
            con.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clear_control();
            tb_P_ID.Enabled = true;
            tb_P_ID.Focus();
        }

        private void clear_control()
        {
 	        tb_P_ID.Text = "";
            tb_P_Name.Text = "";
            tb_P_P_Price.Text = "";
            tb_P_S_Price.Text = "";
            tb_P_Stock.Text = "";
        }

        private void btn_Delete_Form_Click(object sender, EventArgs e)
        {
            Delete_Product_Details obj = new Delete_Product_Details();

            obj.Show();

            this.Hide();
        }

        private void btn_Go_Back_Click(object sender, EventArgs e)
        {
            View_Product_Detail obj = new View_Product_Detail();
            obj.Show();
            this.Hide();
        }
    }
}
    