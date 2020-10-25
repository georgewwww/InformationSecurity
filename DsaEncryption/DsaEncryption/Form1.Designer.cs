namespace DsaEncryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browseDSBtn = new System.Windows.Forms.Button();
            this.digitalSignPathLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.signBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.TextBox();
            this.qInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dsInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.BackColor = System.Drawing.Color.Bisque;
            this.browseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFileBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.browseFileBtn.Location = new System.Drawing.Point(349, 96);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(100, 33);
            this.browseFileBtn.TabIndex = 1;
            this.browseFileBtn.Text = "Browse...";
            this.browseFileBtn.UseVisualStyleBackColor = false;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(10, 34);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(307, 615);
            this.messageBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathLabel.Location = new System.Drawing.Point(349, 64);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(60, 15);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "// filepath";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(738, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digital Signature:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseDSBtn
            // 
            this.browseDSBtn.BackColor = System.Drawing.Color.Bisque;
            this.browseDSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseDSBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseDSBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.browseDSBtn.Location = new System.Drawing.Point(738, 96);
            this.browseDSBtn.Name = "browseDSBtn";
            this.browseDSBtn.Size = new System.Drawing.Size(100, 33);
            this.browseDSBtn.TabIndex = 1;
            this.browseDSBtn.Text = "Browse...";
            this.browseDSBtn.UseVisualStyleBackColor = false;
            this.browseDSBtn.Click += new System.EventHandler(this.browseDSBtn_Click);
            // 
            // digitalSignPathLabel
            // 
            this.digitalSignPathLabel.AutoSize = true;
            this.digitalSignPathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digitalSignPathLabel.Location = new System.Drawing.Point(738, 64);
            this.digitalSignPathLabel.Name = "digitalSignPathLabel";
            this.digitalSignPathLabel.Size = new System.Drawing.Size(60, 15);
            this.digitalSignPathLabel.TabIndex = 0;
            this.digitalSignPathLabel.Text = "// filepath";
            this.digitalSignPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(349, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "X (private key)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xInput
            // 
            this.xInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xInput.Location = new System.Drawing.Point(349, 183);
            this.xInput.Name = "xInput";
            this.xInput.ReadOnly = true;
            this.xInput.Size = new System.Drawing.Size(723, 23);
            this.xInput.TabIndex = 3;
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.Color.Bisque;
            this.signBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signBtn.Location = new System.Drawing.Point(349, 543);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(130, 30);
            this.signBtn.TabIndex = 1;
            this.signBtn.Text = "Sign";
            this.signBtn.UseVisualStyleBackColor = false;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(349, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "P (public key)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInput
            // 
            this.pInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pInput.Location = new System.Drawing.Point(349, 241);
            this.pInput.Name = "pInput";
            this.pInput.ReadOnly = true;
            this.pInput.Size = new System.Drawing.Size(723, 23);
            this.pInput.TabIndex = 3;
            // 
            // qInput
            // 
            this.qInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qInput.Location = new System.Drawing.Point(349, 302);
            this.qInput.Name = "qInput";
            this.qInput.ReadOnly = true;
            this.qInput.Size = new System.Drawing.Size(723, 23);
            this.qInput.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(349, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Q (public key)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(349, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "G (public key)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gInput
            // 
            this.gInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gInput.Location = new System.Drawing.Point(349, 363);
            this.gInput.Name = "gInput";
            this.gInput.ReadOnly = true;
            this.gInput.Size = new System.Drawing.Size(723, 23);
            this.gInput.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(349, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y (public key)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yInput
            // 
            this.yInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yInput.Location = new System.Drawing.Point(349, 423);
            this.yInput.Name = "yInput";
            this.yInput.ReadOnly = true;
            this.yInput.Size = new System.Drawing.Size(723, 23);
            this.yInput.TabIndex = 3;
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.Bisque;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verifyBtn.Location = new System.Drawing.Point(563, 543);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(130, 30);
            this.verifyBtn.TabIndex = 1;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(349, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Digital signature";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsInput
            // 
            this.dsInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dsInput.Location = new System.Drawing.Point(349, 482);
            this.dsInput.Name = "dsInput";
            this.dsInput.ReadOnly = true;
            this.dsInput.Size = new System.Drawing.Size(723, 23);
            this.dsInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dsInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qInput);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.digitalSignPathLabel);
            this.Controls.Add(this.browseDSBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.browseFileBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Digital Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseDSBtn;
        private System.Windows.Forms.Label digitalSignPathLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pInput;
        private System.Windows.Forms.TextBox qInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dsInput;
    }
}

