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
    public partial class Frm_View_Single_Employee : Form
    {
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Frm_View_Single_Employee()
        {
            InitializeComponent();
        }
        void Clear_Control()
        {
            txt_Emp_ID.Clear();
            txt_Name.Clear();
            txt_M_No.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            dtp_DOB.Text = "";
            txt_Other_Hobbiess.Clear();
            txt_Department.Clear();
            txt_M_Mentor.Clear();
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
            chkb_Tata.Checked = false;
            chkb_D_Mart.Checked = false;
            chkb_IPL.Checked = false;
            chkb_Reliance.Checked = false;
            txt_Designation.Clear();
            txt_Salary.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Project = "", Gender = "", Shift_Time = "";
            bool bRet = false;

            //SqlConnection Connection 
            GVObj.Con_Open();

            //Search Code
            SqlCommand cmd = new SqlCommand("Select * From Assignment5_Add_Employee_db where Employee_ID = " + txt_Emp_ID.Text + "", GVObj.con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                txt_Name.Text = obj["Employee_Name"].ToString();
                txt_M_No.Text = obj["Mobile_No"].ToString();
                Gender = obj["Gender"].ToString();
                //Radio Button Gender Code
                bRet = Gender.Contains(rb_Male.Text);
                if (bRet)
                {
                    rb_Male.Checked = true;
                }
                bRet = Gender.Contains(rb_Female.Text);
                if (bRet)
                {
                    rb_Female.Checked = true;
                }
                dtp_DOB.Text = obj["DOB"].ToString();
                txt_Other_Hobbiess.Text = obj["Hobbies"].ToString();
                txt_Department.Text = obj["Department"].ToString();
                txt_M_Mentor.Text = obj["Manager_Mentor"].ToString();
                //Shifting Timecode
                Shift_Time = obj["Shift_Timing"].ToString();
                bRet = Shift_Time.Contains(rb_Morning.Text);
                if (bRet)
                {
                    rb_Morning.Checked = true;
                }
                bRet = Shift_Time.Contains(rb_Evening.Text);
                if (bRet)
                {
                    rb_Evening.Checked = true;
                }
                bRet = Shift_Time.Contains(rb_Night.Text);
                if (bRet)
                {
                    rb_Night.Checked = true;
                }
                //Project Checkbox Code
                Project = obj["Project"].ToString();
                bRet = Project.Contains(chkb_Tata.Text);
                if (bRet)
                {
                    chkb_Tata.Checked = true;
                }
                bRet = Project.Contains(chkb_D_Mart.Text);
                if (bRet)
                {
                    chkb_D_Mart.Checked = true;
                }
                bRet = Project.Contains(chkb_IPL.Text);
                if (bRet)
                {
                    chkb_IPL.Checked = true;
                }
                bRet = Project.Contains(chkb_Reliance.Text);
                if (bRet)
                {
                    chkb_Reliance.Checked = true;
                }
                txt_Designation.Text = obj["Designation"].ToString();
                txt_Salary.Text = obj["Salary"].ToString();

                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
