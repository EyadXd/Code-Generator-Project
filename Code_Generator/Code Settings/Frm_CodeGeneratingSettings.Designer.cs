
namespace Code_Generator.Code_Settings
{
    partial class Frm_CodeGeneratingSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TableName = new System.Windows.Forms.Label();
            this.chk_Addnew = new System.Windows.Forms.CheckBox();
            this.chk_ListAllRecords = new System.Windows.Forms.CheckBox();
            this.Dgv_CodeSettings = new System.Windows.Forms.DataGridView();
            this.GenerateCode_Button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chk_Update = new System.Windows.Forms.CheckBox();
            this.txt_BusinessNameSpace = new System.Windows.Forms.TextBox();
            this.txt_DataAccessNameSpace = new System.Windows.Forms.TextBox();
            this.lk_AdjustNameSpaces = new System.Windows.Forms.LinkLabel();
            this.chk_ConnectionString = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CodeSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adjust Your Code ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table Name : ";
            // 
            // lb_TableName
            // 
            this.lb_TableName.AutoSize = true;
            this.lb_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TableName.Location = new System.Drawing.Point(63, 4);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(48, 13);
            this.lb_TableName.TabIndex = 3;
            this.lb_TableName.Text = "UnKnow";
            // 
            // chk_Addnew
            // 
            this.chk_Addnew.AutoSize = true;
            this.chk_Addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Addnew.Location = new System.Drawing.Point(11, 156);
            this.chk_Addnew.Name = "chk_Addnew";
            this.chk_Addnew.Size = new System.Drawing.Size(163, 22);
            this.chk_Addnew.TabIndex = 4;
            this.chk_Addnew.Text = "Add New Function";
            this.chk_Addnew.UseVisualStyleBackColor = true;
            this.chk_Addnew.CheckedChanged += new System.EventHandler(this.chk_Addnew_CheckedChanged);
            // 
            // chk_ListAllRecords
            // 
            this.chk_ListAllRecords.AutoSize = true;
            this.chk_ListAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ListAllRecords.Location = new System.Drawing.Point(294, 156);
            this.chk_ListAllRecords.Name = "chk_ListAllRecords";
            this.chk_ListAllRecords.Size = new System.Drawing.Size(216, 22);
            this.chk_ListAllRecords.TabIndex = 5;
            this.chk_ListAllRecords.Text = "List All Records Function";
            this.chk_ListAllRecords.UseVisualStyleBackColor = true;
            // 
            // Dgv_CodeSettings
            // 
            this.Dgv_CodeSettings.AllowUserToAddRows = false;
            this.Dgv_CodeSettings.AllowUserToDeleteRows = false;
            this.Dgv_CodeSettings.AllowUserToResizeColumns = false;
            this.Dgv_CodeSettings.AllowUserToResizeRows = false;
            this.Dgv_CodeSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CodeSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CodeSettings.Location = new System.Drawing.Point(0, 184);
            this.Dgv_CodeSettings.Name = "Dgv_CodeSettings";
            this.Dgv_CodeSettings.RowHeadersVisible = false;
            this.Dgv_CodeSettings.Size = new System.Drawing.Size(797, 260);
            this.Dgv_CodeSettings.TabIndex = 6;
            this.Dgv_CodeSettings.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Dgv_CodeSettings_CellBeginEdit);
            this.Dgv_CodeSettings.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CodeSettings_CellMouseDoubleClick);
            // 
            // GenerateCode_Button
            // 
            this.GenerateCode_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCode_Button.Location = new System.Drawing.Point(669, 450);
            this.GenerateCode_Button.Name = "GenerateCode_Button";
            this.GenerateCode_Button.Size = new System.Drawing.Size(128, 31);
            this.GenerateCode_Button.TabIndex = 7;
            this.GenerateCode_Button.Text = "Generate Code";
            this.GenerateCode_Button.UseVisualStyleBackColor = true;
            this.GenerateCode_Button.Click += new System.EventHandler(this.btn_GenerateCode);
            // 
            // chk_Update
            // 
            this.chk_Update.AutoSize = true;
            this.chk_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Update.Location = new System.Drawing.Point(647, 156);
            this.chk_Update.Name = "chk_Update";
            this.chk_Update.Size = new System.Drawing.Size(150, 22);
            this.chk_Update.TabIndex = 8;
            this.chk_Update.Text = "Update Function";
            this.chk_Update.UseVisualStyleBackColor = true;
            this.chk_Update.CheckedChanged += new System.EventHandler(this.chk_Addnew_CheckedChanged);
            // 
            // txt_BusinessNameSpace
            // 
            this.txt_BusinessNameSpace.Location = new System.Drawing.Point(669, 51);
            this.txt_BusinessNameSpace.Name = "txt_BusinessNameSpace";
            this.txt_BusinessNameSpace.Size = new System.Drawing.Size(128, 20);
            this.txt_BusinessNameSpace.TabIndex = 9;
            this.txt_BusinessNameSpace.Visible = false;
            this.txt_BusinessNameSpace.Enter += new System.EventHandler(this.txt_BusinessNameSpace_Enter);
            this.txt_BusinessNameSpace.Leave += new System.EventHandler(this.txt_BusinessNameSpace_Leave);
            // 
            // txt_DataAccessNameSpace
            // 
            this.txt_DataAccessNameSpace.Location = new System.Drawing.Point(669, 25);
            this.txt_DataAccessNameSpace.Name = "txt_DataAccessNameSpace";
            this.txt_DataAccessNameSpace.Size = new System.Drawing.Size(128, 20);
            this.txt_DataAccessNameSpace.TabIndex = 10;
            this.txt_DataAccessNameSpace.Visible = false;
            this.txt_DataAccessNameSpace.Enter += new System.EventHandler(this.txt_BusinessNameSpace_Enter);
            this.txt_DataAccessNameSpace.Leave += new System.EventHandler(this.txt_BusinessNameSpace_Leave);
            // 
            // lk_AdjustNameSpaces
            // 
            this.lk_AdjustNameSpaces.AutoSize = true;
            this.lk_AdjustNameSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk_AdjustNameSpaces.Location = new System.Drawing.Point(674, 9);
            this.lk_AdjustNameSpaces.Name = "lk_AdjustNameSpaces";
            this.lk_AdjustNameSpaces.Size = new System.Drawing.Size(118, 13);
            this.lk_AdjustNameSpaces.TabIndex = 11;
            this.lk_AdjustNameSpaces.TabStop = true;
            this.lk_AdjustNameSpaces.Text = "Adjust Namespaces";
            this.lk_AdjustNameSpaces.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_AdjustNameSpaces_LinkClicked);
            // 
            // chk_ConnectionString
            // 
            this.chk_ConnectionString.AutoSize = true;
            this.chk_ConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ConnectionString.Location = new System.Drawing.Point(469, 454);
            this.chk_ConnectionString.Name = "chk_ConnectionString";
            this.chk_ConnectionString.Size = new System.Drawing.Size(194, 22);
            this.chk_ConnectionString.TabIndex = 12;
            this.chk_ConnectionString.Text = "Connection String File";
            this.chk_ConnectionString.UseVisualStyleBackColor = true;
            // 
            // Frm_CodeGeneratingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.chk_ConnectionString);
            this.Controls.Add(this.lk_AdjustNameSpaces);
            this.Controls.Add(this.txt_DataAccessNameSpace);
            this.Controls.Add(this.txt_BusinessNameSpace);
            this.Controls.Add(this.chk_Update);
            this.Controls.Add(this.GenerateCode_Button);
            this.Controls.Add(this.Dgv_CodeSettings);
            this.Controls.Add(this.chk_ListAllRecords);
            this.Controls.Add(this.chk_Addnew);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_CodeGeneratingSettings";
            this.Text = "Code Settings";
            this.Load += new System.EventHandler(this.Frm_CodeGeneratingSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CodeSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TableName;
        private System.Windows.Forms.CheckBox chk_Addnew;
        private System.Windows.Forms.CheckBox chk_ListAllRecords;
        private System.Windows.Forms.DataGridView Dgv_CodeSettings;
        private System.Windows.Forms.Button GenerateCode_Button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chk_Update;
        private System.Windows.Forms.TextBox txt_BusinessNameSpace;
        private System.Windows.Forms.TextBox txt_DataAccessNameSpace;
        private System.Windows.Forms.LinkLabel lk_AdjustNameSpaces;
        private System.Windows.Forms.CheckBox chk_ConnectionString;
    }
}