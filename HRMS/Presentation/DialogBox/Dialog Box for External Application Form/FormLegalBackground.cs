using Data.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormLegalBackground : Form
    {
        #region fields
        private BindingList<LegalCase> legalBackground;
        private BindingList<LegalConviction> legalConviction;
        private string _IsLawsuited => confirmationLegalCase.GetRadioButtonValue();
        private string _IsConvicted => confirmationLegalConviction.GetRadioButtonValue();
        #endregion

        public FormLegalBackground()
        {
            InitializeComponent();
            this.legalBackground = new BindingList<LegalCase>();
            this.legalConviction = new BindingList<LegalConviction>();
        }

        #region methods
        void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        private bool ValidateFields()
        {
            bool result = true;

            if(_IsLawsuited == "Yes")
            {
                if (lbl_case.ImageIndex == 1)
                    result = false;
            }

            if(_IsConvicted == "Yes")
            {
                if (lbl_conviction.ImageIndex == 1)
                    result = false;
            }

            return result;
        }
        #endregion

        #region If fields are empty conditions
        private void tbx_conviction_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_conviction.Text, lbl_conviction);
        }

        private void tbx_case_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_case.Text, lbl_case);
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
