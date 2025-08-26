
namespace Code_Generator.User_Controls
{
    partial class UC_clsTablesNamesView
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
            this.Dgv_TableNames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableNames)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_TableNames
            // 
            this.Dgv_TableNames.AllowUserToAddRows = false;
            this.Dgv_TableNames.AllowUserToDeleteRows = false;
            this.Dgv_TableNames.AllowUserToResizeColumns = false;
            this.Dgv_TableNames.AllowUserToResizeRows = false;
            this.Dgv_TableNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TableNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TableNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_TableNames.Location = new System.Drawing.Point(0, 0);
            this.Dgv_TableNames.MultiSelect = false;
            this.Dgv_TableNames.Name = "Dgv_TableNames";
            this.Dgv_TableNames.ReadOnly = true;
            this.Dgv_TableNames.RowHeadersVisible = false;
            this.Dgv_TableNames.Size = new System.Drawing.Size(114, 305);
            this.Dgv_TableNames.TabIndex = 0;
            this.Dgv_TableNames.SelectionChanged += new System.EventHandler(this.Dgv_TableNames_SelectionChanged);
            // 
            // UC_clsTablesNamesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dgv_TableNames);
            this.Name = "UC_clsTablesNamesView";
            this.Size = new System.Drawing.Size(114, 305);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableNames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_TableNames;
    }
}
