using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundIllness : Form
    {
        public FormBackgroundIllness()
        {
            InitializeComponent();
        }

        private void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        #region If fields are empty conditions
        private void yesIllness_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, illnessPanel);
            lbl_illness.ImageIndex = 1;
            lbl_lifetime.ImageIndex = 1;
        }

        private void noIllness_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, illnessPanel);
            lbl_illness.ImageIndex = -1;
            lbl_lifetime.ImageIndex = -1;
        }

        private void yesOperation_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, operationPanel);
            lbl_operation.ImageIndex = 1;
        }

        private void noOperation_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, operationPanel);
            lbl_operation.ImageIndex = -1;
        }

        private void tbx_School_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_illness.Text) || string.IsNullOrWhiteSpace(tbx_illness.Text))
                lbl_illness.ImageIndex = 1;
            else
                lbl_illness.ImageIndex = 0;
        }

        private void tbx_operation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_operation.Text) || string.IsNullOrWhiteSpace(tbx_operation.Text))
                lbl_operation.ImageIndex = 1;
            else
                lbl_operation.ImageIndex = 0;
        }
        #endregion
    }
}
