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
using System.IO;

namespace Code_Generator.Code_Settings
{
    public partial class Frm_CodeGeneratingSettings : Form
    {
        //Text Boxes UI
        private string DataAccessTxt_placeholderText = "Data Access Namespace";
        private string BussinessTxt_placeholderText = "Business Namespace";


        private Color placeholderColor = Color.Gray;
        private Color normalTextColor = Color.Black;




        string Choice = "";
        clsTable Table = null;

        private void GetChoice(string choice)
        {
            Choice = choice;
        }
        private void Save_TableFunction_Options(clsTable Table)
        {
            Table.AddNew = chk_Addnew.Checked;
            Table.ListAll = chk_ListAllRecords.Checked;
            Table.Update = chk_Update.Checked;
        }
        private void SaveCodeToFile(string Code, string FileName = "")
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Save Code File";
                saveFileDialog.FileName = FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string textToSave = Code;

                    try
                    {
                        File.WriteAllText(filePath, textToSave);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GenerateCode(clsTable Table)
        {
            string DataAccess_NameSapceName = "";
            string Bussinees_NameSpaceName = "";

            if(txt_BusinessNameSpace.Text.Trim()!=BussinessTxt_placeholderText)
            {
                //There Is A Real Value
                Bussinees_NameSpaceName = txt_BusinessNameSpace.Text.Trim();
            }

            if (txt_DataAccessNameSpace.Text.Trim() != DataAccessTxt_placeholderText)
            {
                //There Is A Real Value
                DataAccess_NameSapceName=txt_DataAccessNameSpace.Text.Trim();
            }

            //Check For Connection String
            if(chk_ConnectionString.Checked)
            {
                SaveCodeToFile(Code_Writer.clsCodeWriter_AdditionalClasses.Write_ConnectionStringClass(General_Settings.clsConnectionInfos.ConnectionString(),DataAccess_NameSapceName), $"CG_AdditionalClasses_ConnectionString");
            }

            if (Choice == "Data Layer")
            {
                SaveCodeToFile(Code_Writer.clsCodeWriter_DataAccess_Layer.Write_Code(Table, DataAccess_NameSapceName), $"CG_DataLayer_{Table.TableName}");
            }
            else if (Choice == "Logic Layer")
            {
                SaveCodeToFile(Code_Writer.clsCodeWriter_Logic_Layer.Write_Code(Table,DataAccess_NameSapceName,Bussinees_NameSpaceName), $"CG_LogicLayer_{Table.TableName}");
            }
            else if (Choice == "Both Layers")
            {
                SaveCodeToFile(Code_Writer.clsCodeWriter_DataAccess_Layer.Write_Code(Table, DataAccess_NameSapceName), $"CG_DataLayer_{Table.TableName}");
                SaveCodeToFile(Code_Writer.clsCodeWriter_Logic_Layer.Write_Code(Table, DataAccess_NameSapceName, Bussinees_NameSpaceName), $"CG_LogicLayer_{Table.TableName}");
            }
        }
   
        public Frm_CodeGeneratingSettings(string TableName)
        {
            InitializeComponent();
            lb_TableName.Text = TableName;

            Table = new clsTable(TableName);
            Table.Columns = clsColumn.ListColumns(Table.TableName);


            Dgv_CodeSettings.DataSource = Table.Columns;
        }

        private void btn_GenerateCode(object sender, EventArgs e)
        {
            //Save Addnew / update  / list
            Save_TableFunction_Options(Table);


            //Save Code
            Frm_CodeGeneratingChoice Form = new Frm_CodeGeneratingChoice();
            //Delegate
            Form.ReturnChoice = GetChoice;

            Form.ShowDialog();

            GenerateCode(Table);
        }

        private void Dgv_CodeSettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Dgv_CodeSettings.Columns[e.ColumnIndex].Name == "COLUMN_NAME")
            {
                Dgv_CodeSettings.Rows[e.RowIndex].Cells["Find_By"].Value = true;
                Dgv_CodeSettings.Rows[e.RowIndex].Cells["Delete_By"].Value = true;
                Dgv_CodeSettings.Rows[e.RowIndex].Cells["IsExists_By"].Value = true;
            }
        }

        private void chk_Addnew_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            chk_Addnew.Checked = box.Checked;
            chk_Update.Checked = box.Checked;
        }

        private void Dgv_CodeSettings_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (new[] { "COLUMN_NAME","IsNullable", "IsIdentity", "IsPrimaryKey" }.Contains(Dgv_CodeSettings.Columns[e.ColumnIndex].Name))
            {
                e.Cancel = true;
            }
        }

        private void lk_AdjustNameSpaces_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_BusinessNameSpace.Visible = !txt_BusinessNameSpace.Visible;
            txt_DataAccessNameSpace.Visible = !txt_DataAccessNameSpace.Visible;
        }

        private void Frm_CodeGeneratingSettings_Load(object sender, EventArgs e)
        {
            //Load Defualt placeholder Text 
            txt_DataAccessNameSpace.Text = DataAccessTxt_placeholderText;
            txt_DataAccessNameSpace.ForeColor = placeholderColor;

            txt_BusinessNameSpace.Text = BussinessTxt_placeholderText;
            txt_BusinessNameSpace.ForeColor = placeholderColor;
        }

        private void txt_BusinessNameSpace_Enter(object sender, EventArgs e)
        {
            TextBox SenderBox = (TextBox)sender;

            if(SenderBox.Text.Trim()== DataAccessTxt_placeholderText|| SenderBox.Text.Trim() == BussinessTxt_placeholderText)
            {
                //Thats Mean Txt Box Doesnt Has Value
                //Remove Plancholder To let User Write
                SenderBox.Text = "";
                SenderBox.ForeColor = normalTextColor;
            }
        }

        private void txt_BusinessNameSpace_Leave(object sender, EventArgs e)
        {
            TextBox SenderBox = (TextBox)sender;

            if(String.IsNullOrWhiteSpace(SenderBox.Text))
            {
                //Thats Mean Txt Box Doesnt Has Value
                //return Placholder Back
                SenderBox.Text = SenderBox.Name == txt_BusinessNameSpace.Name ? BussinessTxt_placeholderText : DataAccessTxt_placeholderText;  //If Sender Box was Bussiness , But Bussiness Holder , Else But Data Access Holder
                SenderBox.ForeColor = placeholderColor;
            }
        }
    }
}
