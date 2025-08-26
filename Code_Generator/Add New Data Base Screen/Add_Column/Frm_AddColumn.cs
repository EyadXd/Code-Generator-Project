using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables_Logic_Layer;

namespace Code_Generator.Add_New_Data_Base_Screen.Add_Column
{
    public partial class Frm_AddColumn : Form
    {
        public Frm_AddColumn(clsTable Table)
        {
            InitializeComponent();
            uc_clsAddColumn1.SendTable(Table);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
