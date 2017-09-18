using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormLegalBackground : Form
    {
        public FormLegalBackground()
        {
            InitializeComponent();
        }
        void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        #region If fields are empty conditions
        private void tbx_conviction_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_conviction.Text) || string.IsNullOrWhiteSpace(tbx_conviction.Text))
                lbl_conviction.ImageIndex = 1;
            else
                lbl_conviction.ImageIndex = 0;
        }

        private void tbx_case_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_case.Text) || string.IsNullOrWhiteSpace(tbx_case.Text))
                lbl_case.ImageIndex = 1;
            else
                lbl_case.ImageIndex = 0;
        }

        private void rd_yesConvicted_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, convictionPanel);
            lbl_conviction.ImageIndex = 1;
        }

        private void rd_noConvicted_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, convictionPanel);
            lbl_conviction.ImageIndex = -1;
        }

        private void rd_yesLawsuited_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, legalCasePanel);
            lbl_case.ImageIndex = 1;
        }

        private void rd_noLawsuited_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, legalCasePanel);
            lbl_case.ImageIndex = -1;
        }
        #endregion
    }
}
