using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Code_Generator.Code_Settings
{
    public partial class Frm_CodeGeneratingChoice : Form
    {
        public delegate void ReturnChoiceDelegate(string Choice);
        public ReturnChoiceDelegate ReturnChoice;

        public Frm_CodeGeneratingChoice()
        {
            InitializeComponent();
        }

        private void Frm_CodeGeneratingChoice_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            ReturnChoice.Invoke(rd_BothLayers.Checked?rd_BothLayers.Text:rd_DataLayer.Checked?rd_DataLayer.Text:rd_LogicLayer.Text);
            this.Close();
        }
    }
}
