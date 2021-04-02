using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_Detail_Information
{
    public partial class View_Product_Detail : Form
    {
        public View_Product_Detail()
        {
            InitializeComponent();
        }

        private void View_Product_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Detail_Information_dbDataSet1.Product_Add' table. You can move, or remove it, as needed.
            this.product_AddTableAdapter.Fill(this.product_Detail_Information_dbDataSet1.Product_Add);

        }

        private void btn_Add_Product_Detail_Click(object sender, EventArgs e)
        {
            Add_Product_Detail_Information obj = new Add_Product_Detail_Information();
            obj.Show();
            this.Hide();
        }

        
    }
       
}
