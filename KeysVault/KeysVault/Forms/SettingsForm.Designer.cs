namespace KeysVault.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeMaster = new System.Windows.Forms.Button();
            this.cmbDateFormat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDisplayPassword = new System.Windows.Forms.CheckBox();
            this.chkDisplayUsername = new System.Windows.Forms.CheckBox();
            this.chkDisplayEmail = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblAppMotto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeMaster
            // 
            this.btnChangeMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.btnChangeMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangeMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMaster.FlatAppearance.BorderSize = 0;
            this.btnChangeMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMaster.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMaster.ForeColor = System.Drawing.Color.White;
            this.btnChangeMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeMaster.Location = new System.Drawing.Point(164, 204);
            this.btnChangeMaster.Name = "btnChangeMaster";
            this.btnChangeMaster.Size = new System.Drawing.Size(227, 42);
            this.btnChangeMaster.TabIndex = 5;
            this.btnChangeMaster.Text = "Change Master Password";
            this.btnChangeMaster.UseVisualStyleBackColor = false;
            this.btnChangeMaster.Click += new System.EventHandler(this.btnChangeMaster_Click);
            // 
            // cmbDateFormat
            // 
            this.cmbDateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.cmbDateFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.cmbDateFormat.FormattingEnabled = true;
            this.cmbDateFormat.Items.AddRange(new object[] {
            "2/27/2000",
            "Friday, February 27, 2000",
            "Friday, February 27, 2000 12:11 PM",
            "Friday, February 27, 2000 12:12:22 PM",
            "2/27/2000 12:12 PM",
            "2/27/2000 12:12:22 PM",
            "2000-02-27T12:12:22",
            "2000-02-27 12:12:22Z"});
            this.cmbDateFormat.Location = new System.Drawing.Point(165, 86);
            this.cmbDateFormat.Name = "cmbDateFormat";
            this.cmbDateFormat.Size = new System.Drawing.Size(225, 29);
            this.cmbDateFormat.TabIndex = 1;
            this.cmbDateFormat.SelectedIndexChanged += new System.EventHandler(this.cmbDateFormat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date Format :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Master :";
            // 
            // chkDisplayPassword
            // 
            this.chkDisplayPassword.AutoSize = true;
            this.chkDisplayPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDisplayPassword.Location = new System.Drawing.Point(166, 175);
            this.chkDisplayPassword.Name = "chkDisplayPassword";
            this.chkDisplayPassword.Size = new System.Drawing.Size(147, 25);
            this.chkDisplayPassword.TabIndex = 4;
            this.chkDisplayPassword.Text = "Display Password";
            this.chkDisplayPassword.UseVisualStyleBackColor = true;
            this.chkDisplayPassword.CheckedChanged += new System.EventHandler(this.chkDisplayPassword_CheckedChanged);
            // 
            // chkDisplayUsername
            // 
            this.chkDisplayUsername.AutoSize = true;
            this.chkDisplayUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDisplayUsername.Location = new System.Drawing.Point(166, 149);
            this.chkDisplayUsername.Name = "chkDisplayUsername";
            this.chkDisplayUsername.Size = new System.Drawing.Size(152, 25);
            this.chkDisplayUsername.TabIndex = 3;
            this.chkDisplayUsername.Text = "Display Username";
            this.chkDisplayUsername.UseVisualStyleBackColor = true;
            this.chkDisplayUsername.CheckedChanged += new System.EventHandler(this.chkDisplayUsername_CheckedChanged);
            // 
            // chkDisplayEmail
            // 
            this.chkDisplayEmail.AutoSize = true;
            this.chkDisplayEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDisplayEmail.Location = new System.Drawing.Point(166, 125);
            this.chkDisplayEmail.Name = "chkDisplayEmail";
            this.chkDisplayEmail.Size = new System.Drawing.Size(119, 25);
            this.chkDisplayEmail.TabIndex = 2;
            this.chkDisplayEmail.Text = "Display Email";
            this.chkDisplayEmail.UseVisualStyleBackColor = true;
            this.chkDisplayEmail.CheckedChanged += new System.EventHandler(this.chkDisplayEmail_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(165, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Display :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(281, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnChangeMaster);
            this.panel1.Controls.Add(this.cmbDateFormat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkDisplayPassword);
            this.panel1.Controls.Add(this.chkDisplayUsername);
            this.panel1.Controls.Add(this.chkDisplayEmail);
            this.panel1.Controls.Add(this.TitlePanel);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 331);
            this.panel1.TabIndex = 51;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitlePanel.Controls.Add(this.lblFormTitle);
            this.TitlePanel.Controls.Add(this.lblAppMotto);
            this.TitlePanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TitlePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TitlePanel.Location = new System.Drawing.Point(0, 2);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(484, 70);
            this.TitlePanel.TabIndex = 77;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(0, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(484, 32);
            this.lblFormTitle.TabIndex = 34;
            this.lblFormTitle.Text = "Settings";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppMotto
            // 
            this.lblAppMotto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblAppMotto.Location = new System.Drawing.Point(0, 50);
            this.lblAppMotto.Name = "lblAppMotto";
            this.lblAppMotto.Size = new System.Drawing.Size(484, 17);
            this.lblAppMotto.TabIndex = 89;
            this.lblAppMotto.Text = "KeysVault - Personal Password Manager";
            this.lblAppMotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 485);
            this.MinimumSize = new System.Drawing.Size(500, 370);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblAppMotto;
        private System.Windows.Forms.CheckBox chkDisplayPassword;
        private System.Windows.Forms.CheckBox chkDisplayUsername;
        private System.Windows.Forms.CheckBox chkDisplayEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDateFormat;
        private System.Windows.Forms.Button btnChangeMaster;
    }
}