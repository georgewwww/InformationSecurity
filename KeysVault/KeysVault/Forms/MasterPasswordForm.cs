using KeysVault.Entities;
using KeysVault.Globals;
using KeysVault.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeysVault.Forms
{
    public partial class MasterPasswordForm : Form
    {
        private Settings settings;

        public MasterPasswordForm(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
        }

        private void chkHideMaster_CheckedChanged(object sender, EventArgs e)
        {
            txtMaster.UseSystemPasswordChar = chkHideMaster.Checked;
        }

        private void chkHideNewMaster_CheckedChanged(object sender, EventArgs e)
        {
            txtNewMaster.UseSystemPasswordChar = chkHideNewMaster.Checked;
        }

        private void chkHideConfirmMaster_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmMaster.UseSystemPasswordChar = chkHideConfirmMaster.Checked;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the newly supplied passwords are same or not
                if (!PasswordsService.Instance().IsSame(txtNewMaster.Text, txtConfirmMaster.Text) && !Verifier.Text(txtNewMaster.Text) && !Verifier.Text(txtConfirmMaster.Text))
                {
                    lblMassege.Text = "Your New Master Password and Confirm Master Password doesn't match.";
                    lblMassege.ForeColor = Color.FromArgb(244, 67, 54);
                }
                else //both new passwords are same. Dont match them again
                {
                    //match the current Master Password with the entered Master Password
                    if (Verifier.Text(txtMaster.Text) && PasswordsService.Instance().IsSame(settings.Master, txtMaster.Text))
                    {
                        if (MessageBox.Show("Are you sure you want to change your Master Password?\n\nPlease write down your Master Password for safe keeping, if you forgot your Master Password, you will not be able to recover your Passwords.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            btnSave.Enabled = false;

                            settings = await PasswordsService.Instance().ChangeMasterEncryption(settings, txtNewMaster.Text);

                            btnSave.Enabled = true;
                            lblMassege.Text = "Master Password Changed.";
                            lblMassege.ForeColor = Color.FromArgb(67, 140, 235);
                        }
                    }
                    else //user entered a wrong master password
                    {
                        lblMassege.Text = "Your Master Password is incorrect.";
                        lblMassege.ForeColor = Color.FromArgb(244, 67, 54);
                    }
                }
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
                btnSave.Enabled = true;
            }
        }

        private void CheckSaveEnable(object sender, EventArgs e)
        {
            btnSave.Enabled = IsEnable();
        }

        public bool IsEnable()
        {
            if (PasswordsService.Instance().IsSame(txtNewMaster.Text, txtConfirmMaster.Text) && Verifier.Text(txtNewMaster.Text) && Verifier.Text(txtConfirmMaster.Text))
            {
                //now check if existing master match too
                if (Verifier.Text(txtMaster.Text) && PasswordsService.Instance().IsSame(settings.Master, txtMaster.Text))
                {
                    lblMassege.Text = "You can try to save now.";
                    lblMassege.ForeColor = Color.FromArgb(67, 140, 235);
                    return true;
                }
                else
                {
                    lblMassege.Text = "Your Master Password is incorrect.";
                    lblMassege.ForeColor = Color.FromArgb(244, 67, 54);
                    return false;
                }
            }
            else
            {
                lblMassege.Text = "Your New Master Password and Confirm Master Password doesn't match.";
                lblMassege.ForeColor = Color.FromArgb(244, 67, 54);
                return false;
            }
        }
    }
}
