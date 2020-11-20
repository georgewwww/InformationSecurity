using KeysVault.Entities;
using KeysVault.Globals;
using KeysVault.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysVault.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly Settings settings;

        public SettingsForm(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            DateFormat SelectedFormat = Variables.DateFormats.Where(f => f.Format == settings.DateTimeFormat).FirstOrDefault();

            cmbDateFormat.SelectedItem = SelectedFormat.Value;

            chkDisplayEmail.Checked = settings.ShowEmailColumn;
            chkDisplayUsername.Checked = settings.ShowUsernameColumn;
            chkDisplayPassword.Checked = settings.ShowPasswordColumn;
        }

        private void cmbDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbDateFormat.SelectedItem.ToString();

            DateFormat SelectedFormat = Variables.DateFormats.Where(f => f.Value == selectedItem).FirstOrDefault();

            settings.DateTimeFormat = SelectedFormat.Format;
        }

        private void chkDisplayEmail_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShowEmailColumn = chkDisplayEmail.Checked;
        }

        private void chkDisplayUsername_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShowUsernameColumn = chkDisplayUsername.Checked;
        }

        private void chkDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShowPasswordColumn = chkDisplayPassword.Checked;
        }

        private void btnChangeMaster_Click(object sender, EventArgs e)
        {
            MasterPasswordForm masterPasswordForm = new MasterPasswordForm(settings);

            masterPasswordForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsService.Instance().UpdateSettingsAsync(settings);
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
