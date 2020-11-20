using KeysVault.Entities;
using KeysVault.Globals;
using KeysVault.Services;
using System;
using System.Windows.Forms;

namespace KeysVault.Forms
{
    public partial class NewPassword : Form
    {
        private readonly Settings settings;

        public NewPassword(Settings settings)
        {
            InitializeComponent();

            txtName.Focus();
            this.settings = settings;
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = IsEnable();
        }

        private void ForSaveBtnEnable(object sender, EventArgs e)
        {
            btnSave.Enabled = IsEnable();
        }

        private bool IsEnable()
        {
            if (Verifier.Text(txtName.Text) && Verifier.Text(txtPassword.Text) && Verifier.Email(txtEmail.Text))
                return true;
            return false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Password newPassword = new Password()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Website = txtWebsite.Text,
                Text = txtPassword.Text,
                Notes = rtxtNotes.Text,

                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            try
            {
                await PasswordsService.Instance().SaveNewPasswordAsync(settings, newPassword);
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
