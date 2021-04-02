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
    public partial class Update_Product_Details : Form
    {
        public Update_Product_Details()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Update_Product_Details_Load(object sender, EventArgs e)
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
                tb_P_ID.Text = "";
                tb_P_ID.Focus();
            }
            con.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clear_control();

            tb_P_ID.Focus();

            tb_P_ID.Enabled = true;
        }

        private void clear_control()
        {
 	        tb_P_ID.Text = "";
            tb_P_Name.Text = "";
            tb_P_S_Price.Text = "";
            tb_P_P_Price.Text = "";
            tb_P_Stock.Text = "";
        }

        private void btn_Go_Back_Click(object sender, EventArgs e)
        {
            Delete_Product_Details obj = new Delete_Product_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Product_Detail_Information_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Update Product_Add Set Product_Name = '" + tb_P_Name.Text + "', Product_Sales_Price = " + tb_P_S_Price.Text + ", Product_Purchase_Price = " + tb_P_P_Price.Text + ", Product_Stock = " + tb_P_Stock.Text + " Where Product_ID = " + tb_P_ID.Text + "", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.ExecuteNonQuery();

            MessageBox.Show("Update Record Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlExpress;Initial Catalog=Product_Detail_Information_db;Integrated Security=True");
            con.Open();

            Form1 obj = new Form1();
            obj.showreport("Select * from Product_Add", con);
            obj.Show();

        }

       
    }
}
