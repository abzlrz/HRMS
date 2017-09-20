using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlAddress : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        public ControlAddress()
        {
            InitializeComponent();
        }
        public bool ValidateFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_street1.Text) || string.IsNullOrWhiteSpace(tbx_street1.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_street2.Text) || string.IsNullOrWhiteSpace(tbx_street2.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_postalArea1.Text) || string.IsNullOrWhiteSpace(tbx_postalArea1.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_postalArea2.Text) || string.IsNullOrWhiteSpace(tbx_postalArea2.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_postalNo1.Text) || string.IsNullOrWhiteSpace(tbx_postalNo1.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_postalNo2.Text) || string.IsNullOrWhiteSpace(tbx_postalNo2.Text))
                result = false;

            return result;
        }

        private void tbx_street1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_street1.Text) || string.IsNullOrWhiteSpace(tbx_street1.Text))
                lbl_street1.ImageIndex = 1;
            else
                lbl_street1.ImageIndex = 0;
        }

        private void tbx_postalArea1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalArea1.Text) || string.IsNullOrWhiteSpace(tbx_postalArea1.Text))
                lbl_postalArea1.ImageIndex = 1;
            else
                lbl_postalArea1.ImageIndex = 0;
        }

        private void tbx_postalNo1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalNo1.Text) || string.IsNullOrWhiteSpace(tbx_postalNo1.Text))
                lbl_postalNo1.ImageIndex = 1;
            else
                lbl_postalNo1.ImageIndex = 0;
        }

        private void tbx_street2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_street2.Text) || string.IsNullOrWhiteSpace(tbx_street2.Text))
                lbl_street2.ImageIndex = 1;
            else
                lbl_street2.ImageIndex = 0;
        }

        private void tbx_postalArea2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalArea2.Text) || string.IsNullOrWhiteSpace(tbx_postalArea2.Text))
                lbl_postalArea2.ImageIndex = 1;
            else
                lbl_postalArea2.ImageIndex = 0;
        }

        private void tbx_postalNo2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalNo2.Text) || string.IsNullOrWhiteSpace(tbx_postalNo2.Text))
                lbl_postalNo2.ImageIndex = 1;
            else
                lbl_postalNo2.ImageIndex = 0;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Next.BringToFront();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Previous.BringToFront();
        }

        private void tbx_street1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_street1.Text) || string.IsNullOrWhiteSpace(tbx_street1.Text))
                lbl_street1.ImageIndex = 0;
            else
                lbl_street1.ImageIndex = 0;
        }

        private void tbx_postalArea1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalArea1.Text) || string.IsNullOrWhiteSpace(tbx_postalArea1.Text))
                lbl_postalArea1.ImageIndex = 1;
            else
                lbl_postalArea1.ImageIndex = 0;
        }

        private void tbx_postalNo1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalNo1.Text) || string.IsNullOrWhiteSpace(tbx_postalNo1.Text))
                lbl_postalNo1.ImageIndex = 1;
            else
                lbl_postalNo2.ImageIndex = 0;
        }

        private void tbx_street2_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_street2.Text) || string.IsNullOrWhiteSpace(tbx_street2.Text))
                lbl_street2.ImageIndex = 1;
            else
                lbl_street2.ImageIndex = 0;
        }

        private void tbx_postalArea2_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalArea2.Text) || string.IsNullOrWhiteSpace(tbx_postalArea2.Text))
                lbl_postalArea2.ImageIndex = 1;
            else
                lbl_postalArea2.ImageIndex = 0;
        }

        private void tbx_postalNo2_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postalNo2.Text) || string.IsNullOrWhiteSpace(tbx_postalNo2.Text))
                lbl_postalNo2.ImageIndex = 1;
            else
                lbl_postalNo2.ImageIndex = 0;
        }
    }
}
