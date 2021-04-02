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

namespace Employee_Details_Information
{
    public partial class Form_Add_Department : Form
    {
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Form_Add_Department()
        {
            InitializeComponent();
        }

        private void Clear_Control()
        {
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Department", "Select Max(ID) from Assignment5_Add_Department", 101));
            txt_Name.Clear();
        }

        private void Form_Add_Department_Load(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(ID) from Assignment5_Add_Department", "Select Max(ID) from Assignment5_Add_Department",101));
            txt_ID.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                GVObj.Con_Open();
                if(txt_Name.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Assignment5_Add_Department Values(" + txt_ID.Text + " , '" + txt_Name.Text + "')", GVObj.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //GVObj.FillTableDB("Insert into Assignment5_Add_Department Values(" + txt_ID.Text + " , '" + txt_Name.Text + "')");
                    MessageBox.Show("Record Save Successfully..!!! ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Clear_Control();
                }
                else
                {
                    MessageBox.Show("First Fill All the Field ...!!!", "Failure", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
