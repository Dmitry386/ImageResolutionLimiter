using ImageResolutionLimiter.Source;
using ImageResolutionLimiter.Source.Helpers;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResolutionLimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxTraceListener tbtl = new TextBoxTraceListener(richTextBoxOutput);
            Trace.Listeners.Add(tbtl); 

            checkBoxBackup.Checked = true;
            textBoxX.Text = "512";
            textBoxY.Text = "512";
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);
            string path = textBoxFolder.Text;
            bool createBackups = checkBoxBackup.Checked;

            SetInputEnabled(false);

            try
            {
                await Task.Run(() => new ImageProcessor().ProcessImages(path, createBackups, x, y, new string[] { ".png", ".jpg", ".jpeg" }));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }

            SetInputEnabled(true);
        }

        private void SetInputEnabled(bool v)
        {
            textBoxFolder.Enabled = v;
            textBoxX.Enabled = v;
            textBoxY.Enabled = v;
            buttonSelectFolder.Enabled = v;
            buttonStart.Enabled = v;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                var result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    textBoxFolder.Text = selectedFolder;
                }
            }
        }
    }
}