using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Detail_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void showreport(String sql,SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Product_Add");
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
