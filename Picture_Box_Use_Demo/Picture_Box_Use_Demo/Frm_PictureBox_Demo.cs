using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Picture_Box_Use_Demo
{
    public partial class Frm_PictureBox_Demo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Assignment_Demo_Picture_Box_db;Integrated Security=True");

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
        public Frm_PictureBox_Demo()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            Con_Open();
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "Image Files(*.jpg; *.jpeg;) | *.jpg; *.jpeg;";

                if(OFD.ShowDialog() == DialogResult.OK)
                {
                    picture_Box_Image.Image = new Bitmap(OFD.FileName);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con_Close();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            Con_Open();
            try
            {
                ImageConverter IC = new ImageConverter();
                byte[] ImageArray= (byte[]) IC.ConvertTo(picture_Box_Image.Image,typeof(byte[]));

                SqlCommand cmd= new SqlCommand("Insert into Image_db (Image) Values (@image)",con);      //(@image is Parameter)
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = ImageArray;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Image Upload Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                picture_Box_Image.Image = null;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con_Close();
        }

        private void btn_Show_Image_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select (Image) from Image_db where Image_ID = " + txt_Show_Image.Text + "", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                byte[] img = new byte[0];
                img = (byte[])(dr["Image"]);
                MemoryStream ms = new MemoryStream(img);
                img = (byte[])(dr["Image"]);
                //pb_Show_Image.Image = new Bitmap(Convert.ToByte(ms));
                pb_Show_Image.Image = Image.FromStream(ms);
                MessageBox.Show("Image Show Successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Image ID","Please Valid Image ID",MessageBoxButtons.OK,MessageBoxIcon.Warning);         
            }
            txt_Show_Image.Clear();

            Con_Close();

           
           /*Con_Open();
           MemoryStream stream = new MemoryStream();
           SqlCommand cmd = new SqlCommand("Select (Image) from Image_db where Image_ID = " + txt_Show_Image.Text  + "", con);
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           sda.Fill(ds);
           
           if(ds.Tables[0].Rows.Count > 0)
           {
               MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
               pb_Show_Image.Image = Image.FromStream(ms);
               txt_Show_Image.Clear();
           }
           else
           {
               MessageBox.Show("Invalid Image ID...!!!");
               txt_Show_Image.Clear();
           }
           Con_Close();*/
           

        }
    }
}
