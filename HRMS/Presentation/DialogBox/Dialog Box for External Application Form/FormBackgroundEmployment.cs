using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundEmployment : Form
    {
        #region fields
        private Employee info;
        #endregion
        public FormBackgroundEmployment()
        {
            InitializeComponent();
        }

        #region methods
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
        private bool ValidateFields()
        {
            bool result = false;

            if (lbl_position.ImageIndex == 1)
                result = false;
            if (lbl_company.ImageIndex == 1)
                result = false;
            if (lbl_location.ImageIndex == 1)
                result = false;
            if (lbl_supervisor.ImageIndex == 1)
                result = false;
            if (lbl_from.ImageIndex == 1)
                result = false;
            if (lbl_to.ImageIndex == 1)
                result = false;
            if (lbl_nature.ImageIndex == 1)
                result = false;
            if (lbl_nature.ImageIndex == 1)
                result = false;
            if (lbl_reasonLeaving.ImageIndex == 1)
                result = false;

            return result;
        }
        #endregion

        #region If fields are empty conditions
        private void tbx_postionTitle_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_postionTitle.Text, lbl_position);
        }

        private void tbx_company_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_company.Text, lbl_company);
        }

        private void tbx_location_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_location.Text, lbl_location);
        }

        private void tbx_supervisor_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_supervisor.Text, lbl_supervisor);
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
            Misc.TurnGreenIndicator(tbx_nature.Text, lbl_nature);
        }

        private void tbx_compensation_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_compensation.Text, lbl_compensation);
        }

        private void tbx_reasonLeaving_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_reasonLeaving.Text, lbl_reasonLeaving);
        }
        #endregion
    }
}
