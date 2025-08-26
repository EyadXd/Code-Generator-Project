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
using General_Settings;

namespace Code_Generator.Login_Screen
{
    public partial class UC_clsUpdateConnectionInfos : UserControl
    {
        public event Action OnLogin;
        public virtual void OnLoginEvent()
        {
            Action handelr = OnLogin;
            handelr?.Invoke();
        }
        public event Action OnCreateNewDataBase;
        public virtual void OnCreateNewDataBaseEvent()
        {
            Action handelr = OnCreateNewDataBase;
            handelr?.Invoke();
        }
        private void _SaveEmptyRemeberMeInfos()
        {
            Properties.Settings.Default.ServerName = "";
            Properties.Settings.Default.UserID = "";
            Properties.Settings.Default.Password = "";

            Properties.Settings.Default.Save();
        }
        private void _SaveRemeberMeInfos()
        {
            Properties.Settings.Default.ServerName = txt_ServerName.Text;
            Properties.Settings.Default.UserID = txt_UserID.Text;
            Properties.Settings.Default.Password = txt_Password.Text;

            Properties.Settings.Default.Save();
        }

        private void _SettingsOf_CreatNewDatabase(bool Visable_Active)
        {
            btn_CreateNewDataBase.Visible = !Visable_Active;
            txt_CreatNewDataBase.Visible = Visable_Active;
            LkLb_Cancel.Visible = Visable_Active;
            LkLb_Create.Visible = Visable_Active;

            btn_LogIn.Enabled = !Visable_Active;
            Comb_ChoseDatabase.Enabled = !Visable_Active;
        }
        private void _LoadRememberMeInfos()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.ServerName) || String.IsNullOrEmpty(Properties.Settings.Default.UserID) || String.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                return;
            }
                txt_ServerName.Text = Properties.Settings.Default.ServerName;
            txt_UserID.Text = Properties.Settings.Default.UserID;
            txt_Password.Text = Properties.Settings.Default.Password;

            if (txt_ServerName.Text == ".")
                chk_LocalServer.Checked = true;
        }
        private void _LoadDataBasesIntoComb()
        {
            _FillConnectionInfos(Comb_ChoseDatabase.SelectedItem?.ToString());

            Comb_ChoseDatabase.Items.Clear();

            DataTable table = clsDataBase.GetDataBaseNames();
            foreach (DataRow row in table.Rows)
            {
                Comb_ChoseDatabase.Items.Add(row["name"]);
            }
        }
        private void _FillConnectionInfos(string DataBaseName)
        {
            clsConnectionInfos.ServerName = txt_ServerName.Text;
            clsConnectionInfos.UserID = txt_UserID.Text;
            clsConnectionInfos.Password = txt_Password.Text;
            clsConnectionInfos.DataBaseName = DataBaseName;
        }
        public UC_clsUpdateConnectionInfos()
        {
            InitializeComponent();
            _LoadRememberMeInfos();
        }

        private void chk_LocalServer_CheckedChanged(object sender, EventArgs e)
        {
            txt_ServerName.Text = chk_LocalServer.Checked ? "." : "";
            txt_ServerName.Enabled = !chk_LocalServer.Checked;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_ServerName.Text) || String.IsNullOrEmpty(txt_UserID.Text) || String.IsNullOrEmpty(txt_Password.Text) || String.IsNullOrEmpty(Comb_ChoseDatabase.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please Fill All Requierd Data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Chk_RemembreMe.Checked)
            {
                _SaveRemeberMeInfos();
            }
            else
            {
                _SaveEmptyRemeberMeInfos();
            }

            _FillConnectionInfos(Comb_ChoseDatabase.SelectedItem?.ToString());

            if(OnLogin!=null)
            OnLoginEvent();
        }

        private void Comb_ChoseDatabase_DropDown(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_ServerName.Text)|| String.IsNullOrEmpty(txt_UserID.Text) || String.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Please Fill All Requierd Data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comb_ChoseDatabase.DroppedDown = false;
                return;
            }

            _LoadDataBasesIntoComb();
        }

        private void btn_CreateNewDataBase_Click(object sender, EventArgs e)
        {
            _SettingsOf_CreatNewDatabase(true);
            _FillConnectionInfos("");
        }

        private void LkLb_Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_CreatNewDataBase.Text = "";
            errorProvider1.Clear();
            _SettingsOf_CreatNewDatabase(false);
        }

        private void LkLb_Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _FillConnectionInfos(txt_CreatNewDataBase.Text);

            if (String.IsNullOrEmpty(txt_CreatNewDataBase.Text))
            {
                MessageBox.Show("Enter Database Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Chk_RemembreMe.Checked)
            {
                _SaveRemeberMeInfos();
            }
            else
            {
                _SaveEmptyRemeberMeInfos();
            }

            if (OnCreateNewDataBase != null)
                OnCreateNewDataBaseEvent();
        }

        private void txt_CreatNewDataBase_TextChanged(object sender, EventArgs e)
        {
            if (clsDataBase.IsExists(txt_CreatNewDataBase.Text))
            {
                LkLb_Create.Enabled = false;
                errorProvider1.SetError(txt_CreatNewDataBase, "This Database Is Already Exists");
            }
            else
            {
                LkLb_Create.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void UC_clsUpdateConnectionInfos_Load(object sender, EventArgs e)
        {
            txt_CreatNewDataBase.Text = "";
        }
    }
}
