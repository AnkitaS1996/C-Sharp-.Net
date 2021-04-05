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
    public partial class Frm_Update_Employee_Details : Form
    {
        string Gender = "", Hobbies = "", Project = "", Shift_Time = "";
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Frm_Update_Employee_Details()
        {
            InitializeComponent();
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
            for(int i = 0; i < Count;i++)
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void txt_Emp_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
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

        private void txt_M_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Frm_Update_Employee_Details_Load(object sender, EventArgs e)
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
            //string Gender = "", Shift_Time = "", Hobbies = "", Project = "";
            bool bRet = false;

            //SqlConnection Connection 
            GVObj.Con_Open();

            //Search Code
            SqlCommand cmd = new SqlCommand("Select * From Assignment5_Add_Employee_db where Employee_ID = " + txt_Emp_ID.Text + "", GVObj.con);
            var obj = cmd.ExecuteReader();

            if(obj.Read())
            {
                txt_Name.Text = obj["Employee_Name"].ToString();
                txt_M_No.Text = obj["Mobile_No"].ToString();
                Gender = obj["Gender"].ToString();
                dtp_DOB.Text = obj["DOB"].ToString();
                Hobbies = obj.GetString(obj.GetOrdinal("Hobbies")).ToString();
                cmb_Department.Text = obj.GetString(obj.GetOrdinal("Department")).ToString();
                cmb_M_Mentor.Text = obj.GetString(obj.GetOrdinal("Manager_Mentor")).ToString();
                Shift_Time = obj["Shift_Timing"].ToString();
                Project = obj["Project"].ToString();
                cmb_Designation.Text = obj.GetString(obj.GetOrdinal("Designation")).ToString();
                txt_Salary.Text = obj["Salary"].ToString();

                //Radio Button Gender Code
                bRet = Gender.Contains(rb_Male.Text);
                if(bRet)
                {
                    rb_Male.Checked = true;
                }

                bRet = Gender.Contains(rb_Female.Text);
                if(bRet)
                {
                    rb_Female.Checked = true;
                }

                //Shifting Timecode
                bRet = Shift_Time.Contains(rb_Morning.Text);
                if(bRet)
                {
                    rb_Morning.Checked = true;
                }
                bRet = Shift_Time.Contains(rb_Evening.Text);
                if(bRet)
                {
                    rb_Evening.Checked = true;
                }
                bRet = Shift_Time.Contains(rb_Night.Text);
                if(bRet)
                {
                    rb_Night.Checked = true;
                }

                //Project Checkbox Code
                bRet = Project.Contains(chkb_Tata.Text);
                if(bRet)
                {
                    chkb_Tata.Checked = true;
                }
                bRet = Project.Contains(chkb_D_Mart.Text);
                if(bRet)
                {
                    chkb_D_Mart.Checked = true;
                }
                bRet = Project.Contains(chkb_IPL.Text);
                if(bRet)
                {
                    chkb_IPL.Checked = true;
                }
                bRet = Project.Contains(chkb_Reliance.Text);
                if(bRet)
                {
                    chkb_Reliance.Checked = true;
                }

                //Hobbies checklist Box Code
                //string str = obj["Hobbies"].ToString();
                string[] Hobbie = Hobbies.Split( ',');
                foreach(string items in Hobbie )
                {
                    clb_Hobbies.Items.Add(items, true);
                }


                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int count = clb_Hobbies.Items.Count;
            for(int i = 0; i < count; i++)
            {
                if(clb_Hobbies.GetItemChecked(i))
                {
                    if (i == count && txt_Other_Hobbiess.Text != "")
                    {
                        if (Hobbies == "")
                        {
                            Hobbies = txt_Other_Hobbiess.Text;
                        }
                        else
                        {
                            Hobbies += " , " + txt_Other_Hobbiess.Text;
                        }
                    }
                    else if (Hobbies == "")
                    {
                        Hobbies = clb_Hobbies.Items[i].ToString();
                    }
                    else
                    {
                        Hobbies += " , " + clb_Hobbies.Items[i].ToString();
                    }
                }
                if (chkb_Tata.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_Tata.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Tata.Text;
                    }
                }
                else
                {
                    chkb_Tata.Checked = false;
                }

                if (chkb_D_Mart.Checked)
                {
                    if(Project == "")
                    {
                        Project = chkb_D_Mart.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_D_Mart.Text;
                    }
                }
               
                if(chkb_IPL.Checked)
                {
                    if(Project == "")
                    {
                        Project = chkb_IPL.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_IPL.Text;
                    }
                }

                if(chkb_Reliance.Checked)
                {
                    if(Project == "")
                    {
                        Project = chkb_Reliance.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Reliance.Text;
                    }
                }

                if(rb_Morning.Checked)
                {
                    Shift_Time = rb_Morning.Text;
                }
                else if(rb_Evening.Checked)
                {
                    Shift_Time = rb_Evening.Text;
                }
                else
                {
                    Shift_Time = rb_Night.Text;
                }

                if(rb_Male.Checked)
                {
                    Gender = rb_Male.Text;
                }
                
                if(rb_Female.Checked)
                {
                    Gender = rb_Female.Text;
                }
            }
            GVObj.Con_Open();
            if(txt_Name.Text != "" && txt_M_No.Text != "" && (rb_Male.Checked || rb_Female.Checked) && Hobbies != "" && cmb_Department.Text != "" && cmb_M_Mentor.Text != "" && (rb_Morning.Checked || rb_Evening.Checked || rb_Night.Checked) && Project != "" && cmb_Designation.Text != "" && txt_Salary.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Assignment5_Add_Employee_db SET Employee_Name = '" + txt_Name.Text + "', Mobile_No = " + txt_M_No.Text + ", Gender = '" + Gender + "', DOB = '" + dtp_DOB.Text + "', Hobbies = '" + Hobbies + "',Department = '" + cmb_Department.Text + "',Manager_Mentor = '" + cmb_M_Mentor.Text + "',Shift_Timing = '" + Shift_Time + "',Project = '" + Project + "',Designation = '" + cmb_Designation.Text + "',Salary = '" + txt_Salary.Text + "' where Employee_ID = " + txt_Emp_ID.Text + " ");
                cmd.Connection = GVObj.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
            }
            else
            {
                MessageBox.Show("1st Fill All field", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GVObj.Con_Close();
        }
    }
}
