namespace Employee_Details_String_Create
{
    partial class Frm_Stud_Info
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.gb_Department = new System.Windows.Forms.GroupBox();
            this.rb_Civil = new System.Windows.Forms.RadioButton();
            this.rb_Electrical = new System.Windows.Forms.RadioButton();
            this.rb_Electronics = new System.Windows.Forms.RadioButton();
            this.rb_Computer = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.btn_Show_Result = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.gb_Department.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(112, 130);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(94, 32);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Department
            // 
            this.lbl_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(112, 341);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(173, 32);
            this.lbl_Department.TabIndex = 1;
            this.lbl_Department.Text = "Department";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(346, 127);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(631, 38);
            this.txt_Name.TabIndex = 2;
            // 
            // gb_Department
            // 
            this.gb_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Department.Controls.Add(this.rb_Civil);
            this.gb_Department.Controls.Add(this.rb_Electrical);
            this.gb_Department.Controls.Add(this.rb_Electronics);
            this.gb_Department.Controls.Add(this.rb_Computer);
            this.gb_Department.Location = new System.Drawing.Point(346, 298);
            this.gb_Department.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.gb_Department.Name = "gb_Department";
            this.gb_Department.Size = new System.Drawing.Size(626, 97);
            this.gb_Department.TabIndex = 3;
            this.gb_Department.TabStop = false;
            // 
            // rb_Civil
            // 
            this.rb_Civil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Civil.AutoSize = true;
            this.rb_Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Civil.Location = new System.Drawing.Point(529, 32);
            this.rb_Civil.Name = "rb_Civil";
            this.rb_Civil.Size = new System.Drawing.Size(85, 33);
            this.rb_Civil.TabIndex = 4;
            this.rb_Civil.TabStop = true;
            this.rb_Civil.Text = "Civil";
            this.rb_Civil.UseVisualStyleBackColor = true;
            // 
            // rb_Electrical
            // 
            this.rb_Electrical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Electrical.AutoSize = true;
            this.rb_Electrical.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Electrical.Location = new System.Drawing.Point(366, 32);
            this.rb_Electrical.Name = "rb_Electrical";
            this.rb_Electrical.Size = new System.Drawing.Size(143, 33);
            this.rb_Electrical.TabIndex = 3;
            this.rb_Electrical.TabStop = true;
            this.rb_Electrical.Text = "Electrical";
            this.rb_Electrical.UseVisualStyleBackColor = true;
            // 
            // rb_Electronics
            // 
            this.rb_Electronics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Electronics.AutoSize = true;
            this.rb_Electronics.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Electronics.Location = new System.Drawing.Point(176, 32);
            this.rb_Electronics.Name = "rb_Electronics";
            this.rb_Electronics.Size = new System.Drawing.Size(164, 33);
            this.rb_Electronics.TabIndex = 2;
            this.rb_Electronics.TabStop = true;
            this.rb_Electronics.Text = "Electronics";
            this.rb_Electronics.UseVisualStyleBackColor = true;
            // 
            // rb_Computer
            // 
            this.rb_Computer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Computer.AutoSize = true;
            this.rb_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Computer.Location = new System.Drawing.Point(5, 34);
            this.rb_Computer.Name = "rb_Computer";
            this.rb_Computer.Size = new System.Drawing.Size(148, 33);
            this.rb_Computer.TabIndex = 1;
            this.rb_Computer.TabStop = true;
            this.rb_Computer.Text = "Computer";
            this.rb_Computer.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(112, 237);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(116, 32);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(346, 185);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(556, 84);
            this.gb_Gender.TabIndex = 5;
            this.gb_Gender.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(366, 28);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(122, 33);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(112, 27);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(91, 33);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // btn_Show_Result
            // 
            this.btn_Show_Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Show_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Result.Location = new System.Drawing.Point(154, 457);
            this.btn_Show_Result.Name = "btn_Show_Result";
            this.btn_Show_Result.Size = new System.Drawing.Size(261, 53);
            this.btn_Show_Result.TabIndex = 6;
            this.btn_Show_Result.Text = "Show Result";
            this.btn_Show_Result.UseVisualStyleBackColor = true;
            this.btn_Show_Result.Click += new System.EventHandler(this.btn_Show_Result_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(482, 457);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(216, 53);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(29, 550);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(1036, 41);
            this.txt_Result.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 100);
            this.panel1.TabIndex = 9;
            // 
            // lbl_Head
            // 
            this.lbl_Head.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(302, 24);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(462, 55);
            this.lbl_Head.TabIndex = 1;
            this.lbl_Head.Text = "Student Information";
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(771, 457);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(216, 53);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Frm_Stud_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 642);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Show_Result);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.gb_Department);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Stud_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.gb_Department.ResumeLayout(false);
            this.gb_Department.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox gb_Department;
        private System.Windows.Forms.RadioButton rb_Electrical;
        private System.Windows.Forms.RadioButton rb_Electronics;
        private System.Windows.Forms.RadioButton rb_Computer;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Button btn_Show_Result;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.RadioButton rb_Civil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Button btn_Next;
    }
}

