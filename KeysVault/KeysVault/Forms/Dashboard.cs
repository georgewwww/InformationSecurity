using KeysVault.Entities;
using KeysVault.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysVault.Forms
{
    public partial class Dashboard : Form
    {
        private Settings localSettings = new Settings();
        private List<Password> localPasswords = new List<Password>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await LoadSettings();
            await LoadPasswords();
        }

        private async Task LoadPasswords()
        {
            localPasswords = await PasswordsService.Instance().GetAllPasswordsAsync(localSettings);
            ShowPasswords(localPasswords);
        }

        public async Task LoadSettings()
        {
            var existingSettings = await SettingsService.Instance().GetSettingsAsync();
            if (existingSettings == null)
            {
                await SettingsService.Instance().SaveNewSettingsAsync(Globals.Defaults.Settings);
                localSettings = Globals.Defaults.Settings;
            } else
            {
                localSettings = existingSettings;
            }

            PasswordsGridView.Columns["ColEmail"].Visible = localSettings.ShowEmailColumn;
            PasswordsGridView.Columns["ColUsername"].Visible = localSettings.ShowUsernameColumn;
            PasswordsGridView.Columns["ColPassword"].Visible = localSettings.ShowPasswordColumn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSearchPassword_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();

            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                string SearchTerm = searchForm.txtSearchPassword.Text;

                string LooksFor = string.Empty;

                if (searchForm.rdbLookEmail.Checked)
                {
                    LooksFor = "Email";
                }
                else if (searchForm.rdbLookUsername.Checked)
                {
                    LooksFor = "Username";
                }
                else LooksFor = "Name";

                string Options = string.Empty;
                if (searchForm.rdbOptionContains.Checked)
                {
                    Options = "Contains";
                }
                else Options = "Equals";

                try
                {
                    ShowPasswords(await PasswordsService.Instance().SearchPasswordsAsync(localSettings, SearchTerm, LooksFor, Options));
                }
                catch (Exception ex)
                {
                    Messenger.Show(ex.Message + " " + ex.HResult, "Error");
                }
            }
        }

        private async void btnNewPassword_Click(object sender, EventArgs e)
        {
            NewPassword newPasswordForm = new NewPassword(localSettings);

            if (newPasswordForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    localPasswords = await PasswordsService.Instance().GetAllPasswordsAsync(localSettings);
                    ShowPasswords(localPasswords);
                    PasswordsGridView.Focus();
                    PasswordsGridView.CurrentCell = PasswordsGridView.Rows[PasswordsGridView.Rows.Count - 1].Cells[2];
                }
                catch (Exception ex)
                {
                    Messenger.Show(ex.Message + " " + ex.HResult, "Error");
                }
            }
        }

        private async void btnMasterPassword_Click(object sender, EventArgs e)
        {
            MasterPasswordForm masterPasswordForm = new MasterPasswordForm(localSettings);
            masterPasswordForm.ShowDialog();

            try
            {
                ShowPasswords(await PasswordsService.Instance().GetAllPasswordsAsync(localSettings));
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }
        }

        private async void btnImportPasswords_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Import Passwords",
                DefaultExt = "kvf",
                Filter = "KeysVault files (*.kvf)|*.kvf|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckPathExists = true,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Password> importedPasswords = await KeyVaultService.Instance().ImportPasswordsAsync(ofd.FileName);

                if (importedPasswords != null)
                {
                    if (Messenger.Confirm("The file contains " + importedPasswords.Count + " passwords. Are you sure you want to import these passwords to your account?"))
                    {
                        try
                        {
                            await PasswordsService.Instance().SaveNewPasswordsAsync(localSettings, CryptoService.Instance().DecryptPasswords(localSettings.Master, importedPasswords));
                        }
                        catch
                        {
                            Messenger.Show("Unable to import passwords. Either these passwords were encrypted with a different Master Password than yours or you changed your Master Password.", "Error");
                        }
                        localPasswords = await PasswordsService.Instance().GetAllPasswordsAsync(localSettings);
                        ShowPasswords(localPasswords);
                    }
                }
            }
        }

        private async void btnExportPasswords_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Export Passwords",
                DefaultExt = "kvf",
                Filter = "KeysVault files (*.kvf)|*.kvf|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckPathExists = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (await KeyVaultService.Instance().ExportPasswordsAsync(CryptoService.Instance().EncryptPasswords(localSettings.Master, localPasswords), sfd.FileName))
                {
                    Messenger.Show("Passwords exported to " + sfd.FileName + " file.", "Info");
                }
            }
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(localSettings);

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await LoadSettings();
                    await LoadPasswords();
                }
                catch (Exception ex)
                {
                    Messenger.Show(ex.Message + " " + ex.HResult, "Error");
                }
            }
        }

        private void ShowPasswords(List<Password> Passwords)
        {
            PasswordsGridView.Rows.Clear();

            foreach (Password password in Passwords)
            {
                PasswordsGridView.Rows.Add(password.Id, password.DateCreated.ToString(localSettings.DateTimeFormat), password.Name, password.Email, password.Username, password.Text);
            }
        }

        private void PasswordsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (sender as DataGridView);

            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                dataGridView.Cursor = Cursors.Default;
            }
            else
            {
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
                    dataGridView.Cursor = Cursors.Hand;
                else
                    dataGridView.Cursor = Cursors.Default;
            }
        }

        private void PasswordsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (sender as DataGridView);
            dataGridView.Cursor = Cursors.Default;
        }

        private async void PasswordsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (PasswordsGridView.Columns[e.ColumnIndex].Name == "ColCopy")
                {
                    Clipboard.Clear();
                    Clipboard.SetText(PasswordsGridView.Rows[e.RowIndex].Cells["ColPassword"].Value.ToString());
                    System.Media.SystemSounds.Exclamation.Play();
                    DisplayMassege(PasswordsGridView.Rows[e.RowIndex].Cells["ColName"].Value.ToString() + " Password Copied.");
                }
                else if (PasswordsGridView.Columns[e.ColumnIndex].Name == "ColUpdate")
                {
                    int id = Convert.ToInt32(PasswordsGridView.Rows[e.RowIndex].Cells["ColID"].Value.ToString());

                    UpdatePassword updatePasswordForm = new UpdatePassword(localSettings, localPasswords.FirstOrDefault(i => i.Id == id));

                    if (updatePasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        localPasswords = await PasswordsService.Instance().GetAllPasswordsAsync(localSettings);
                        DisplayMassege("Password Updated.");
                        ShowPasswords(localPasswords);
                    }
                }
                else if (PasswordsGridView.Columns[e.ColumnIndex].Name == "ColDelete")
                {
                    if (Messenger.Confirm("Are you sure you want to delete this Password?\n\nTHIS TASK WILL NOT BE REVERTED."))
                    {
                        var id = Convert.ToInt32(PasswordsGridView.Rows[e.RowIndex].Cells["ColID"].Value.ToString());

                        //this is necessary to get all passwords before deleting.
                        localPasswords = await PasswordsService.Instance().GetAllPasswordsAsync(localSettings);

                        Password passwordToDelete = localPasswords.Where(p => p.Id == id).FirstOrDefault();

                        if (await PasswordsService.Instance().RemovePasswordAsync(passwordToDelete))
                        {
                            PasswordsGridView.Rows.RemoveAt(e.RowIndex);
                            DisplayMassege("Password Deleted.");
                            System.Media.SystemSounds.Hand.Play();
                        }
                        else
                        {
                            DisplayMassege("Password NOT Deleted.");
                            System.Media.SystemSounds.Exclamation.Play();
                        }
                    }
                }
            }
        }

        public void DisplayMassege(string Message)
        {
            lblMassege.Text = Message;
        }
    }
}
