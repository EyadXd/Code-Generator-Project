
namespace Code_Generator.Code_Settings
{
    partial class Frm_CodeGeneratingChoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.rd_BothLayers = new System.Windows.Forms.RadioButton();
            this.rd_LogicLayer = new System.Windows.Forms.RadioButton();
            this.rd_DataLayer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Controls.Add(this.rd_BothLayers);
            this.groupBox1.Controls.Add(this.rd_LogicLayer);
            this.groupBox1.Controls.Add(this.rd_DataLayer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generate Code For : ";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(128, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(204, 130);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // rd_BothLayers
            // 
            this.rd_BothLayers.AutoSize = true;
            this.rd_BothLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_BothLayers.Location = new System.Drawing.Point(188, 87);
            this.rd_BothLayers.Name = "rd_BothLayers";
            this.rd_BothLayers.Size = new System.Drawing.Size(92, 17);
            this.rd_BothLayers.TabIndex = 2;
            this.rd_BothLayers.TabStop = true;
            this.rd_BothLayers.Text = "Both Layers";
            this.rd_BothLayers.UseVisualStyleBackColor = true;
            // 
            // rd_LogicLayer
            // 
            this.rd_LogicLayer.AutoSize = true;
            this.rd_LogicLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_LogicLayer.Location = new System.Drawing.Point(95, 87);
            this.rd_LogicLayer.Name = "rd_LogicLayer";
            this.rd_LogicLayer.Size = new System.Drawing.Size(91, 17);
            this.rd_LogicLayer.TabIndex = 1;
            this.rd_LogicLayer.TabStop = true;
            this.rd_LogicLayer.Text = "Logic Layer";
            this.rd_LogicLayer.UseVisualStyleBackColor = true;
            // 
            // rd_DataLayer
            // 
            this.rd_DataLayer.AutoSize = true;
            this.rd_DataLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_DataLayer.Location = new System.Drawing.Point(3, 87);
            this.rd_DataLayer.Name = "rd_DataLayer";
            this.rd_DataLayer.Size = new System.Drawing.Size(87, 17);
            this.rd_DataLayer.TabIndex = 0;
            this.rd_DataLayer.TabStop = true;
            this.rd_DataLayer.Text = "Data Layer";
            this.rd_DataLayer.UseVisualStyleBackColor = true;
            // 
            // Frm_CodeGeneratingChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 152);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CodeGeneratingChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CodeGeneratingChoice";
            this.Load += new System.EventHandler(this.Frm_CodeGeneratingChoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.RadioButton rd_BothLayers;
        private System.Windows.Forms.RadioButton rd_LogicLayer;
        private System.Windows.Forms.RadioButton rd_DataLayer;
        private System.Windows.Forms.Label label1;
    }
}