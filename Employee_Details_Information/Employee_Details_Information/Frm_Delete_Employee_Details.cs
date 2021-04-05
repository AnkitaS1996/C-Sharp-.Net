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
    public partial class Frm_Delete_Employee_Details : Form
    {
        string Gender = "", Hobbies = "", Project = "", Shift_Time = "";

        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Frm_Delete_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Delete from Assignment5_Add_Employee_db where Employee_ID = " + txt_Emp_ID.Text + "");
            cmd.Connection = GVObj.con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Control();
            GVObj.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void txt_M_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }

        private void txt_Emp_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        void Clear_Control()
        {
            int Count = clb_Hobbies.Items.Count;
            txt_Emp_ID.Clear();
            txt_Name.Clear();
            txt_M_No.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            dtp_DOB.Text = "";
            for (int i = 0; i < Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            txt_Other_Hobbiess.Clear();
            cmb_Department.SelectedIndex = -1;
            cmb_M_Mentor.SelectedIndex = -1;
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
            chkb_Tata.Checked = false;
            chkb_D_Mart.Checked = false;
            chkb_IPL.Checked = false;
            chkb_Reliance.Checked = false;
            cmb_Designation.SelectedIndex = -1;
            txt_Salary.Clear();
        }
       
        private void Frm_Delete_Employee_Details_Load(object sender, EventArgs e)
        {
            try
            {
                GVObj.Con_Open();

                SqlCommand cmd = new SqlCommand("Select Distinct(Name) from Assignment5_Add_Department", GVObj.con);
                var Obj = cmd.ExecuteReader();
                while (Obj.Read())
                {
                    cmb_Department.Items.Add(Obj.GetString(Obj.GetOrdinal("Name")));
                }
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GVObj.Con_Close();
            }

            try
            {
                GVObj.Con_Open();

                SqlCommand cmd = new SqlCommand("Select Distinct(Name) from Assignment5_Add_Manager_Mentor_db", GVObj.con);
                var VObj = cmd.ExecuteReader();
                while (VObj.Read())
                {
                    cmb_M_Mentor.Items.Add(VObj.GetString(VObj.GetOrdinal("Name")));
                }
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GVObj.Con_Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
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
                //Hobbies checklist Box Code
                Hobbies = obj.GetString(obj.GetOrdinal("Hobbies")).ToString();
                string[] Hobbie = Hobbies.Split(',');
                foreach (string items in Hobbie)
                {
                    clb_Hobbies.Items.Add(items, true);
                }
                cmb_Department.Text = obj.GetString(obj.GetOrdinal("Department")).ToString();
                cmb_M_Mentor.Text = obj.GetString(obj.GetOrdinal("Manager_Mentor")).ToString();
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
                cmb_Designation.Text = obj.GetString(obj.GetOrdinal("Designation")).ToString();
                txt_Salary.Text = obj["Salary"].ToString();

                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
