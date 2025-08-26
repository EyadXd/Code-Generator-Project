
namespace Code_Generator.Add_New_Data_Base_Screen
{
    partial class Frm_AddNewDataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewTable = new System.Windows.Forms.Button();
            this.btn_AddNewColumn = new System.Windows.Forms.Button();
            this.lb_DataBaseName = new System.Windows.Forms.Label();
            this.txt_AddNewTable = new System.Windows.Forms.TextBox();
            this.LkLb_Cancel = new System.Windows.Forms.LinkLabel();
            this.LkLb_Confirm = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uC_clsColumnsView1 = new Code_Generator.User_Controls.UC_clsColumnsView();
            this.uC_clsTablesNamesView1 = new Code_Generator.User_Controls.UC_clsTablesNamesView();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_DeleteColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Base Name :";
            // 
            // btn_AddNewTable
            // 
            this.btn_AddNewTable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewTable.Location = new System.Drawing.Point(5, 407);
            this.btn_AddNewTable.Name = "btn_AddNewTable";
            this.btn_AddNewTable.Size = new System.Drawing.Size(174, 25);
            this.btn_AddNewTable.TabIndex = 5;
            this.btn_AddNewTable.Text = "Add New Table";
            this.btn_AddNewTable.UseVisualStyleBackColor = true;
            this.btn_AddNewTable.Click += new System.EventHandler(this.btn_AddNewTable_Click);
            // 
            // btn_AddNewColumn
            // 
            this.btn_AddNewColumn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewColumn.Location = new System.Drawing.Point(755, 407);
            this.btn_AddNewColumn.Name = "btn_AddNewColumn";
            this.btn_AddNewColumn.Size = new System.Drawing.Size(174, 25);
            this.btn_AddNewColumn.TabIndex = 6;
            this.btn_AddNewColumn.Text = "Add New Column";
            this.btn_AddNewColumn.UseVisualStyleBackColor = true;
            this.btn_AddNewColumn.Click += new System.EventHandler(this.btn_AddNewColumn_Click);
            // 
            // lb_DataBaseName
            // 
            this.lb_DataBaseName.AutoSize = true;
            this.lb_DataBaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataBaseName.Location = new System.Drawing.Point(132, 3);
            this.lb_DataBaseName.Name = "lb_DataBaseName";
            this.lb_DataBaseName.Size = new System.Drawing.Size(49, 17);
            this.lb_DataBaseName.TabIndex = 7;
            this.lb_DataBaseName.Text = "Name";
            // 
            // txt_AddNewTable
            // 
            this.txt_AddNewTable.Location = new System.Drawing.Point(5, 434);
            this.txt_AddNewTable.Name = "txt_AddNewTable";
            this.txt_AddNewTable.Size = new System.Drawing.Size(174, 20);
            this.txt_AddNewTable.TabIndex = 8;
            this.txt_AddNewTable.Visible = false;
            this.txt_AddNewTable.TextChanged += new System.EventHandler(this.txt_AddNewTable_TextChanged);
            // 
            // LkLb_Cancel
            // 
            this.LkLb_Cancel.AutoSize = true;
            this.LkLb_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLb_Cancel.Location = new System.Drawing.Point(27, 457);
            this.LkLb_Cancel.Name = "LkLb_Cancel";
            this.LkLb_Cancel.Size = new System.Drawing.Size(50, 16);
            this.LkLb_Cancel.TabIndex = 9;
            this.LkLb_Cancel.TabStop = true;
            this.LkLb_Cancel.Text = "Cancel";
            this.LkLb_Cancel.Visible = false;
            this.LkLb_Cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLb_Cancel_LinkClicked);
            // 
            // LkLb_Confirm
            // 
            this.LkLb_Confirm.ActiveLinkColor = System.Drawing.Color.Green;
            this.LkLb_Confirm.AutoSize = true;
            this.LkLb_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLb_Confirm.Location = new System.Drawing.Point(98, 457);
            this.LkLb_Confirm.Name = "LkLb_Confirm";
            this.LkLb_Confirm.Size = new System.Drawing.Size(53, 16);
            this.LkLb_Confirm.TabIndex = 10;
            this.LkLb_Confirm.TabStop = true;
            this.LkLb_Confirm.Text = "Confirm";
            this.LkLb_Confirm.Visible = false;
            this.LkLb_Confirm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLb_Confirm_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uC_clsColumnsView1
            // 
            this.uC_clsColumnsView1.Location = new System.Drawing.Point(274, 122);
            this.uC_clsColumnsView1.Name = "uC_clsColumnsView1";
            this.uC_clsColumnsView1.Size = new System.Drawing.Size(655, 282);
            this.uC_clsColumnsView1.TabIndex = 4;
            // 
            // uC_clsTablesNamesView1
            // 
            this.uC_clsTablesNamesView1.Location = new System.Drawing.Point(5, 61);
            this.uC_clsTablesNamesView1.Name = "uC_clsTablesNamesView1";
            this.uC_clsTablesNamesView1.Size = new System.Drawing.Size(174, 343);
            this.uC_clsTablesNamesView1.TabIndex = 3;
            this.uC_clsTablesNamesView1.OnSelectedValueChanged += new System.Action(this.uC_clsTablesNamesView1_OnSelectedValueChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(828, 462);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(101, 25);
            this.btn_Create.TabIndex = 11;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_DeleteColumn
            // 
            this.btn_DeleteColumn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteColumn.Location = new System.Drawing.Point(675, 407);
            this.btn_DeleteColumn.Name = "btn_DeleteColumn";
            this.btn_DeleteColumn.Size = new System.Drawing.Size(74, 25);
            this.btn_DeleteColumn.TabIndex = 12;
            this.btn_DeleteColumn.Text = "Delete";
            this.btn_DeleteColumn.UseVisualStyleBackColor = true;
            this.btn_DeleteColumn.Click += new System.EventHandler(this.btn_DeleteColumn_Click);
            // 
            // Frm_AddNewDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 499);
            this.Controls.Add(this.btn_DeleteColumn);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.LkLb_Confirm);
            this.Controls.Add(this.LkLb_Cancel);
            this.Controls.Add(this.txt_AddNewTable);
            this.Controls.Add(this.lb_DataBaseName);
            this.Controls.Add(this.btn_AddNewColumn);
            this.Controls.Add(this.btn_AddNewTable);
            this.Controls.Add(this.uC_clsColumnsView1);
            this.Controls.Add(this.uC_clsTablesNamesView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AddNewDataBase";
            this.Text = "Add New Database";
            this.Load += new System.EventHandler(this.Frm_AddNewDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private User_Controls.UC_clsColumnsView uC_clsColumnsView1;
        private User_Controls.UC_clsTablesNamesView uC_clsTablesNamesView1;
        private System.Windows.Forms.Button btn_AddNewTable;
        private System.Windows.Forms.Button btn_AddNewColumn;
        private System.Windows.Forms.Label lb_DataBaseName;
        private System.Windows.Forms.TextBox txt_AddNewTable;
        private System.Windows.Forms.LinkLabel LkLb_Cancel;
        private System.Windows.Forms.LinkLabel LkLb_Confirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_DeleteColumn;
    }
}