
namespace Code_Generator.User_Controls
{
    partial class UC_clsColumnsView
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
            this.dgv_Columnsinfos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Columnsinfos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Columnsinfos
            // 
            this.dgv_Columnsinfos.AllowUserToAddRows = false;
            this.dgv_Columnsinfos.AllowUserToDeleteRows = false;
            this.dgv_Columnsinfos.AllowUserToResizeColumns = false;
            this.dgv_Columnsinfos.AllowUserToResizeRows = false;
            this.dgv_Columnsinfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Columnsinfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Columnsinfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Columnsinfos.Location = new System.Drawing.Point(0, 0);
            this.dgv_Columnsinfos.MultiSelect = false;
            this.dgv_Columnsinfos.Name = "dgv_Columnsinfos";
            this.dgv_Columnsinfos.ReadOnly = true;
            this.dgv_Columnsinfos.RowHeadersVisible = false;
            this.dgv_Columnsinfos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Columnsinfos.Size = new System.Drawing.Size(390, 420);
            this.dgv_Columnsinfos.TabIndex = 0;
            // 
            // UC_clsColumnsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Columnsinfos);
            this.Name = "UC_clsColumnsView";
            this.Size = new System.Drawing.Size(390, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Columnsinfos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Columnsinfos;
    }
}
