using DsaEncryption.Core;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DsaEncryption
{
    public partial class Form1 : Form
    {
        public string FilePath { get; set; }
        public string SignaturePath { get; set; }
        public byte[] MessageBytes { get; set; }

        readonly Dsa dsa;

        public Form1()
        {
            InitializeComponent();

            dsa = new Dsa();
            dsa.GenerateKey();

            InitUI();
        }

        private void InitUI()
        {
            xInput.Text = dsa.GetX().ToString();
            pInput.Text = dsa.GetP().ToString();
            qInput.Text = dsa.GetQ().ToString();
            gInput.Text = dsa.GetG().ToString();
            yInput.Text = dsa.GetY().ToString();
            messageBox.Text = string.Empty;
            filePathLabel.Text = string.Empty;
            digitalSignPathLabel.Text = string.Empty;
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            filePathLabel.Text = string.Empty;
            messageBox.Text = string.Empty;
            FilePath = string.Empty;

            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;

                if (string.IsNullOrWhiteSpace(FilePath))
                {
                    MessageBox.Show("Error: Couldn't load the file.");
                    return;
                }

                filePathLabel.Text = FilePath;
                MessageBytes = File.ReadAllBytes(FilePath);

                messageBox.Text = string.Join(" ", MessageBytes.Select(b => b.ToString()));
            }
        }

        private void browseDSBtn_Click(object sender, EventArgs e)
        {
            digitalSignPathLabel.Text = string.Empty;
            dsInput.Text = string.Empty;
            SignaturePath = string.Empty;

            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SignaturePath = openFileDialog.FileName;
                digitalSignPathLabel.Text = FilePath;

                try
                {
                    var signatureContent = File.ReadAllText(SignaturePath);
                    var signTuple = DsaSerializer.Deserialize(signatureContent);

                    dsInput.Text = signTuple.ToString();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: Signature file is corrupt.");
                    return;
                }
            }
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
            {
                MessageBox.Show("Error: Choose a file.");
                return;
            }

            try
            {
                var signTuple = dsa.SignData(MessageBytes);

                // save signature to file
                File.WriteAllText(FilePath.Substring(0, FilePath.IndexOf('.')) + "_Sign.txt", DsaSerializer.Serialize(signTuple));

                MessageBox.Show("File was signed successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            dsInput.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(FilePath))
            {
                MessageBox.Show("Error: Choose a file.");
                return;
            }
            if (string.IsNullOrWhiteSpace(SignaturePath))
            {
                MessageBox.Show("Error: Choose a file with signature.");
                return;
            }

            try
            {
                var signatureContent = File.ReadAllText(SignaturePath);
                var signTuple = DsaSerializer.Deserialize(signatureContent);

                dsInput.Text = signTuple.ToString();

                var verifyResult = dsa.Verify(MessageBytes, signTuple.Item1, signTuple.Item2);
                if (verifyResult)
                {
                    MessageBox.Show("File is valid!");
                }
                else
                {
                    MessageBox.Show("File is invalid!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Signature file is corrupt.");
                return;
            }
        }
    }
}
