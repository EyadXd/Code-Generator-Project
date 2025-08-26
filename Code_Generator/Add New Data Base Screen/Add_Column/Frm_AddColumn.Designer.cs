
namespace Code_Generator.Add_New_Data_Base_Screen.Add_Column
{
    partial class Frm_AddColumn
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.uc_clsAddColumn1 = new Code_Generator.Add_New_Data_Base_Screen.Add_Column.Uc_clsAddColumn();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(428, 73);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 30);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Close";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // uc_clsAddColumn1
            // 
            this.uc_clsAddColumn1.Location = new System.Drawing.Point(2, 2);
            this.uc_clsAddColumn1.Name = "uc_clsAddColumn1";
            this.uc_clsAddColumn1.Size = new System.Drawing.Size(620, 106);
            this.uc_clsAddColumn1.TabIndex = 0;
            // 
            // Frm_AddColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 112);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.uc_clsAddColumn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AddColumn";
            this.Text = "Add New Column";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_clsAddColumn uc_clsAddColumn1;
        private System.Windows.Forms.Button btn_Add;
    }
}