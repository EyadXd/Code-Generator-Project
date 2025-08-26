
namespace Code_Generator
{
    partial class MainFormApp
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
            this.lb_ConnectionString = new System.Windows.Forms.Label();
            this.uC_clsColumnsView1 = new Code_Generator.User_Controls.UC_clsColumnsView();
            this.uC_clsTablesNamesView1 = new Code_Generator.User_Controls.UC_clsTablesNamesView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ConnectionString
            // 
            this.lb_ConnectionString.AutoSize = true;
            this.lb_ConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConnectionString.Location = new System.Drawing.Point(38, 1);
            this.lb_ConnectionString.Name = "lb_ConnectionString";
            this.lb_ConnectionString.Size = new System.Drawing.Size(108, 13);
            this.lb_ConnectionString.TabIndex = 0;
            this.lb_ConnectionString.Text = "Connection String";
            this.lb_ConnectionString.Click += new System.EventHandler(this.lb_ConnectionString_Click);
            // 
            // uC_clsColumnsView1
            // 
            this.uC_clsColumnsView1.Location = new System.Drawing.Point(276, 91);
            this.uC_clsColumnsView1.Name = "uC_clsColumnsView1";
            this.uC_clsColumnsView1.Size = new System.Drawing.Size(697, 282);
            this.uC_clsColumnsView1.TabIndex = 2;
            // 
            // uC_clsTablesNamesView1
            // 
            this.uC_clsTablesNamesView1.Location = new System.Drawing.Point(7, 30);
            this.uC_clsTablesNamesView1.Name = "uC_clsTablesNamesView1";
            this.uC_clsTablesNamesView1.Size = new System.Drawing.Size(174, 343);
            this.uC_clsTablesNamesView1.TabIndex = 1;
            this.uC_clsTablesNamesView1.OnSelectedValueChanged += new System.Action(this.uC_clsTablesNamesView1_OnSelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(845, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_clsColumnsView1);
            this.Controls.Add(this.uC_clsTablesNamesView1);
            this.Controls.Add(this.lb_ConnectionString);
            this.Name = "MainFormApp";
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.MainFormApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ConnectionString;
        private User_Controls.UC_clsTablesNamesView uC_clsTablesNamesView1;
        private User_Controls.UC_clsColumnsView uC_clsColumnsView1;
        private System.Windows.Forms.Button button1;
    }
}

