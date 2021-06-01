
namespace Tab_Control_Assignment
{
    partial class Frm_Login
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
            this.tabcontrol_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Login = new System.Windows.Forms.TabPage();
            this.chkb_Login_Show_Pass = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tabPage_Add_New_User = new System.Windows.Forms.TabPage();
            this.lbl_Add_Admin_Key_Error = new System.Windows.Forms.Label();
            this.lbl_Add_Confirm_Pass_Error = new System.Windows.Forms.Label();
            this.lbl_Add_Invalid_Or_Valid = new System.Windows.Forms.Label();
            this.chkb_Add_Show_Key = new System.Windows.Forms.CheckBox();
            this.chkb_Add_Confirm_Show_Password = new System.Windows.Forms.CheckBox();
            this.chkb_Add_Show_Pass = new System.Windows.Forms.CheckBox();
            this.btn_Add_User_Submit = new System.Windows.Forms.Button();
            this.txt_Add_Admin_Hint = new System.Windows.Forms.TextBox();
            this.txt_Add_Confirm_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Hint = new System.Windows.Forms.Label();
            this.lbl_Confirm_Pass = new System.Windows.Forms.Label();
            this.txt_Add_Password = new System.Windows.Forms.TextBox();
            this.txt_Add_UName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_U_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Add_New_User = new System.Windows.Forms.Label();
            this.tab_Page_Forgot_Password = new System.Windows.Forms.TabPage();
            this.chkb_Forgot_Show_Key = new System.Windows.Forms.CheckBox();
            this.chkb_Forgot_Confirm_Pass_Show = new System.Windows.Forms.CheckBox();
            this.chkb_Forgot_New_Show_Password = new System.Windows.Forms.CheckBox();
            this.lbl_Forgot_Password_Error = new System.Windows.Forms.Label();
            this.lbl_Forgot_Admin_Key_Error = new System.Windows.Forms.Label();
            this.lbl_Forgot_Username_Error = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Forgot_Admin_Key = new System.Windows.Forms.TextBox();
            this.txt_Forgot_Confirm_Pass = new System.Windows.Forms.TextBox();
            this.lbl_A_Key = new System.Windows.Forms.Label();
            this.lbl_C_Pass = new System.Windows.Forms.Label();
            this.txt_Forgot_New_Pass = new System.Windows.Forms.TextBox();
            this.txt_Forgot_User_Name = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Forgot_Pass = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabcontrol_Main.SuspendLayout();
            this.tabPage_Login.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage_Add_New_User.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_Page_Forgot_Password.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol_Main
            // 
            this.tabcontrol_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol_Main.Controls.Add(this.tabPage_Login);
            this.tabcontrol_Main.Controls.Add(this.tabPage_Add_New_User);
            this.tabcontrol_Main.Controls.Add(this.tab_Page_Forgot_Password);
            this.tabcontrol_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol_Main.Location = new System.Drawing.Point(12, 106);
            this.tabcontrol_Main.Name = "tabcontrol_Main";
            this.tabcontrol_Main.SelectedIndex = 0;
            this.tabcontrol_Main.Size = new System.Drawing.Size(1638, 863);
            this.tabcontrol_Main.TabIndex = 0;
            // 
            // tabPage_Login
            // 
            this.tabPage_Login.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Login.Controls.Add(this.chkb_Login_Show_Pass);
            this.tabPage_Login.Controls.Add(this.panel3);
            this.tabPage_Login.Controls.Add(this.btn_Submit);
            this.tabPage_Login.Controls.Add(this.txt_Password);
            this.tabPage_Login.Controls.Add(this.txt_Username);
            this.tabPage_Login.Controls.Add(this.lbl_Pass);
            this.tabPage_Login.Controls.Add(this.lbl_UserName);
            this.tabPage_Login.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Login.Name = "tabPage_Login";
            this.tabPage_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Login.Size = new System.Drawing.Size(1630, 819);
            this.tabPage_Login.TabIndex = 0;
            this.tabPage_Login.Text = "Login";
            this.tabPage_Login.Click += new System.EventHandler(this.tabPage_Login_Click);
            // 
            // chkb_Login_Show_Pass
            // 
            this.chkb_Login_Show_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Login_Show_Pass.AutoSize = true;
            this.chkb_Login_Show_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Login_Show_Pass.Location = new System.Drawing.Point(764, 406);
            this.chkb_Login_Show_Pass.Name = "chkb_Login_Show_Pass";
            this.chkb_Login_Show_Pass.Size = new System.Drawing.Size(209, 33);
            this.chkb_Login_Show_Pass.TabIndex = 7;
            this.chkb_Login_Show_Pass.Text = "Show Password";
            this.chkb_Login_Show_Pass.UseVisualStyleBackColor = true;
            this.chkb_Login_Show_Pass.CheckedChanged += new System.EventHandler(this.chkb_Login_Show_Pass_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lbl_Login);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1624, 100);
            this.panel3.TabIndex = 6;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Login.Location = new System.Drawing.Point(630, 17);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(415, 67);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(716, 476);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(280, 86);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Enabled = false;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(764, 343);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(436, 45);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(764, 197);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(436, 45);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(539, 343);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(170, 38);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(532, 203);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(176, 38);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "Username";
            // 
            // tabPage_Add_New_User
            // 
            this.tabPage_Add_New_User.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Admin_Key_Error);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Confirm_Pass_Error);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Invalid_Or_Valid);
            this.tabPage_Add_New_User.Controls.Add(this.chkb_Add_Show_Key);
            this.tabPage_Add_New_User.Controls.Add(this.chkb_Add_Confirm_Show_Password);
            this.tabPage_Add_New_User.Controls.Add(this.chkb_Add_Show_Pass);
            this.tabPage_Add_New_User.Controls.Add(this.btn_Add_User_Submit);
            this.tabPage_Add_New_User.Controls.Add(this.txt_Add_Admin_Hint);
            this.tabPage_Add_New_User.Controls.Add(this.txt_Add_Confirm_Pass);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Admin_Hint);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Confirm_Pass);
            this.tabPage_Add_New_User.Controls.Add(this.txt_Add_Password);
            this.tabPage_Add_New_User.Controls.Add(this.txt_Add_UName);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Password);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_U_Name);
            this.tabPage_Add_New_User.Controls.Add(this.panel2);
            this.tabPage_Add_New_User.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Add_New_User.Name = "tabPage_Add_New_User";
            this.tabPage_Add_New_User.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add_New_User.Size = new System.Drawing.Size(1630, 819);
            this.tabPage_Add_New_User.TabIndex = 1;
            this.tabPage_Add_New_User.Text = "Add New User";
            this.tabPage_Add_New_User.Click += new System.EventHandler(this.tabPage_Add_New_User_Click);
            // 
            // lbl_Add_Admin_Key_Error
            // 
            this.lbl_Add_Admin_Key_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Admin_Key_Error.AutoSize = true;
            this.lbl_Add_Admin_Key_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Admin_Key_Error.Location = new System.Drawing.Point(732, 608);
            this.lbl_Add_Admin_Key_Error.Name = "lbl_Add_Admin_Key_Error";
            this.lbl_Add_Admin_Key_Error.Size = new System.Drawing.Size(128, 29);
            this.lbl_Add_Admin_Key_Error.TabIndex = 19;
            this.lbl_Add_Admin_Key_Error.Text = "Admin Key";
            // 
            // lbl_Add_Confirm_Pass_Error
            // 
            this.lbl_Add_Confirm_Pass_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Confirm_Pass_Error.AutoSize = true;
            this.lbl_Add_Confirm_Pass_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Confirm_Pass_Error.Location = new System.Drawing.Point(738, 468);
            this.lbl_Add_Confirm_Pass_Error.Name = "lbl_Add_Confirm_Pass_Error";
            this.lbl_Add_Confirm_Pass_Error.Size = new System.Drawing.Size(180, 29);
            this.lbl_Add_Confirm_Pass_Error.TabIndex = 18;
            this.lbl_Add_Confirm_Pass_Error.Text = "Password Error";
            // 
            // lbl_Add_Invalid_Or_Valid
            // 
            this.lbl_Add_Invalid_Or_Valid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Invalid_Or_Valid.AutoSize = true;
            this.lbl_Add_Invalid_Or_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Invalid_Or_Valid.Location = new System.Drawing.Point(738, 349);
            this.lbl_Add_Invalid_Or_Valid.Name = "lbl_Add_Invalid_Or_Valid";
            this.lbl_Add_Invalid_Or_Valid.Size = new System.Drawing.Size(175, 29);
            this.lbl_Add_Invalid_Or_Valid.TabIndex = 17;
            this.lbl_Add_Invalid_Or_Valid.Text = "Invalid Or Valid";
            // 
            // chkb_Add_Show_Key
            // 
            this.chkb_Add_Show_Key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Add_Show_Key.AutoSize = true;
            this.chkb_Add_Show_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Add_Show_Key.Location = new System.Drawing.Point(1178, 566);
            this.chkb_Add_Show_Key.Name = "chkb_Add_Show_Key";
            this.chkb_Add_Show_Key.Size = new System.Drawing.Size(151, 33);
            this.chkb_Add_Show_Key.TabIndex = 16;
            this.chkb_Add_Show_Key.Text = "Show Key";
            this.chkb_Add_Show_Key.UseVisualStyleBackColor = true;
            this.chkb_Add_Show_Key.CheckedChanged += new System.EventHandler(this.chkb_Add_Show_Key_CheckedChanged);
            // 
            // chkb_Add_Confirm_Show_Password
            // 
            this.chkb_Add_Confirm_Show_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Add_Confirm_Show_Password.AutoSize = true;
            this.chkb_Add_Confirm_Show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Add_Confirm_Show_Password.Location = new System.Drawing.Point(1178, 436);
            this.chkb_Add_Confirm_Show_Password.Name = "chkb_Add_Confirm_Show_Password";
            this.chkb_Add_Confirm_Show_Password.Size = new System.Drawing.Size(222, 33);
            this.chkb_Add_Confirm_Show_Password.TabIndex = 15;
            this.chkb_Add_Confirm_Show_Password.Text = "Show Password";
            this.chkb_Add_Confirm_Show_Password.UseVisualStyleBackColor = true;
            this.chkb_Add_Confirm_Show_Password.CheckedChanged += new System.EventHandler(this.chkb_Add_Confirm_Show_Password_CheckedChanged);
            // 
            // chkb_Add_Show_Pass
            // 
            this.chkb_Add_Show_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Add_Show_Pass.AutoSize = true;
            this.chkb_Add_Show_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Add_Show_Pass.Location = new System.Drawing.Point(1178, 314);
            this.chkb_Add_Show_Pass.Name = "chkb_Add_Show_Pass";
            this.chkb_Add_Show_Pass.Size = new System.Drawing.Size(222, 33);
            this.chkb_Add_Show_Pass.TabIndex = 14;
            this.chkb_Add_Show_Pass.Text = "Show Password";
            this.chkb_Add_Show_Pass.UseVisualStyleBackColor = true;
            this.chkb_Add_Show_Pass.CheckedChanged += new System.EventHandler(this.chkb_Add_Show_Pass_CheckedChanged);
            // 
            // btn_Add_User_Submit
            // 
            this.btn_Add_User_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add_User_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User_Submit.Location = new System.Drawing.Point(682, 683);
            this.btn_Add_User_Submit.Name = "btn_Add_User_Submit";
            this.btn_Add_User_Submit.Size = new System.Drawing.Size(280, 86);
            this.btn_Add_User_Submit.TabIndex = 13;
            this.btn_Add_User_Submit.Text = "Submit";
            this.btn_Add_User_Submit.UseVisualStyleBackColor = true;
            this.btn_Add_User_Submit.Click += new System.EventHandler(this.btn_Add_User_Submit_Click);
            // 
            // txt_Add_Admin_Hint
            // 
            this.txt_Add_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Add_Admin_Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Add_Admin_Hint.Location = new System.Drawing.Point(736, 560);
            this.txt_Add_Admin_Hint.Name = "txt_Add_Admin_Hint";
            this.txt_Add_Admin_Hint.PasswordChar = '$';
            this.txt_Add_Admin_Hint.Size = new System.Drawing.Size(436, 45);
            this.txt_Add_Admin_Hint.TabIndex = 12;
            this.txt_Add_Admin_Hint.TextChanged += new System.EventHandler(this.txt_Add_Admin_Hint_TextChanged);
            // 
            // txt_Add_Confirm_Pass
            // 
            this.txt_Add_Confirm_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Add_Confirm_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Add_Confirm_Pass.Location = new System.Drawing.Point(736, 420);
            this.txt_Add_Confirm_Pass.Name = "txt_Add_Confirm_Pass";
            this.txt_Add_Confirm_Pass.PasswordChar = '*';
            this.txt_Add_Confirm_Pass.Size = new System.Drawing.Size(436, 45);
            this.txt_Add_Confirm_Pass.TabIndex = 11;
            this.txt_Add_Confirm_Pass.TextChanged += new System.EventHandler(this.txt_Add_Confirm_Pass_TextChanged);
            // 
            // lbl_Admin_Hint
            // 
            this.lbl_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Admin_Hint.AutoSize = true;
            this.lbl_Admin_Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Hint.Location = new System.Drawing.Point(495, 566);
            this.lbl_Admin_Hint.Name = "lbl_Admin_Hint";
            this.lbl_Admin_Hint.Size = new System.Drawing.Size(186, 38);
            this.lbl_Admin_Hint.TabIndex = 10;
            this.lbl_Admin_Hint.Text = "Admin Hint";
            // 
            // lbl_Confirm_Pass
            // 
            this.lbl_Confirm_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Confirm_Pass.AutoSize = true;
            this.lbl_Confirm_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Pass.Location = new System.Drawing.Point(375, 426);
            this.lbl_Confirm_Pass.Name = "lbl_Confirm_Pass";
            this.lbl_Confirm_Pass.Size = new System.Drawing.Size(301, 38);
            this.lbl_Confirm_Pass.TabIndex = 9;
            this.lbl_Confirm_Pass.Text = "Confirm Password";
            // 
            // txt_Add_Password
            // 
            this.txt_Add_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Add_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Add_Password.Location = new System.Drawing.Point(736, 301);
            this.txt_Add_Password.Name = "txt_Add_Password";
            this.txt_Add_Password.PasswordChar = '*';
            this.txt_Add_Password.Size = new System.Drawing.Size(436, 45);
            this.txt_Add_Password.TabIndex = 8;
            // 
            // txt_Add_UName
            // 
            this.txt_Add_UName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Add_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Add_UName.Location = new System.Drawing.Point(736, 177);
            this.txt_Add_UName.Name = "txt_Add_UName";
            this.txt_Add_UName.Size = new System.Drawing.Size(436, 45);
            this.txt_Add_UName.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(511, 301);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(170, 38);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_U_Name
            // 
            this.lbl_U_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_U_Name.AutoSize = true;
            this.lbl_U_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Name.Location = new System.Drawing.Point(504, 177);
            this.lbl_U_Name.Name = "lbl_U_Name";
            this.lbl_U_Name.Size = new System.Drawing.Size(176, 38);
            this.lbl_U_Name.TabIndex = 5;
            this.lbl_U_Name.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lbl_Add_New_User);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 100);
            this.panel2.TabIndex = 2;
            // 
            // lbl_Add_New_User
            // 
            this.lbl_Add_New_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Add_New_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Add_New_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Add_New_User.Location = new System.Drawing.Point(725, 19);
            this.lbl_Add_New_User.Name = "lbl_Add_New_User";
            this.lbl_Add_New_User.Size = new System.Drawing.Size(415, 67);
            this.lbl_Add_New_User.TabIndex = 0;
            this.lbl_Add_New_User.Text = "Add New User";
            this.lbl_Add_New_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Page_Forgot_Password
            // 
            this.tab_Page_Forgot_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tab_Page_Forgot_Password.Controls.Add(this.chkb_Forgot_Show_Key);
            this.tab_Page_Forgot_Password.Controls.Add(this.chkb_Forgot_Confirm_Pass_Show);
            this.tab_Page_Forgot_Password.Controls.Add(this.chkb_Forgot_New_Show_Password);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_Forgot_Password_Error);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_Forgot_Admin_Key_Error);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_Forgot_Username_Error);
            this.tab_Page_Forgot_Password.Controls.Add(this.btn_Save);
            this.tab_Page_Forgot_Password.Controls.Add(this.txt_Forgot_Admin_Key);
            this.tab_Page_Forgot_Password.Controls.Add(this.txt_Forgot_Confirm_Pass);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_A_Key);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_C_Pass);
            this.tab_Page_Forgot_Password.Controls.Add(this.txt_Forgot_New_Pass);
            this.tab_Page_Forgot_Password.Controls.Add(this.txt_Forgot_User_Name);
            this.tab_Page_Forgot_Password.Controls.Add(this.lb_Password);
            this.tab_Page_Forgot_Password.Controls.Add(this.lbl_UName);
            this.tab_Page_Forgot_Password.Controls.Add(this.panel4);
            this.tab_Page_Forgot_Password.Location = new System.Drawing.Point(4, 40);
            this.tab_Page_Forgot_Password.Name = "tab_Page_Forgot_Password";
            this.tab_Page_Forgot_Password.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Page_Forgot_Password.Size = new System.Drawing.Size(1630, 819);
            this.tab_Page_Forgot_Password.TabIndex = 2;
            this.tab_Page_Forgot_Password.Text = "Forgot Password";
            this.tab_Page_Forgot_Password.Click += new System.EventHandler(this.tab_Page_Forgot_Password_Click);
            // 
            // chkb_Forgot_Show_Key
            // 
            this.chkb_Forgot_Show_Key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Forgot_Show_Key.AutoSize = true;
            this.chkb_Forgot_Show_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Forgot_Show_Key.Location = new System.Drawing.Point(1264, 316);
            this.chkb_Forgot_Show_Key.Name = "chkb_Forgot_Show_Key";
            this.chkb_Forgot_Show_Key.Size = new System.Drawing.Size(151, 33);
            this.chkb_Forgot_Show_Key.TabIndex = 28;
            this.chkb_Forgot_Show_Key.Text = "Show Key";
            this.chkb_Forgot_Show_Key.UseVisualStyleBackColor = true;
            this.chkb_Forgot_Show_Key.CheckedChanged += new System.EventHandler(this.chkb_Forgot_Show_Key_CheckedChanged);
            // 
            // chkb_Forgot_Confirm_Pass_Show
            // 
            this.chkb_Forgot_Confirm_Pass_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Forgot_Confirm_Pass_Show.AutoSize = true;
            this.chkb_Forgot_Confirm_Pass_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Forgot_Confirm_Pass_Show.Location = new System.Drawing.Point(1264, 576);
            this.chkb_Forgot_Confirm_Pass_Show.Name = "chkb_Forgot_Confirm_Pass_Show";
            this.chkb_Forgot_Confirm_Pass_Show.Size = new System.Drawing.Size(222, 33);
            this.chkb_Forgot_Confirm_Pass_Show.TabIndex = 27;
            this.chkb_Forgot_Confirm_Pass_Show.Text = "Show Password";
            this.chkb_Forgot_Confirm_Pass_Show.UseVisualStyleBackColor = true;
            this.chkb_Forgot_Confirm_Pass_Show.CheckedChanged += new System.EventHandler(this.chkb_Forgot_Confirm_Pass_Show_CheckedChanged);
            // 
            // chkb_Forgot_New_Show_Password
            // 
            this.chkb_Forgot_New_Show_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Forgot_New_Show_Password.AutoSize = true;
            this.chkb_Forgot_New_Show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_Forgot_New_Show_Password.Location = new System.Drawing.Point(1264, 437);
            this.chkb_Forgot_New_Show_Password.Name = "chkb_Forgot_New_Show_Password";
            this.chkb_Forgot_New_Show_Password.Size = new System.Drawing.Size(222, 33);
            this.chkb_Forgot_New_Show_Password.TabIndex = 26;
            this.chkb_Forgot_New_Show_Password.Text = "Show Password";
            this.chkb_Forgot_New_Show_Password.UseVisualStyleBackColor = true;
            this.chkb_Forgot_New_Show_Password.CheckedChanged += new System.EventHandler(this.chkb_Forgot_New_Show_Password_CheckedChanged);
            // 
            // lbl_Forgot_Password_Error
            // 
            this.lbl_Forgot_Password_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Password_Error.AutoSize = true;
            this.lbl_Forgot_Password_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Password_Error.Location = new System.Drawing.Point(826, 629);
            this.lbl_Forgot_Password_Error.Name = "lbl_Forgot_Password_Error";
            this.lbl_Forgot_Password_Error.Size = new System.Drawing.Size(180, 29);
            this.lbl_Forgot_Password_Error.TabIndex = 25;
            this.lbl_Forgot_Password_Error.Text = "Password Error";
            // 
            // lbl_Forgot_Admin_Key_Error
            // 
            this.lbl_Forgot_Admin_Key_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Admin_Key_Error.AutoSize = true;
            this.lbl_Forgot_Admin_Key_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Admin_Key_Error.Location = new System.Drawing.Point(817, 366);
            this.lbl_Forgot_Admin_Key_Error.Name = "lbl_Forgot_Admin_Key_Error";
            this.lbl_Forgot_Admin_Key_Error.Size = new System.Drawing.Size(188, 29);
            this.lbl_Forgot_Admin_Key_Error.TabIndex = 24;
            this.lbl_Forgot_Admin_Key_Error.Text = "Admin Key Error";
            // 
            // lbl_Forgot_Username_Error
            // 
            this.lbl_Forgot_Username_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Username_Error.AutoSize = true;
            this.lbl_Forgot_Username_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Username_Error.Location = new System.Drawing.Point(817, 240);
            this.lbl_Forgot_Username_Error.Name = "lbl_Forgot_Username_Error";
            this.lbl_Forgot_Username_Error.Size = new System.Drawing.Size(144, 29);
            this.lbl_Forgot_Username_Error.TabIndex = 23;
            this.lbl_Forgot_Username_Error.Text = "Forgot Error";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(734, 675);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(280, 86);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // txt_Forgot_Admin_Key
            // 
            this.txt_Forgot_Admin_Key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Forgot_Admin_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forgot_Admin_Key.Location = new System.Drawing.Point(812, 309);
            this.txt_Forgot_Admin_Key.Name = "txt_Forgot_Admin_Key";
            this.txt_Forgot_Admin_Key.PasswordChar = '$';
            this.txt_Forgot_Admin_Key.Size = new System.Drawing.Size(436, 45);
            this.txt_Forgot_Admin_Key.TabIndex = 21;
            this.txt_Forgot_Admin_Key.TextChanged += new System.EventHandler(this.txt_Forgot_Admin_Key_TextChanged);
            // 
            // txt_Forgot_Confirm_Pass
            // 
            this.txt_Forgot_Confirm_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Forgot_Confirm_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forgot_Confirm_Pass.Location = new System.Drawing.Point(812, 571);
            this.txt_Forgot_Confirm_Pass.Name = "txt_Forgot_Confirm_Pass";
            this.txt_Forgot_Confirm_Pass.PasswordChar = '*';
            this.txt_Forgot_Confirm_Pass.Size = new System.Drawing.Size(436, 45);
            this.txt_Forgot_Confirm_Pass.TabIndex = 20;
            // 
            // lbl_A_Key
            // 
            this.lbl_A_Key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_A_Key.AutoSize = true;
            this.lbl_A_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A_Key.Location = new System.Drawing.Point(548, 309);
            this.lbl_A_Key.Name = "lbl_A_Key";
            this.lbl_A_Key.Size = new System.Drawing.Size(184, 38);
            this.lbl_A_Key.TabIndex = 19;
            this.lbl_A_Key.Text = "Admin Key";
            // 
            // lbl_C_Pass
            // 
            this.lbl_C_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_C_Pass.AutoSize = true;
            this.lbl_C_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C_Pass.Location = new System.Drawing.Point(431, 571);
            this.lbl_C_Pass.Name = "lbl_C_Pass";
            this.lbl_C_Pass.Size = new System.Drawing.Size(301, 38);
            this.lbl_C_Pass.TabIndex = 18;
            this.lbl_C_Pass.Text = "Confirm Password";
            // 
            // txt_Forgot_New_Pass
            // 
            this.txt_Forgot_New_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Forgot_New_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forgot_New_Pass.Location = new System.Drawing.Point(812, 430);
            this.txt_Forgot_New_Pass.Name = "txt_Forgot_New_Pass";
            this.txt_Forgot_New_Pass.PasswordChar = '*';
            this.txt_Forgot_New_Pass.Size = new System.Drawing.Size(436, 45);
            this.txt_Forgot_New_Pass.TabIndex = 17;
            // 
            // txt_Forgot_User_Name
            // 
            this.txt_Forgot_User_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Forgot_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forgot_User_Name.Location = new System.Drawing.Point(812, 183);
            this.txt_Forgot_User_Name.Name = "txt_Forgot_User_Name";
            this.txt_Forgot_User_Name.Size = new System.Drawing.Size(436, 45);
            this.txt_Forgot_User_Name.TabIndex = 16;
            this.txt_Forgot_User_Name.TextChanged += new System.EventHandler(this.txt_Forgot_User_Name_TextChanged);
            this.txt_Forgot_User_Name.Leave += new System.EventHandler(this.txt_Forgot_User_Name_Leave);
            // 
            // lb_Password
            // 
            this.lb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(483, 437);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(249, 38);
            this.lb_Password.TabIndex = 15;
            this.lb_Password.Text = "New Password";
            // 
            // lbl_UName
            // 
            this.lbl_UName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.Location = new System.Drawing.Point(556, 190);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(176, 38);
            this.lbl_UName.TabIndex = 14;
            this.lbl_UName.Text = "Username";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lbl_Forgot_Pass);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1624, 100);
            this.panel4.TabIndex = 3;
            // 
            // lbl_Forgot_Pass
            // 
            this.lbl_Forgot_Pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Forgot_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Forgot_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Forgot_Pass.Location = new System.Drawing.Point(564, 18);
            this.lbl_Forgot_Pass.Name = "lbl_Forgot_Pass";
            this.lbl_Forgot_Pass.Size = new System.Drawing.Size(567, 67);
            this.lbl_Forgot_Pass.TabIndex = 0;
            this.lbl_Forgot_Pass.Text = "Forgot Password";
            this.lbl_Forgot_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Head
            // 
            this.lbl_Head.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Head.BackColor = System.Drawing.Color.White;
            this.lbl_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Head.Location = new System.Drawing.Point(583, 22);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(576, 67);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "Fork InfoSystems";
            this.lbl_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_Head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 100);
            this.panel1.TabIndex = 1;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabcontrol_Main);
            this.Name = "Frm_Login";
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.tabcontrol_Main.ResumeLayout(false);
            this.tabPage_Login.ResumeLayout(false);
            this.tabPage_Login.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage_Add_New_User.ResumeLayout(false);
            this.tabPage_Add_New_User.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tab_Page_Forgot_Password.ResumeLayout(false);
            this.tab_Page_Forgot_Password.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol_Main;
        private System.Windows.Forms.TabPage tabPage_Login;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TabPage tabPage_Add_New_User;
        private System.Windows.Forms.TabPage tab_Page_Forgot_Password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Add_New_User;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add_User_Submit;
        private System.Windows.Forms.TextBox txt_Add_Admin_Hint;
        private System.Windows.Forms.TextBox txt_Add_Confirm_Pass;
        private System.Windows.Forms.Label lbl_Admin_Hint;
        private System.Windows.Forms.Label lbl_Confirm_Pass;
        private System.Windows.Forms.TextBox txt_Add_Password;
        private System.Windows.Forms.TextBox txt_Add_UName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_U_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Forgot_Admin_Key;
        private System.Windows.Forms.TextBox txt_Forgot_Confirm_Pass;
        private System.Windows.Forms.Label lbl_A_Key;
        private System.Windows.Forms.Label lbl_C_Pass;
        private System.Windows.Forms.TextBox txt_Forgot_New_Pass;
        private System.Windows.Forms.TextBox txt_Forgot_User_Name;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lbl_UName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Forgot_Pass;
        private System.Windows.Forms.CheckBox chkb_Login_Show_Pass;
        private System.Windows.Forms.Label lbl_Add_Admin_Key_Error;
        private System.Windows.Forms.Label lbl_Add_Confirm_Pass_Error;
        private System.Windows.Forms.Label lbl_Add_Invalid_Or_Valid;
        private System.Windows.Forms.CheckBox chkb_Add_Show_Key;
        private System.Windows.Forms.CheckBox chkb_Add_Confirm_Show_Password;
        private System.Windows.Forms.CheckBox chkb_Add_Show_Pass;
        private System.Windows.Forms.CheckBox chkb_Forgot_Show_Key;
        private System.Windows.Forms.CheckBox chkb_Forgot_Confirm_Pass_Show;
        private System.Windows.Forms.CheckBox chkb_Forgot_New_Show_Password;
        private System.Windows.Forms.Label lbl_Forgot_Password_Error;
        private System.Windows.Forms.Label lbl_Forgot_Admin_Key_Error;
        private System.Windows.Forms.Label lbl_Forgot_Username_Error;
    }
}

