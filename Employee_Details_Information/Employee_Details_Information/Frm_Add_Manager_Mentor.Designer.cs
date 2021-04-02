namespace Employee_Details_Information
{
    partial class Frm_Add_Manager_Mentor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.GB_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.txt_M_No = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_Join_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Join_Date = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GB_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 98);
            this.panel1.TabIndex = 9;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Header.Location = new System.Drawing.Point(570, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(607, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Manager Mentor";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_Gender
            // 
            this.GB_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GB_Gender.Controls.Add(this.rb_Female);
            this.GB_Gender.Controls.Add(this.rb_Male);
            this.GB_Gender.Location = new System.Drawing.Point(382, 572);
            this.GB_Gender.Name = "GB_Gender";
            this.GB_Gender.Size = new System.Drawing.Size(392, 65);
            this.GB_Gender.TabIndex = 37;
            this.GB_Gender.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(222, 16);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(122, 33);
            this.rb_Female.TabIndex = 28;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_Female_KeyDown);
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(61, 16);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(91, 33);
            this.rb_Male.TabIndex = 27;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_Male_KeyDown);
            // 
            // txt_M_No
            // 
            this.txt_M_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_M_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_M_No.Location = new System.Drawing.Point(382, 458);
            this.txt_M_No.Name = "txt_M_No";
            this.txt_M_No.Size = new System.Drawing.Size(392, 41);
            this.txt_M_No.TabIndex = 36;
            this.txt_M_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_M_No_KeyDown);
            this.txt_M_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_No_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(382, 334);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(392, 41);
            this.txt_Name.TabIndex = 35;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(382, 211);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(392, 41);
            this.txt_ID.TabIndex = 34;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(31, 588);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(151, 40);
            this.lbl_Gender.TabIndex = 33;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(31, 459);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(297, 40);
            this.lbl_Mobile_No.TabIndex = 32;
            this.lbl_Mobile_No.Text = "Mobile Number";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(31, 333);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(124, 40);
            this.lbl_Name.TabIndex = 31;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(31, 210);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(62, 40);
            this.lbl_ID.TabIndex = 30;
            this.lbl_ID.Text = "ID";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_DOB.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(1131, 332);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(392, 41);
            this.dtp_DOB.TabIndex = 39;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(845, 335);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(258, 40);
            this.lbl_DOB.TabIndex = 38;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Department
            // 
            this.lbl_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(845, 210);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(238, 40);
            this.lbl_Department.TabIndex = 40;
            this.lbl_Department.Text = "Department";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(1131, 210);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(393, 39);
            this.cmb_Department.TabIndex = 41;
            this.cmb_Department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Department_KeyDown);
            // 
            // dtp_Join_Date
            // 
            this.dtp_Join_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Join_Date.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.dtp_Join_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Join_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Join_Date.Location = new System.Drawing.Point(1130, 456);
            this.dtp_Join_Date.Name = "dtp_Join_Date";
            this.dtp_Join_Date.Size = new System.Drawing.Size(392, 41);
            this.dtp_Join_Date.TabIndex = 43;
            // 
            // lbl_Join_Date
            // 
            this.lbl_Join_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Join_Date.AutoSize = true;
            this.lbl_Join_Date.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Join_Date.Location = new System.Drawing.Point(845, 457);
            this.lbl_Join_Date.Name = "lbl_Join_Date";
            this.lbl_Join_Date.Size = new System.Drawing.Size(190, 40);
            this.lbl_Join_Date.TabIndex = 42;
            this.lbl_Join_Date.Text = "Join Date";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salary.Location = new System.Drawing.Point(1130, 571);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(393, 41);
            this.txt_Salary.TabIndex = 45;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(872, 572);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(132, 40);
            this.lbl_Salary.TabIndex = 44;
            this.lbl_Salary.Text = "Salary";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(541, 712);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(233, 70);
            this.btn_Save.TabIndex = 46;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Refresh.Location = new System.Drawing.Point(884, 714);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(199, 68);
            this.btn_Refresh.TabIndex = 47;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_Add_Manager_Mentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 794);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.dtp_Join_Date);
            this.Controls.Add(this.lbl_Join_Date);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.GB_Gender);
            this.Controls.Add(this.txt_M_No);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Add_Manager_Mentor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Manager Mentor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Add_Manager_Mentor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Gender.ResumeLayout(false);
            this.GB_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox GB_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox txt_M_No;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker dtp_Join_Date;
        private System.Windows.Forms.Label lbl_Join_Date;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}