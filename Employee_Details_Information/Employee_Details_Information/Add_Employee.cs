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
    public partial class Add_Employee : Form
    {
        Global_Variable_CodeClass GVObj = new Global_Variable_CodeClass();
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Clear_Control()
        {
            txt_Emp_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Employee_ID) from Assignment5_Add_Employee_db", "Select Max(Employee_ID) from Assignment5_Add_Employee_db", 101));
            txt_Name.Clear();
            txt_M_No.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            dtp_date_Of_Birth.Text = "";
            int count = clb_Hobbies.Items.Count;
            for(int i = 0; i < count; i++)
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
        private void Add_Employee_Load(object sender, EventArgs e)
        {
            txt_Emp_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Employee_ID) from Assignment5_Add_Employee_db", "Select Max(Employee_ID) from Assignment5_Add_Employee_db", 101));
            try
            {
                GVObj.Con_Open();

                SqlCommand cmd = new SqlCommand("Select Distinct(Name) from Assignment5_Add_Department", GVObj.con);
                var Obj = cmd.ExecuteReader();
                while(Obj.Read())
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
        private void clb_Hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = 0;
            //tring OtherHobbies = "";
            for (j = 0; j < clb_Hobbies.Items.Count; j++)
            {
                if (clb_Hobbies.GetItemChecked(j))
                {
                    lbl_Other_hobbies.Visible = true;
                    txt_Other_Hobbiess.Visible = true;
                }
                else
                {
                    lbl_Other_hobbies.Visible = false;
                    txt_Other_Hobbiess.Visible = false;
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Hobbies = "";
            string ShiftTime = "";
            string Project = "";
            //Radio Button Gender Code
           if(rb_Male.Checked)
           {
                Gender = rb_Male.Text;
           }        
           if(rb_Female.Checked)
           {
                Gender = rb_Female.Text;
           }

           //Hobbies ChecklistBox Code
           int Count = clb_Hobbies.Items.Count;
           for(int i = 0; i < Count; i++)
           {
                if (clb_Hobbies.GetItemChecked(i))
                {
                    if (txt_Other_Hobbiess.Text != "" && i == Count)
                    {
                        if (Hobbies == "")
                        {
                            Hobbies = txt_Other_Hobbiess.Text;
                        }
                        else
                        {
                            Hobbies += " ," + txt_Other_Hobbiess.Text;
                        }
                    }
                    else if(Hobbies == "")
                    {
                        Hobbies = clb_Hobbies.Items[i].ToString();
                    }
                    else
                    {
                        Hobbies += " , " + clb_Hobbies.Items[i].ToString();
                    }
                }
           }
           //Shift Timing Code Radio Button
           if(rb_Morning.Checked)
           {
               ShiftTime = rb_Morning.Text;
           }
           if(rb_Evening.Checked)
           {
               ShiftTime = rb_Evening.Text;
           }
           if(rb_Night.Checked)
           {
               ShiftTime = rb_Night.Text;
           }

           //Project Checkbox List Code
           if(chkb_Tata.Checked)
           {
                if(Project == "")
                {
                    Project = chkb_Tata.Text;
                }
                else
                {
                    Project += " , " + chkb_Tata.Text;
                }
           }
           if(chkb_D_Mart.Checked)
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

           //try
           //{
               GVObj.Con_Open();
               if (txt_Emp_ID.Text != "" && txt_Name.Text != "" && txt_M_No.Text != "" && (rb_Male.Checked || rb_Female.Checked) && Hobbies != "" && cmb_Department.Text != "" && cmb_M_Mentor.Text != "" && (rb_Morning.Checked || rb_Evening.Checked || rb_Night.Checked) && Project != "" && cmb_Designation.Text != "" && txt_Salary.Text != "")
               {
                   SqlCommand cmd = new SqlCommand("Insert into Assignment5_Add_Employee_db Values(" + txt_Emp_ID.Text + ", '" + txt_Name.Text + "'," + txt_M_No.Text + ", '" + Gender + "', '" + dtp_date_Of_Birth.Text + "','" + Hobbies + "','" + cmb_Department.Text + "','" + cmb_M_Mentor.Text + "','" + ShiftTime + "','" + Project + "','" + cmb_Designation.Text + "'," + txt_Salary.Text + ")");
                   cmd.Connection = GVObj.con;
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   Clear_Control();
                Gender = "";
                Project = "";
                ShiftTime = "";
                Hobbies = "";
               }
               else
               {
                   MessageBox.Show("1st Fill All Field", "1st Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
           //}
            //catch (Exception ex)
           //{
               // MessageBox.Show(ex.Message);
           //}
           //finally
           //{
                GVObj.Con_Close();
           //}
           
           
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

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_M_No.Focus();
            }
        }

        private void txt_M_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Male.Focus();
            }
        }

        private void rb_Male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Female.Focus();
            }
        }

        private void rb_Female_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_date_Of_Birth.Focus();
            }
        }

        private void dtp_date_Of_Birth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clb_Hobbies.Focus();
            }
        }

        private void cmb_Department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_M_Mentor.Focus();
            }
        }

        private void cmb_M_Mentor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Morning.Focus();
            }
        }

        private void rb_Morning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Evening.Focus();
            }
        }

        private void rb_Evening_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_Night.Focus();
            }
        }

        private void rb_Night_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkb_Tata.Focus();
            }
        }

        private void chkb_Tata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkb_D_Mart.Focus();
            }
        }

        private void chkb_D_Mart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkb_IPL.Focus();
            }
        }

        private void chkb_IPL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkb_Reliance.Focus();
            }
        }

        private void chkb_Reliance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Designation.Focus();
            }
        }

        private void cmb_Designation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Salary.Focus();
            }
        }

        private void txt_Salary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Save.Focus();
            }
            
        }
    }
}
