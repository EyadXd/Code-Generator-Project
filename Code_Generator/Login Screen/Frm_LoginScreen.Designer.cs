
namespace Code_Generator.Login_Screen
{
    partial class Frm_LoginScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_clsUpdateConnectionInfos1 = new Code_Generator.Login_Screen.UC_clsUpdateConnectionInfos();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(115, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "  To Start Generating Your Code\r\nPlease Fill Requierd Informations";
            // 
            // uC_clsUpdateConnectionInfos1
            // 
            this.uC_clsUpdateConnectionInfos1.Location = new System.Drawing.Point(34, 101);
            this.uC_clsUpdateConnectionInfos1.Name = "uC_clsUpdateConnectionInfos1";
            this.uC_clsUpdateConnectionInfos1.Size = new System.Drawing.Size(358, 228);
            this.uC_clsUpdateConnectionInfos1.TabIndex = 0;
            this.uC_clsUpdateConnectionInfos1.OnLogin += new System.Action(this.uC_clsUpdateConnectionInfos1_OnLogin);
            this.uC_clsUpdateConnectionInfos1.OnCreateNewDataBase += new System.Action(this.uC_clsUpdateConnectionInfos1_OnCreateNewDataBase);
            // 
            // Frm_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uC_clsUpdateConnectionInfos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_LoginScreen";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_clsUpdateConnectionInfos uC_clsUpdateConnectionInfos1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}