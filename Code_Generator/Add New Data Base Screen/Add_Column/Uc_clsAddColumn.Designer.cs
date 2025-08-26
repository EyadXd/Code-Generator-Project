
namespace Code_Generator.Add_New_Data_Base_Screen.Add_Column
{
    partial class Uc_clsAddColumn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ColumnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_IsNullable = new System.Windows.Forms.CheckBox();
            this.chk_IsPrimary = new System.Windows.Forms.CheckBox();
            this.chk_IsIdentity = new System.Windows.Forms.CheckBox();
            this.Comb_DataType = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_MaxLength = new System.Windows.Forms.TextBox();
            this.lb_MaxLength = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name";
            // 
            // txt_ColumnName
            // 
            this.txt_ColumnName.Location = new System.Drawing.Point(3, 28);
            this.txt_ColumnName.Name = "txt_ColumnName";
            this.txt_ColumnName.Size = new System.Drawing.Size(151, 20);
            this.txt_ColumnName.TabIndex = 1;
            this.txt_ColumnName.TextChanged += new System.EventHandler(this.txt_ColumnName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Column Type";
            // 
            // chk_IsNullable
            // 
            this.chk_IsNullable.AutoSize = true;
            this.chk_IsNullable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_IsNullable.Location = new System.Drawing.Point(360, 8);
            this.chk_IsNullable.Name = "chk_IsNullable";
            this.chk_IsNullable.Size = new System.Drawing.Size(101, 20);
            this.chk_IsNullable.TabIndex = 4;
            this.chk_IsNullable.Text = "Is Nullable";
            this.chk_IsNullable.UseVisualStyleBackColor = true;
            // 
            // chk_IsPrimary
            // 
            this.chk_IsPrimary.AutoSize = true;
            this.chk_IsPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_IsPrimary.Location = new System.Drawing.Point(360, 28);
            this.chk_IsPrimary.Name = "chk_IsPrimary";
            this.chk_IsPrimary.Size = new System.Drawing.Size(96, 20);
            this.chk_IsPrimary.TabIndex = 5;
            this.chk_IsPrimary.Text = "Is Primary";
            this.chk_IsPrimary.UseVisualStyleBackColor = true;
            this.chk_IsPrimary.CheckedChanged += new System.EventHandler(this.chk_IsPrimary_CheckedChanged);
            // 
            // chk_IsIdentity
            // 
            this.chk_IsIdentity.AutoSize = true;
            this.chk_IsIdentity.Enabled = false;
            this.chk_IsIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_IsIdentity.Location = new System.Drawing.Point(464, 8);
            this.chk_IsIdentity.Name = "chk_IsIdentity";
            this.chk_IsIdentity.Size = new System.Drawing.Size(93, 20);
            this.chk_IsIdentity.TabIndex = 6;
            this.chk_IsIdentity.Text = "Is Identity";
            this.chk_IsIdentity.UseVisualStyleBackColor = true;
            // 
            // Comb_DataType
            // 
            this.Comb_DataType.AutoCompleteCustomSource.AddRange(new string[] {
            "char",
            "varchar",
            "varchar(max)",
            "text",
            "ntext",
            "nchar",
            "nvarchar",
            "nvarchar(max)",
            "ntext",
            "binary",
            "bit",
            "tinyint",
            "smallint",
            "int",
            "bigint",
            "decimal",
            "numeric",
            "smallmoney",
            "money",
            "float",
            "real",
            "date",
            "datetime",
            "datetime2",
            "smalldatetime",
            "time",
            "timestamp"});
            this.Comb_DataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_DataType.FormattingEnabled = true;
            this.Comb_DataType.Items.AddRange(new object[] {
            "char",
            "varchar",
            "text",
            "ntext",
            "nchar",
            "nvarchar",
            "ntext",
            "binary",
            "bit",
            "tinyint",
            "smallint",
            "int",
            "bigint",
            "decimal",
            "numeric",
            "smallmoney",
            "money",
            "float",
            "real",
            "date",
            "datetime",
            "datetime2",
            "smalldatetime",
            "time",
            "timestamp"});
            this.Comb_DataType.Location = new System.Drawing.Point(179, 28);
            this.Comb_DataType.Name = "Comb_DataType";
            this.Comb_DataType.Size = new System.Drawing.Size(151, 21);
            this.Comb_DataType.TabIndex = 7;
            this.Comb_DataType.SelectedIndexChanged += new System.EventHandler(this.Comb_DataType_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(525, 71);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 30);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_MaxLength
            // 
            this.txt_MaxLength.Location = new System.Drawing.Point(204, 73);
            this.txt_MaxLength.Name = "txt_MaxLength";
            this.txt_MaxLength.Size = new System.Drawing.Size(100, 20);
            this.txt_MaxLength.TabIndex = 9;
            this.txt_MaxLength.Visible = false;
            // 
            // lb_MaxLength
            // 
            this.lb_MaxLength.AutoSize = true;
            this.lb_MaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaxLength.Location = new System.Drawing.Point(218, 59);
            this.lb_MaxLength.Name = "lb_MaxLength";
            this.lb_MaxLength.Size = new System.Drawing.Size(73, 13);
            this.lb_MaxLength.TabIndex = 10;
            this.lb_MaxLength.Text = "Max Length";
            this.lb_MaxLength.Visible = false;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(3, 72);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(195, 20);
            this.txt_Description.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
            // 
            // Uc_clsAddColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lb_MaxLength);
            this.Controls.Add(this.txt_MaxLength);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Comb_DataType);
            this.Controls.Add(this.chk_IsIdentity);
            this.Controls.Add(this.chk_IsPrimary);
            this.Controls.Add(this.chk_IsNullable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ColumnName);
            this.Controls.Add(this.label1);
            this.Name = "Uc_clsAddColumn";
            this.Size = new System.Drawing.Size(620, 102);
            this.Load += new System.EventHandler(this.Uc_clsAddColumn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_IsNullable;
        private System.Windows.Forms.CheckBox chk_IsPrimary;
        private System.Windows.Forms.CheckBox chk_IsIdentity;
        private System.Windows.Forms.ComboBox Comb_DataType;
        private System.Windows.Forms.TextBox txt_ColumnName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lb_MaxLength;
        private System.Windows.Forms.TextBox txt_MaxLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Description;
    }
}
