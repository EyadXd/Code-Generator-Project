using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Generator.Add_New_Data_Base_Screen;

namespace Code_Generator.Login_Screen
{
    public partial class Frm_LoginScreen : Form
    {
        public Frm_LoginScreen()
        {
            InitializeComponent();
        }

        private void uC_clsUpdateConnectionInfos1_OnLogin()
        {
            this.Hide();
            MainFormApp Form = new MainFormApp();
            Form.ShowDialog();
            this.Show();
        }

        private void uC_clsUpdateConnectionInfos1_OnCreateNewDataBase()
        {
            this.Hide();
            Frm_AddNewDataBase Form = new Frm_AddNewDataBase();
            Form.ShowDialog();
            this.Show();
        }
    }
}
