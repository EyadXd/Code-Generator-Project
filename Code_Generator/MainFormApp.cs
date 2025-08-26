using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General_Settings;
using Code_Generator.Code_Settings;

namespace Code_Generator
{
    public partial class MainFormApp : Form
    {
        public MainFormApp()
        {
            InitializeComponent();
        }

        private void MainFormApp_Load(object sender, EventArgs e)
        {
            uC_clsTablesNamesView1.View();
        }

        private void lb_ConnectionString_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Would You Like To Copy The Connection String : \n" + clsConnectionInfos.ConnectionString(),"Connection String",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clipboard.SetText(clsConnectionInfos.ConnectionString());
            }
        }

        private void uC_clsTablesNamesView1_OnSelectedValueChanged()
        {
            uC_clsColumnsView1.View(uC_clsTablesNamesView1.SelectedValue());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(uC_clsTablesNamesView1.SelectedValue()))
            {
                MessageBox.Show("You Have To Selecet At Least One Table", "Select Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Frm_CodeGeneratingSettings Form = new Frm_CodeGeneratingSettings(uC_clsTablesNamesView1.SelectedValue());
            Form.ShowDialog();
        }
    }
}
