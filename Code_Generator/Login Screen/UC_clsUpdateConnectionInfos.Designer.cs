
namespace Code_Generator.Login_Screen
{
    partial class UC_clsUpdateConnectionInfos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Chk_RemembreMe = new System.Windows.Forms.CheckBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Comb_ChoseDatabase = new System.Windows.Forms.ComboBox();
            this.btn_CreateNewDataBase = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.chk_LocalServer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CreatNewDataBase = new System.Windows.Forms.TextBox();
            this.LkLb_Cancel = new System.Windows.Forms.LinkLabel();
            this.LkLb_Create = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chk_RemembreMe
            // 
            this.Chk_RemembreMe.AutoSize = true;
            this.Chk_RemembreMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_RemembreMe.Location = new System.Drawing.Point(133, 109);
            this.Chk_RemembreMe.Name = "Chk_RemembreMe";
            this.Chk_RemembreMe.Size = new System.Drawing.Size(106, 17);
            this.Chk_RemembreMe.TabIndex = 41;
            this.Chk_RemembreMe.Text = "Remember Me";
            this.Chk_RemembreMe.UseVisualStyleBackColor = true;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(142, 197);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(72, 29);
            this.btn_LogIn.TabIndex = 40;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(169, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Chose Data Base";
            // 
            // Comb_ChoseDatabase
            // 
            this.Comb_ChoseDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_ChoseDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comb_ChoseDatabase.FormattingEnabled = true;
            this.Comb_ChoseDatabase.Location = new System.Drawing.Point(5, 147);
            this.Comb_ChoseDatabase.Name = "Comb_ChoseDatabase";
            this.Comb_ChoseDatabase.Size = new System.Drawing.Size(149, 21);
            this.Comb_ChoseDatabase.TabIndex = 37;
            this.Comb_ChoseDatabase.DropDown += new System.EventHandler(this.Comb_ChoseDatabase_DropDown);
            // 
            // btn_CreateNewDataBase
            // 
            this.btn_CreateNewDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateNewDataBase.Location = new System.Drawing.Point(201, 146);
            this.btn_CreateNewDataBase.Name = "btn_CreateNewDataBase";
            this.btn_CreateNewDataBase.Size = new System.Drawing.Size(150, 23);
            this.btn_CreateNewDataBase.TabIndex = 36;
            this.btn_CreateNewDataBase.Text = "Create New Database";
            this.btn_CreateNewDataBase.UseVisualStyleBackColor = true;
            this.btn_CreateNewDataBase.Click += new System.EventHandler(this.btn_CreateNewDataBase_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(120, 78);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(135, 20);
            this.txt_Password.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password : ";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(120, 41);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(135, 20);
            this.txt_UserID.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "User ID : ";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(120, 3);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(135, 20);
            this.txt_ServerName.TabIndex = 29;
            // 
            // chk_LocalServer
            // 
            this.chk_LocalServer.AutoSize = true;
            this.chk_LocalServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_LocalServer.Location = new System.Drawing.Point(261, 5);
            this.chk_LocalServer.Name = "chk_LocalServer";
            this.chk_LocalServer.Size = new System.Drawing.Size(98, 17);
            this.chk_LocalServer.TabIndex = 31;
            this.chk_LocalServer.Text = "Local Server";
            this.chk_LocalServer.UseVisualStyleBackColor = true;
            this.chk_LocalServer.CheckedChanged += new System.EventHandler(this.chk_LocalServer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Server Name : ";
            // 
            // txt_CreatNewDataBase
            // 
            this.txt_CreatNewDataBase.Location = new System.Drawing.Point(226, 148);
            this.txt_CreatNewDataBase.Name = "txt_CreatNewDataBase";
            this.txt_CreatNewDataBase.Size = new System.Drawing.Size(100, 20);
            this.txt_CreatNewDataBase.TabIndex = 42;
            this.txt_CreatNewDataBase.Visible = false;
            this.txt_CreatNewDataBase.TextChanged += new System.EventHandler(this.txt_CreatNewDataBase_TextChanged);
            // 
            // LkLb_Cancel
            // 
            this.LkLb_Cancel.AutoSize = true;
            this.LkLb_Cancel.LinkColor = System.Drawing.Color.Black;
            this.LkLb_Cancel.Location = new System.Drawing.Point(230, 170);
            this.LkLb_Cancel.Name = "LkLb_Cancel";
            this.LkLb_Cancel.Size = new System.Drawing.Size(40, 13);
            this.LkLb_Cancel.TabIndex = 43;
            this.LkLb_Cancel.TabStop = true;
            this.LkLb_Cancel.Text = "Cancel";
            this.LkLb_Cancel.Visible = false;
            this.LkLb_Cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLb_Cancel_LinkClicked);
            // 
            // LkLb_Create
            // 
            this.LkLb_Create.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.LkLb_Create.AutoSize = true;
            this.LkLb_Create.LinkColor = System.Drawing.Color.Black;
            this.LkLb_Create.Location = new System.Drawing.Point(284, 170);
            this.LkLb_Create.Name = "LkLb_Create";
            this.LkLb_Create.Size = new System.Drawing.Size(38, 13);
            this.LkLb_Create.TabIndex = 44;
            this.LkLb_Create.TabStop = true;
            this.LkLb_Create.Text = "Create";
            this.LkLb_Create.Visible = false;
            this.LkLb_Create.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLb_Create_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_clsUpdateConnectionInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LkLb_Create);
            this.Controls.Add(this.LkLb_Cancel);
            this.Controls.Add(this.txt_CreatNewDataBase);
            this.Controls.Add(this.Chk_RemembreMe);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comb_ChoseDatabase);
            this.Controls.Add(this.btn_CreateNewDataBase);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.chk_LocalServer);
            this.Controls.Add(this.label3);
            this.Name = "UC_clsUpdateConnectionInfos";
            this.Size = new System.Drawing.Size(356, 229);
            this.Load += new System.EventHandler(this.UC_clsUpdateConnectionInfos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_RemembreMe;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Comb_ChoseDatabase;
        private System.Windows.Forms.Button btn_CreateNewDataBase;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.CheckBox chk_LocalServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CreatNewDataBase;
        private System.Windows.Forms.LinkLabel LkLb_Cancel;
        private System.Windows.Forms.LinkLabel LkLb_Create;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
