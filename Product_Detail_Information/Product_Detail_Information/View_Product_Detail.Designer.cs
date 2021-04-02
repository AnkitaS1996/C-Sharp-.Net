namespace Product_Detail_Information
{
    partial class View_Product_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Go_Back = new System.Windows.Forms.Button();
            this.lbl_View_Product_Detail = new System.Windows.Forms.Label();
            this.btn_Add_Product_Detail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSalesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Detail_Information_dbDataSet1 = new Product_Detail_Information.Product_Detail_Information_dbDataSet1();
            this.product_AddTableAdapter = new Product_Detail_Information.Product_Detail_Information_dbDataSet1TableAdapters.Product_AddTableAdapter();
            this.btn_Search_Product = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Detail_Information_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Go_Back);
            this.panel1.Controls.Add(this.lbl_View_Product_Detail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 137);
            this.panel1.TabIndex = 0;
            // 
            // btn_Go_Back
            // 
            this.btn_Go_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Go_Back.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go_Back.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Go_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Go_Back.Name = "btn_Go_Back";
            this.btn_Go_Back.Size = new System.Drawing.Size(174, 62);
            this.btn_Go_Back.TabIndex = 4;
            this.btn_Go_Back.Text = "Go Back";
            this.btn_Go_Back.UseVisualStyleBackColor = false;
            this.btn_Go_Back.Click += new System.EventHandler(this.btn_Go_Back_Click);
            // 
            // lbl_View_Product_Detail
            // 
            this.lbl_View_Product_Detail.AutoSize = true;
            this.lbl_View_Product_Detail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_View_Product_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_View_Product_Detail.Location = new System.Drawing.Point(589, 23);
            this.lbl_View_Product_Detail.Name = "lbl_View_Product_Detail";
            this.lbl_View_Product_Detail.Size = new System.Drawing.Size(789, 91);
            this.lbl_View_Product_Detail.TabIndex = 0;
            this.lbl_View_Product_Detail.Text = "View Product Details";
            // 
            // btn_Add_Product_Detail
            // 
            this.btn_Add_Product_Detail.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product_Detail.Location = new System.Drawing.Point(365, 885);
            this.btn_Add_Product_Detail.Name = "btn_Add_Product_Detail";
            this.btn_Add_Product_Detail.Size = new System.Drawing.Size(601, 79);
            this.btn_Add_Product_Detail.TabIndex = 2;
            this.btn_Add_Product_Detail.Text = "Add Product Detail";
            this.btn_Add_Product_Detail.UseVisualStyleBackColor = true;
            this.btn_Add_Product_Detail.Click += new System.EventHandler(this.btn_Add_Product_Detail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productSalesPriceDataGridViewTextBoxColumn,
            this.productStockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productAddBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(102, 143);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1839, 680);
            this.dataGridView1.TabIndex = 3;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productSalesPriceDataGridViewTextBoxColumn
            // 
            this.productSalesPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Sales_Price";
            this.productSalesPriceDataGridViewTextBoxColumn.HeaderText = "Product_Sales_Price";
            this.productSalesPriceDataGridViewTextBoxColumn.Name = "productSalesPriceDataGridViewTextBoxColumn";
            // 
            // productStockDataGridViewTextBoxColumn
            // 
            this.productStockDataGridViewTextBoxColumn.DataPropertyName = "Product_Stock";
            this.productStockDataGridViewTextBoxColumn.HeaderText = "Product_Stock";
            this.productStockDataGridViewTextBoxColumn.Name = "productStockDataGridViewTextBoxColumn";
            // 
            // productAddBindingSource
            // 
            this.productAddBindingSource.DataMember = "Product_Add";
            this.productAddBindingSource.DataSource = this.product_Detail_Information_dbDataSet1;
            // 
            // product_Detail_Information_dbDataSet1
            // 
            this.product_Detail_Information_dbDataSet1.DataSetName = "Product_Detail_Information_dbDataSet1";
            this.product_Detail_Information_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_AddTableAdapter
            // 
            this.product_AddTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Search_Product
            // 
            this.btn_Search_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Product.Location = new System.Drawing.Point(1049, 885);
            this.btn_Search_Product.Name = "btn_Search_Product";
            this.btn_Search_Product.Size = new System.Drawing.Size(207, 79);
            this.btn_Search_Product.TabIndex = 4;
            this.btn_Search_Product.Text = "Next";
            this.btn_Search_Product.UseVisualStyleBackColor = true;
            this.btn_Search_Product.Click += new System.EventHandler(this.btn_Search_Product_Click);
            // 
            // View_Product_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_Search_Product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Add_Product_Detail);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Product_Detail";
            this.Text = "View_Product_Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Product_Detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Detail_Information_dbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_View_Product_Detail;
        private System.Windows.Forms.Button btn_Add_Product_Detail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Product_Detail_Information_dbDataSet1 product_Detail_Information_dbDataSet1;
        private System.Windows.Forms.BindingSource productAddBindingSource;
        private Product_Detail_Information_dbDataSet1TableAdapters.Product_AddTableAdapter product_AddTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSalesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Search_Product;
        private System.Windows.Forms.Button btn_Go_Back;
    }
}