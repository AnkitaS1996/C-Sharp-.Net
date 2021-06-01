using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_Control_Assignment
{
    class Global_Function_Variable_Code_Class
    {
        string ConnectionString = (@"Data Source=.\sqlExpress;Initial Catalog=Tab_Control_Add_User_Login_db;Integrated Security=True");

        public SqlConnection con;
        public void Con_Open()
        {
            con = new SqlConnection(ConnectionString);

            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Con_Close()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
