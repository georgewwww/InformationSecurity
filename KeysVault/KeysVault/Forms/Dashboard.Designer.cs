namespace KeysVault.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMassege = new System.Windows.Forms.Label();
            this.btnSearchPassword = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExportPasswords = new System.Windows.Forms.Button();
            this.btnImportPasswords = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.btnMasterPassword = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.PasswordsContainerPanel = new System.Windows.Forms.Panel();
            this.PasswordsGridView = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCopy = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MenuPanel.SuspendLayout();
            this.PasswordsContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.MenuPanel.Controls.Add(this.btnExit);
            this.MenuPanel.Controls.Add(this.lblMassege);
            this.MenuPanel.Controls.Add(this.btnSearchPassword);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnExportPasswords);
            this.MenuPanel.Controls.Add(this.btnImportPasswords);
            this.MenuPanel.Controls.Add(this.btnNewPassword);
            this.MenuPanel.Controls.Add(this.btnMasterPassword);
            this.MenuPanel.Controls.Add(this.btnTitle);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(228, 661);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::KeysVault.Properties.Resources.close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 575);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(228, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "         Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMassege
            // 
            this.lblMassege.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMassege.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMassege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblMassege.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMassege.Location = new System.Drawing.Point(0, 625);
            this.lblMassege.Name = "lblMassege";
            this.lblMassege.Size = new System.Drawing.Size(228, 36);
            this.lblMassege.TabIndex = 17;
            this.lblMassege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPassword.FlatAppearance.BorderSize = 0;
            this.btnSearchPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSearchPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSearchPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchPassword.ForeColor = System.Drawing.Color.White;
            this.btnSearchPassword.Image = global::KeysVault.Properties.Resources.search;
            this.btnSearchPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPassword.Location = new System.Drawing.Point(0, 90);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSearchPassword.Size = new System.Drawing.Size(225, 50);
            this.btnSearchPassword.TabIndex = 2;
            this.btnSearchPassword.Text = "         Search Password";
            this.btnSearchPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPassword.UseVisualStyleBackColor = false;
            this.btnSearchPassword.Click += new System.EventHandler(this.btnSearchPassword_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 370);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(225, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "         Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExportPasswords
            // 
            this.btnExportPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPasswords.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPasswords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPasswords.FlatAppearance.BorderSize = 0;
            this.btnExportPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnExportPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnExportPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPasswords.ForeColor = System.Drawing.Color.White;
            this.btnExportPasswords.Image = global::KeysVault.Properties.Resources.exit;
            this.btnExportPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPasswords.Location = new System.Drawing.Point(0, 314);
            this.btnExportPasswords.Name = "btnExportPasswords";
            this.btnExportPasswords.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnExportPasswords.Size = new System.Drawing.Size(225, 50);
            this.btnExportPasswords.TabIndex = 6;
            this.btnExportPasswords.Text = "         Export Passwords";
            this.btnExportPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPasswords.UseVisualStyleBackColor = false;
            this.btnExportPasswords.Click += new System.EventHandler(this.btnExportPasswords_Click);
            // 
            // btnImportPasswords
            // 
            this.btnImportPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportPasswords.BackColor = System.Drawing.Color.Transparent;
            this.btnImportPasswords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportPasswords.FlatAppearance.BorderSize = 0;
            this.btnImportPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnImportPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnImportPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnImportPasswords.ForeColor = System.Drawing.Color.White;
            this.btnImportPasswords.Image = global::KeysVault.Properties.Resources.download;
            this.btnImportPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPasswords.Location = new System.Drawing.Point(0, 258);
            this.btnImportPasswords.Name = "btnImportPasswords";
            this.btnImportPasswords.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnImportPasswords.Size = new System.Drawing.Size(225, 50);
            this.btnImportPasswords.TabIndex = 5;
            this.btnImportPasswords.Text = "         Import Passwords";
            this.btnImportPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPasswords.UseVisualStyleBackColor = false;
            this.btnImportPasswords.Click += new System.EventHandler(this.btnImportPasswords_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPassword.FlatAppearance.BorderSize = 0;
            this.btnNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPassword.Image")));
            this.btnNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPassword.Location = new System.Drawing.Point(0, 146);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNewPassword.Size = new System.Drawing.Size(225, 50);
            this.btnNewPassword.TabIndex = 3;
            this.btnNewPassword.Text = "         New Password";
            this.btnNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // btnMasterPassword
            // 
            this.btnMasterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasterPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnMasterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMasterPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasterPassword.FlatAppearance.BorderSize = 0;
            this.btnMasterPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnMasterPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnMasterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnMasterPassword.ForeColor = System.Drawing.Color.White;
            this.btnMasterPassword.Image = global::KeysVault.Properties.Resources.folder;
            this.btnMasterPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.Location = new System.Drawing.Point(0, 202);
            this.btnMasterPassword.Name = "btnMasterPassword";
            this.btnMasterPassword.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMasterPassword.Size = new System.Drawing.Size(225, 50);
            this.btnMasterPassword.TabIndex = 4;
            this.btnMasterPassword.Text = "         Master Password";
            this.btnMasterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.UseVisualStyleBackColor = false;
            this.btnMasterPassword.Click += new System.EventHandler(this.btnMasterPassword_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Location = new System.Drawing.Point(0, 0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(225, 84);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.Text = "               Keys Vault";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // PasswordsContainerPanel
            // 
            this.PasswordsContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordsContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.PasswordsContainerPanel.Controls.Add(this.PasswordsGridView);
            this.PasswordsContainerPanel.Location = new System.Drawing.Point(225, 0);
            this.PasswordsContainerPanel.Name = "PasswordsContainerPanel";
            this.PasswordsContainerPanel.Size = new System.Drawing.Size(894, 661);
            this.PasswordsContainerPanel.TabIndex = 1;
            // 
            // PasswordsGridView
            // 
            this.PasswordsGridView.AllowUserToAddRows = false;
            this.PasswordsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.PasswordsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PasswordsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PasswordsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.PasswordsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PasswordsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PasswordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasswordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDateCreated,
            this.ColName,
            this.ColEmail,
            this.ColUsername,
            this.ColPassword,
            this.ColCopy,
            this.ColUpdate,
            this.ColDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PasswordsGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.PasswordsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PasswordsGridView.EnableHeadersVisualStyles = false;
            this.PasswordsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.PasswordsGridView.Location = new System.Drawing.Point(0, 0);
            this.PasswordsGridView.Name = "PasswordsGridView";
            this.PasswordsGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PasswordsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PasswordsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.PasswordsGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PasswordsGridView.RowTemplate.Height = 30;
            this.PasswordsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PasswordsGridView.Size = new System.Drawing.Size(894, 661);
            this.PasswordsGridView.TabIndex = 0;
            this.PasswordsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGridView_CellContentClick);
            this.PasswordsGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGridView_CellMouseEnter);
            this.PasswordsGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGridView_CellMouseLeave);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Id";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColDateCreated
            // 
            this.ColDateCreated.HeaderText = "Date Created";
            this.ColDateCreated.Name = "ColDateCreated";
            this.ColDateCreated.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColUsername
            // 
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            // 
            // ColCopy
            // 
            this.ColCopy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            this.ColCopy.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCopy.Description = "Copy This Password";
            this.ColCopy.HeaderText = "Copy";
            this.ColCopy.Image = ((System.Drawing.Image)(resources.GetObject("ColCopy.Image")));
            this.ColCopy.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColCopy.Name = "ColCopy";
            this.ColCopy.ReadOnly = true;
            this.ColCopy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCopy.Width = 73;
            // 
            // ColUpdate
            // 
            this.ColUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUpdate.Description = "Update This Password";
            this.ColUpdate.HeaderText = "Update";
            this.ColUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ColUpdate.Image")));
            this.ColUpdate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColUpdate.Name = "ColUpdate";
            this.ColUpdate.ReadOnly = true;
            this.ColUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColUpdate.Width = 73;
            // 
            // ColDelete
            // 
            this.ColDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColDelete.Description = "Delete This Password";
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColDelete.Image")));
            this.ColDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDelete.Width = 73;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn1.Description = "Copy This Password";
            this.dataGridViewImageColumn1.HeaderText = "Copy";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 73;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.Description = "Update This Password";
            this.dataGridViewImageColumn2.HeaderText = "Update";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.Description = "Delete This Password";
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 73;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1119, 661);
            this.Controls.Add(this.PasswordsContainerPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MenuPanel.ResumeLayout(false);
            this.PasswordsContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel PasswordsContainerPanel;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnMasterPassword;
        private System.Windows.Forms.DataGridView PasswordsGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btnExportPasswords;
        private System.Windows.Forms.Button btnImportPasswords;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Button btnSearchPassword;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblMassege;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewImageColumn ColCopy;
        private System.Windows.Forms.DataGridViewImageColumn ColUpdate;
        private System.Windows.Forms.DataGridViewImageColumn ColDelete;
    }
}