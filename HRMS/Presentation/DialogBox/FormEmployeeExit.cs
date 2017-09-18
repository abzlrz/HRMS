using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEmployeeExit : Form
    {
        public FormEmployeeExit()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                link_path.Text = fullFilePath;
        }
        private void linkPathClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select, \"" + fullFilePath + "\"");
        }

        private void openFileDialogFileOk(object sender, CancelEventArgs e)
        {
            this.fullFilePath = Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), openFileDialog.FileName);
            this.fileDirectory = Path.GetDirectoryName(openFileDialog.FileName);
        }
        private void EmployeeExitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }

        private string fullFilePath;
        private string fileDirectory;

        
    }
}
