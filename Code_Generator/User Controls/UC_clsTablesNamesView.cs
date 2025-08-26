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

namespace Code_Generator.User_Controls
{
    public partial class UC_clsTablesNamesView : UserControl
    {
        public event Action OnSelectedValueChanged;
        public virtual void OnSelectedValueChangedEvent()
        {
            Action Handler = OnSelectedValueChanged;
            Handler?.Invoke();
        }
        public UC_clsTablesNamesView()
        {
            InitializeComponent();
        }

        public void View()
        {
            Dgv_TableNames.DataSource=clsTable.GetTablesNames();
        }
        public void View(clsDataBase DataBase)
        {
           Dgv_TableNames.DataSource = DataBase.Tables;
        }

        public string SelectedValue()
        {
            if ((Dgv_TableNames.CurrentCell == null))
                return "";

            if ((Dgv_TableNames.CurrentCell.RowIndex==-1&& Dgv_TableNames.CurrentCell.ColumnIndex == -1))
            {
                return "";
            }
            else
            {
                return Dgv_TableNames.CurrentCell.Value.ToString();
            }
        }

        private void Dgv_TableNames_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectedValueChangedEvent();
        }
    }
}
