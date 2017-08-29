using System;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class EvaluateApplicant : Form
    {
        public EvaluateApplicant()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void EvaluateApplicant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panel1.BringToFront();
            }
        }
    }
}
