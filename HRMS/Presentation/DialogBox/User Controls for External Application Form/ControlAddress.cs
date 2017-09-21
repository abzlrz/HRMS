using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlAddress : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        #endregion

        public ControlAddress()
        {
            InitializeComponent();
        }

        #region methods
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_street1.ImageIndex == 1)
                result = false;
            if (lbl_street2.ImageIndex == 1)
                result = false;
            if (lbl_postalArea1.ImageIndex == 1)
                result = false;
            if (lbl_postalArea2.ImageIndex == 1)
                result = false;
            if (lbl_postalNo1.ImageIndex == 1)
                result = false;
            
            return result;
        }
        #endregion


        #region if fields are empty conditions

        private void tbx_street1_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_street1.Text, lbl_street1);
        }

        private void tbx_postalArea1_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_postalArea1.Text, lbl_postalArea1);
        }

        private void tbx_postalNo1_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_postalNo1.Text, lbl_postalNo1);
        }

        private void tbx_street2_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_street2.Text, lbl_street2);
        }

        private void tbx_postalArea2_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_postalArea2.Text, lbl_postalArea2);
        }

        private void tbx_postalNo2_TextChanged_1(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_postalNo2.Text, lbl_postalNo2);
        }
        #endregion

        #region buttons
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Previous.BringToFront();
        }
        #endregion
    }
}
