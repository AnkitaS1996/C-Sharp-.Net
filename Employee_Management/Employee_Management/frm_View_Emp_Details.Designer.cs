namespace Employee_Management
{
    partial class frm_View_Emp_Details
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
            this.pl_View_Emp = new System.Windows.Forms.Panel();
            this.lbl_View_Header_Emp = new System.Windows.Forms.Label();
            this.employeeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_DBDataSet = new Employee_Management.Employee_Management_System_DBDataSet();
            this.employee_DetailTableAdapter = new Employee_Management.Employee_Management_System_DBDataSetTableAdapters.Employee_DetailTableAdapter();
            this.employee_Management_System_DBDataSet1 = new Employee_Management.Employee_Management_System_DBDataSet1();
            this.employeeDetailAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Detail_AddTableAdapter = new Employee_Management.Employee_Management_System_DBDataSet1TableAdapters.Employee_Detail_AddTableAdapter();
            this.dgv_Emp_View = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knownLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailAddBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_DBDataSet2 = new Employee_Management.Employee_Management_System_DBDataSet2();
            this.employee_Detail_AddTableAdapter1 = new Employee_Management.Employee_Management_System_DBDataSet2TableAdapters.Employee_Detail_AddTableAdapter();
            this.employee_Management_System_DBDataSet3 = new Employee_Management.Employee_Management_System_DBDataSet3();
            this.employeeDetailAddBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Detail_AddTableAdapter2 = new Employee_Management.Employee_Management_System_DBDataSet3TableAdapters.Employee_Detail_AddTableAdapter();
            this.pl_View_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_View_Emp
            // 
            this.pl_View_Emp.BackColor = System.Drawing.Color.Crimson;
            this.pl_View_Emp.Controls.Add(this.lbl_View_Header_Emp);
            this.pl_View_Emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_View_Emp.Location = new System.Drawing.Point(0, 0);
            this.pl_View_Emp.Name = "pl_View_Emp";
            this.pl_View_Emp.Size = new System.Drawing.Size(1912, 159);
            this.pl_View_Emp.TabIndex = 1;
            // 
            // lbl_View_Header_Emp
            // 
            this.lbl_View_Header_Emp.AutoSize = true;
            this.lbl_View_Header_Emp.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_View_Header_Emp.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Header_Emp.Location = new System.Drawing.Point(773, 53);
            this.lbl_View_Header_Emp.Name = "lbl_View_Header_Emp";
            this.lbl_View_Header_Emp.Size = new System.Drawing.Size(497, 51);
            this.lbl_View_Header_Emp.TabIndex = 0;
            this.lbl_View_Header_Emp.Text = "View Employee Detail";
            // 
            // employeeDetailBindingSource
            // 
            this.employeeDetailBindingSource.DataMember = "Employee_Detail";
            this.employeeDetailBindingSource.DataSource = this.employee_Management_System_DBDataSet;
            // 
            // employee_Management_System_DBDataSet
            // 
            this.employee_Management_System_DBDataSet.DataSetName = "Employee_Management_System_DBDataSet";
            this.employee_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailTableAdapter
            // 
            this.employee_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // employee_Management_System_DBDataSet1
            // 
            this.employee_Management_System_DBDataSet1.DataSetName = "Employee_Management_System_DBDataSet1";
            this.employee_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailAddBindingSource
            // 
            this.employeeDetailAddBindingSource.DataMember = "Employee_Detail_Add";
            this.employeeDetailAddBindingSource.DataSource = this.employee_Management_System_DBDataSet1;
            // 
            // employee_Detail_AddTableAdapter
            // 
            this.employee_Detail_AddTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_Emp_View
            // 
            this.dgv_Emp_View.AllowUserToAddRows = false;
            this.dgv_Emp_View.AllowUserToDeleteRows = false;
            this.dgv_Emp_View.AutoGenerateColumns = false;
            this.dgv_Emp_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Emp_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Emp_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.knownLanguageDataGridViewTextBoxColumn});
            this.dgv_Emp_View.DataSource = this.employeeDetailAddBindingSource2;
            this.dgv_Emp_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Emp_View.Location = new System.Drawing.Point(0, 159);
            this.dgv_Emp_View.Name = "dgv_Emp_View";
            this.dgv_Emp_View.ReadOnly = true;
            this.dgv_Emp_View.RowTemplate.Height = 24;
            this.dgv_Emp_View.Size = new System.Drawing.Size(1912, 834);
            this.dgv_Emp_View.TabIndex = 2;
            this.dgv_Emp_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Emp_View_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "MobNo";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "MobNo";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // knownLanguageDataGridViewTextBoxColumn
            // 
            this.knownLanguageDataGridViewTextBoxColumn.DataPropertyName = "KnownLanguage";
            this.knownLanguageDataGridViewTextBoxColumn.HeaderText = "KnownLanguage";
            this.knownLanguageDataGridViewTextBoxColumn.Name = "knownLanguageDataGridViewTextBoxColumn";
            this.knownLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailAddBindingSource1
            // 
            this.employeeDetailAddBindingSource1.DataMember = "Employee_Detail_Add";
            this.employeeDetailAddBindingSource1.DataSource = this.employee_Management_System_DBDataSet2;
            // 
            // employee_Management_System_DBDataSet2
            // 
            this.employee_Management_System_DBDataSet2.DataSetName = "Employee_Management_System_DBDataSet2";
            this.employee_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_Detail_AddTableAdapter1
            // 
            this.employee_Detail_AddTableAdapter1.ClearBeforeFill = true;
            // 
            // employee_Management_System_DBDataSet3
            // 
            this.employee_Management_System_DBDataSet3.DataSetName = "Employee_Management_System_DBDataSet3";
            this.employee_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailAddBindingSource2
            // 
            this.employeeDetailAddBindingSource2.DataMember = "Employee_Detail_Add";
            this.employeeDetailAddBindingSource2.DataSource = this.employee_Management_System_DBDataSet3;
            // 
            // employee_Detail_AddTableAdapter2
            // 
            this.employee_Detail_AddTableAdapter2.ClearBeforeFill = true;
            // 
            // frm_View_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 993);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Emp_View);
            this.Controls.Add(this.pl_View_Emp);
            this.Name = "frm_View_Emp_Details";
            this.Text = "View Employee All Details";
            this.Load += new System.EventHandler(this.frm_View_Emp_Details_Load);
            this.pl_View_Emp.ResumeLayout(false);
            this.pl_View_Emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailAddBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_View_Emp;
        private System.Windows.Forms.Label lbl_View_Header_Emp;
        private Employee_Management_System_DBDataSet employee_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource employeeDetailBindingSource;
        private Employee_Management_System_DBDataSetTableAdapters.Employee_DetailTableAdapter employee_DetailTableAdapter;
        private Employee_Management_System_DBDataSet1 employee_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailAddBindingSource;
        private Employee_Management_System_DBDataSet1TableAdapters.Employee_Detail_AddTableAdapter employee_Detail_AddTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Emp_View;
        private Employee_Management_System_DBDataSet2 employee_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource employeeDetailAddBindingSource1;
        private Employee_Management_System_DBDataSet2TableAdapters.Employee_Detail_AddTableAdapter employee_Detail_AddTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knownLanguageDataGridViewTextBoxColumn;
        private Employee_Management_System_DBDataSet3 employee_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource employeeDetailAddBindingSource2;
        private Employee_Management_System_DBDataSet3TableAdapters.Employee_Detail_AddTableAdapter employee_Detail_AddTableAdapter2;
    }
}