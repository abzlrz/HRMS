using System;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEvaluateApplicant : Form
    {
        public FormEvaluateApplicant()
        {
            InitializeComponent();
        }

        private void EvaluateApplicant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
