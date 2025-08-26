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

namespace Code_Generator.Add_New_Data_Base_Screen.Add_Column
{
    public partial class Uc_clsAddColumn : UserControl
    {

        public event Action<string> OnColumnAddedFaill;
        public virtual void OnColumnAddedFaillEvent(string ErrorMessage)
        {
            Action<string> handelr = OnColumnAddedFaill;
            handelr?.Invoke(ErrorMessage);
        }


        public event Action OnColumnAdded;
        public virtual void OnColumnAddedEvent()
        {
            Action handelr = OnColumnAdded;
            handelr?.Invoke();
        }


        clsTable Table = null;

        string[] DataTypeWithMaxLength = new string[] {"char","nchar","varchar","nvarchar"};

        public Uc_clsAddColumn()
        {
            InitializeComponent();
        }

        public void SendTable(clsTable table)
        {
            Table = table;
        }


       

        static bool ContainsNonChar(string input)
        {
            // Regular expression pattern to match anything that is not a letter
            Regex regex = new Regex("[^a-zA-Z]");

            // Check if input contains any character that matches the pattern
            return regex.IsMatch(input);
        }

        private void txt_ColumnName_TextChanged(object sender, EventArgs e)
        {
            if (ContainsNonChar(txt_ColumnName.Text))
            {
                btn_Add.Enabled = false;
                errorProvider1.SetError(txt_ColumnName, "Only Chars");
            }
            else
            {
                btn_Add.Enabled = true;
                errorProvider1.Clear();
            }
        }

        bool ValidDataType()
        {
            string text = Comb_DataType.SelectedItem.ToString();

            if (!Comb_DataType.Items.Contains(text))
                return false;


            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_ColumnName.Text) || String.IsNullOrEmpty(Comb_DataType.SelectedItem.ToString()))
            {
                MessageBox.Show("Fill All Requierd Informations First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Table == null)
            {
                MessageBox.Show("Send Data By Using (SendTable) Function \"Programmer\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chk_IsNullable.Checked && chk_IsPrimary.Checked)
            {
                MessageBox.Show("Column Cannot Be {Nullable} And {Primary} In The Same Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Table.Columns.Any(c => c.COLUMN_NAME == txt_ColumnName.Text))
            {
                MessageBox.Show("This Column Is Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Table.Columns.Any(c => c.IsPrimaryKey) && chk_IsPrimary.Checked)
            {
                MessageBox.Show("Table Cannot Have More Than 1 Primary Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Table.Columns.Count == 0 && !chk_IsPrimary.Checked)
            {
                MessageBox.Show("Add Primary Key First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int MaxLength = 0;

            if (ValidDataType())
            {
                if (DataTypeWithMaxLength.Contains(Comb_DataType.SelectedItem.ToString()))
                {
                    if (String.IsNullOrEmpty(txt_MaxLength.Text))
                    {
                        MaxLength = -1;
                    }
                    else
                    {
                        MaxLength = int.Parse(txt_MaxLength.Text);
                    }
                }
                try
                {
                    Table.Columns.Add(new clsColumn(txt_ColumnName.Text, Comb_DataType.SelectedItem.ToString().ToString(), MaxLength, chk_IsNullable.Checked, chk_IsIdentity.Checked, chk_IsPrimary.Checked,txt_Description.Text, false, false, false));

                    if (OnColumnAdded != null)
                        OnColumnAddedEvent();
                }
                catch (Exception ex)
                {
                    if (OnColumnAddedFaill != null)
                        OnColumnAddedFaillEvent(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Not Valid DataType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chk_IsPrimary_CheckedChanged(object sender, EventArgs e)
        {
            chk_IsIdentity.Checked = chk_IsPrimary.Checked;
        }

        private void Comb_DataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DataTypeWithMaxLength.Contains(Comb_DataType.SelectedItem))
            {
                lb_MaxLength.Visible = true;
                txt_MaxLength.Visible = true;
                txt_MaxLength.Text = "";
            }
            else
            {
                lb_MaxLength.Visible = false;
                txt_MaxLength.Visible = false;
                txt_MaxLength.Text = "";
            }
        }

        private void Uc_clsAddColumn_Load(object sender, EventArgs e)
        {
            Comb_DataType.SelectedIndex = 1;
        }
    }
}
