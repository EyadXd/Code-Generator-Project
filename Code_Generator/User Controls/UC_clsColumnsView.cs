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
    public partial class UC_clsColumnsView : UserControl
    {
        public UC_clsColumnsView()
        {
            InitializeComponent();
        }

        public void View(string TableName)
        {
            dgv_Columnsinfos.DataSource = clsColumn.ListColumns(TableName);
            ShowOnlyPropertiesColumns();
        }
        public void View(clsTable Table)
        {
            dgv_Columnsinfos.DataSource = Table.Columns;
            ShowOnlyPropertiesColumns();
        }
        public void ShowOnlyPropertiesColumns()
        {
            try
            {
                dgv_Columnsinfos.Columns.Remove("Find_By");
                dgv_Columnsinfos.Columns.Remove("Delete_By");
                dgv_Columnsinfos.Columns.Remove("IsExists_By");
            }
            catch
            {

            }
        }
        public string SelectedValue()
        {
            if ((dgv_Columnsinfos.CurrentCell == null))
                return "";

            if ((dgv_Columnsinfos.CurrentCell.RowIndex == -1 && dgv_Columnsinfos.CurrentCell.ColumnIndex == -1))
            {
                return "";
            }
            else
            {
                return dgv_Columnsinfos.Rows[dgv_Columnsinfos.CurrentCell.RowIndex].Cells["COLUMN_NAME"].Value.ToString();
            }
        }
    }
}
