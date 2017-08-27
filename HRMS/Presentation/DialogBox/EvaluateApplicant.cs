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

        }

        private void OnNextClick(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void OnCancel2Click(object sender, EventArgs e)
        {
        }
    }
}
