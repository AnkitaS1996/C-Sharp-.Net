using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_String_Create
{
    public partial class Frm_Stud_Info : Form
    {
        public Frm_Stud_Info()
        {
            InitializeComponent();
        }

        private void Clear_Control()
        {
            txt_Name.Clear();
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            rb_Computer.Checked = false;
            rb_Electronics.Checked = false;
            rb_Electrical.Checked = false;
            rb_Civil.Checked = false;
            txt_Result.Clear();
            txt_Name.Focus();
        }
        private void btn_Show_Result_Click(object sender, EventArgs e)
        {
            string Result = "";
            if(rb_Male.Checked)
            {
                Result = txt_Name.Text + " is " + rb_Male.Text;

                if(rb_Computer.Checked)
                {
                    Result = Result + ", He is From " + rb_Computer.Text + " Department.";
                }
                if(rb_Electronics.Checked)
                {
                    Result = Result + ", He is From " + rb_Electronics.Text + " Department.";
                }
                if(rb_Electrical.Checked)
                {
                    Result = Result + ", He is From " + rb_Electrical.Text + " Depatrmnt.";
                }
                if (rb_Civil.Checked)
                {
                    Result = Result + ", He is From " + rb_Civil.Text + " Depatrmnt.";
                }
            }
            else if(rb_Female.Checked)
            {
                Result = txt_Name.Text + " is " + rb_Female.Text;
                if(rb_Computer.Checked)
                { 
                    Result = Result + ", She is From " + rb_Computer.Text + " Department."; 
                }
                if(rb_Electronics.Checked)
                {
                    Result = Result + ", She is From " + rb_Electronics.Text + " Department.";
                }
                if(rb_Electrical.Checked)
                {
                    Result = Result + ", She is From " + rb_Electrical.Text + " Department.";
                }
                if (rb_Civil.Checked)
                {
                    Result = Result + ", She is From " + rb_Civil.Text + " Depatrmnt.";
                }
            }
            else
            {
                MessageBox.Show("Please Select Gender...!!!!!","Success",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            txt_Result.Text = Result;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windows_Form_Controls frm = new Windows_Form_Controls();
            frm.Show();
        }
    }
}
