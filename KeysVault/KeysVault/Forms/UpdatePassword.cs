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
    public partial class UpdatePassword : Form
    {
        private readonly Settings settings;
        private readonly Password currentPassword;

        public UpdatePassword(Settings settings, Password password)
        {
            InitializeComponent();
            this.settings = settings;
            this.currentPassword = password;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            txtName.Text = currentPassword.Name;
            txtEmail.Text = currentPassword.Email;
            txtUsername.Text = currentPassword.Username;
            txtWebsite.Text = currentPassword.Website;
            txtPassword.Text = currentPassword.Text;
            rtxtNotes.Text = currentPassword.Notes;

            btnSave.Enabled = IsEnable();
        }

        private void ForSaveBtnEnable(object sender, EventArgs e)
        {
            btnSave.Enabled = IsEnable();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            currentPassword.Name = txtName.Text;
            currentPassword.Email = txtEmail.Text;
            currentPassword.Username = txtUsername.Text;
            currentPassword.Website = txtWebsite.Text;
            currentPassword.Text = txtPassword.Text;
            currentPassword.Notes = rtxtNotes.Text;
            currentPassword.DateModified = DateTime.Now;

            try
            {
                await PasswordsService.Instance().UpdatePasswordAsync(settings, currentPassword);
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

        private bool IsEnable()
        {
            if (Verifier.Text(txtName.Text) && Verifier.Text(txtPassword.Text))
                return true;
            return false;
        }
    }
}
