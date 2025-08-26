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
using System.Text.RegularExpressions;
using General_Settings;
using Code_Generator.Add_New_Data_Base_Screen.Add_Column;
using Database_Creator;

namespace Code_Generator.Add_New_Data_Base_Screen
{
    
    public partial class Frm_AddNewDataBase : Form
    {
        clsDataBase DataBase = new clsDataBase(clsConnectionInfos.DataBaseName);

        static bool ContainsNonChar(string input)
        {
            // Regular expression pattern to match anything that is not a letter
            Regex regex = new Regex("[^a-zA-Z]");

            // Check if input contains any character that matches the pattern
            return regex.IsMatch(input);
        }

        private void _ChangeUAddNewTableSettings(bool Visable)
        {
            LkLb_Confirm.Visible = Visable;
            LkLb_Cancel.Visible = Visable;
            txt_AddNewTable.Visible = Visable;
        }
        public Frm_AddNewDataBase()
        {
            InitializeComponent();
        }

        private void btn_AddNewTable_Click(object sender, EventArgs e)
        {
            _ChangeUAddNewTableSettings(true);

        }

        private void LkLb_Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_AddNewTable.Text = "";
            _ChangeUAddNewTableSettings(false);
        }

        private void txt_AddNewTable_TextChanged(object sender, EventArgs e)
        {
            if (ContainsNonChar(txt_AddNewTable.Text))
            {
                LkLb_Confirm.Enabled = false;
                errorProvider1.SetError(txt_AddNewTable, "Only Chars");
            }
            else
            {
                LkLb_Confirm.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void Frm_AddNewDataBase_Load(object sender, EventArgs e)
        {
            lb_DataBaseName.Text = clsConnectionInfos.DataBaseName;
            uC_clsTablesNamesView1.View(DataBase);
        }

        private void LkLb_Confirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (String.IsNullOrEmpty(txt_AddNewTable.Text))
            {
                MessageBox.Show("Not Valid Table Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((DataBase.Tables.Any(c => c.TableName == txt_AddNewTable.Text)))
            {
                MessageBox.Show("This Table Is Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBase.Tables.Add(new clsTable(txt_AddNewTable.Text));
        }

        private void btn_AddNewColumn_Click(object sender, EventArgs e)
        {
            string Name = uC_clsTablesNamesView1.SelectedValue();

            if (!String.IsNullOrEmpty(Name))
            {
                Frm_AddColumn Form = new Frm_AddColumn(DataBase.Tables.First(c => c.TableName == Name));
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select Table To Add Column To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void uC_clsTablesNamesView1_OnSelectedValueChanged()
        {
            uC_clsColumnsView1.View(DataBase.Tables.First(c => c.TableName == uC_clsTablesNamesView1.SelectedValue()));
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (DataBase.Tables.Count==0)
            {
                MessageBox.Show("Cannot Create Empty Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataBase.Tables.Any(c=>c.Columns.Count==0))
            {
                MessageBox.Show("Cannot Create Empty Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DataBase.Tables.Any(c => c.Columns.Any(d=>d.IsPrimaryKey)))
            {
                MessageBox.Show("Cannot Create Table Without Primary Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsDatabaseCreator.Create(DataBase))
            {
                MessageBox.Show("This Database Added Successfuly", "Done", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                try
                {
                    clsDataBase.DeleteDataBase(DataBase.DataBaseName);
                }
                catch
                {

                }
                MessageBox.Show("Cannot Add This Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_DeleteColumn_Click(object sender, EventArgs e)
        {
            String ColumnName = uC_clsColumnsView1.SelectedValue();

            if (String.IsNullOrEmpty(ColumnName))
            {
                MessageBox.Show("Select Column To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                clsTable CurrentTable = DataBase.Tables.First(c => c.TableName == uC_clsTablesNamesView1.SelectedValue());
                CurrentTable.Columns.Remove(CurrentTable.Columns.First(c => c.COLUMN_NAME == ColumnName));

            }
        }
    }
}
