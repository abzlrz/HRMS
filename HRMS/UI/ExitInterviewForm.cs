using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UI
{
    public partial class ExitInterviewForm : Form
    {
        private string fullFilePath;
        private string fileDirectory;

        public ExitInterviewForm()
        {
            InitializeComponent();
            btnProceed.Click += (a, x) => EnableControls(true);
            btnChangeEmployee.Click += (a, x) => EnableControls(false);
            btnReset.Click += (a, x) => 
            {
                EnableControls(false);
                this.ClearAllFields();
            };
        }

        private void EnableControls(bool arg)
        {
            gbxQuestion.Enabled = arg;
            gbxAttachment.Enabled = arg;
            gbxEmployee.Enabled = !arg;
            gbxInfo.Enabled = !arg;
        }

        private void OnBtnAttachFileClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                linkPath.Text = fullFilePath;
        }
        
        private void OnOpenFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.fullFilePath = Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), openFileDialog.FileName);
            this.fileDirectory = Path.GetDirectoryName(openFileDialog.FileName);
        }

        private void OnLinkPathClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select, \"" + fullFilePath + "\"");
        }
    }
}
