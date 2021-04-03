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
    public partial class Windows_Form_Controls : Form
    {
        public Windows_Form_Controls()
        {
            InitializeComponent();
        }

        private void btn_Show_Result_Click(object sender, EventArgs e)
        {
            string Result = "";

            if (chk_Q_Heal.Checked)
            {
                Panel_Q_Heal.Visible = true;
            }
            if(chk_D_Mart.Checked)
            {
                panel_D_Mart.Visible = true;
            }
            if(chkb_Twitter.Checked)
            {
                panel_Twitter.Visible = true;
            }

            Result= txt_Name.Text;
            Result += " Having Hobbies ";

            int cnt = 0;
            for(cnt = 0; cnt < chkbl_Hobbies.Items.Count; cnt++)
            {
                if (chkbl_Hobbies.GetItemChecked(cnt))
                {
                    if (Result != "")
                    {
                        Result += chkbl_Hobbies.Items[cnt].ToString();
                    }
                }     
            }
            /*
            foreach(var item in chkbl_Hobbies.CheckedItems)
            {
                Result = Result + item.ToString();
                Result = Result + " ";
            }*/
            Result = Result +  ".";
            txt_Result.Text = Result;           
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            chk_Q_Heal.Checked = false;
            panel_D_Mart.Visible = false;
            panel_Twitter.Visible = false;
            Panel_Q_Heal.Visible = false;
            chk_D_Mart.Checked = false;
            chkb_Twitter.Checked = false;
            txt_Result.Clear();
            txt_Name.Focus();

            int i = 0;
            for(i = 0; i < chkbl_Hobbies.Items.Count; i++)
            {
                chkbl_Hobbies.SetItemChecked(i,false);
            }
        }

        private void Windows_Form_Controls_Load(object sender, EventArgs e)
        {
            txt_Name.Focus();
        }
    }
}
