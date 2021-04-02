using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_Information
{
    class Global_Variable_CodeClass
    {
        //Region Start
        /// Database Connection String
        string Connection = (@"Data Source=.\sqlExpress;Initial Catalog=Assignment5_Emplaoyee_Management_System_db;Integrated Security=True");
        public SqlConnection con;

        //Database Connection Open
        public void Con_Open()
        {
            con = new SqlConnection(Connection);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //Database Connection Close
        public void Con_Close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //End Region
        
        //Region Start AutoIncrement Code
        public int AutoIncrement(String Get_Count, String Get_Max,int Start_No)
        {
            int Cnt = 0;
            Con_Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Get_Count, con);
                Cnt = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                if(Cnt > 0)
                {
                    cmd.CommandText = Get_Max;
                    cmd.Connection = con;
                    Cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    Cnt += 1;
                    cmd.Dispose();
                    Con_Close();
                }
                else
                {
                    Cnt += Start_No;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Cnt;
        }
        //End Region
       
    }
}
