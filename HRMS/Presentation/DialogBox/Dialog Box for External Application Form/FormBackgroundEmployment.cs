using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundEmployment : Form
    {
        public FormBackgroundEmployment()
        {
            InitializeComponent();
        }
        private void ValidateDates(Label from, Label to, int toDateImgIndex, int fromDateImgIndex)
        {
            if (date_from.Value.ToShortDateString() == date_to.Value.ToShortDateString())
            {
                from.ImageIndex = 1;
                to.ImageIndex = 1;
            }
            else if (date_from.Value.ToShortDateString() != date_to.Value.ToShortDateString())
            {
                from.ImageIndex = 0;
                to.ImageIndex = 0;
            }
            else
            {
                from.ImageIndex = fromDateImgIndex;
                to.ImageIndex = toDateImgIndex;
            }
        }

        #region If fields are empty conditions
        private void tbx_postionTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_postionTitle.Text) || string.IsNullOrWhiteSpace(tbx_postionTitle.Text))
                lbl_position.ImageIndex = 1;
            else
                lbl_position.ImageIndex = 0;
        }

        private void tbx_company_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_company.Text) || string.IsNullOrWhiteSpace(tbx_company.Text))
                lbl_company.ImageIndex = 1;
            else
                lbl_company.ImageIndex = 0;
        }

        private void tbx_location_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_location.Text) || string.IsNullOrWhiteSpace(tbx_location.Text))
                lbl_location.ImageIndex = 1;
            else
                lbl_location.ImageIndex = 0;
        }

        private void tbx_supervisor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_supervisor.Text) || string.IsNullOrWhiteSpace(tbx_supervisor.Text))
                lbl_supervisor.ImageIndex = 1;
            else
                lbl_supervisor.ImageIndex = 0;
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            if (date_from.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                lbl_from.ImageIndex = 1;
            else
                ValidateDates(lbl_from, lbl_to, 1, 0);
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            if (date_to.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                lbl_to.ImageIndex = 1;
            else
                ValidateDates(lbl_from, lbl_to, 0, 1);
        }

        private void tbx_nature_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_nature.Text) || string.IsNullOrWhiteSpace(tbx_nature.Text))
                lbl_nature.ImageIndex = 1;
            else
                lbl_nature.ImageIndex = 0;
        }

        private void tbx_compensation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_compensation.Text) || string.IsNullOrWhiteSpace(tbx_compensation.Text))
                lbl_compensation.ImageIndex = 1;
            else
                lbl_compensation.ImageIndex = 0;
        }

        private void tbx_reasonLeaving_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_reasonLeaving.Text) || string.IsNullOrWhiteSpace(tbx_reasonLeaving.Text))
                lbl_reasonLeaving.ImageIndex = 1;
            else
                lbl_reasonLeaving.ImageIndex = 0;
        }
        #endregion
    }
}
