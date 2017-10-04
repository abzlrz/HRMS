using Data.Entities;
using Presentation.DialogBox.ExternalApplicationForm;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlBackgroundCheck : UserControl
    {
        #region properties
        public UserControl Previous { get; set; }
        #endregion

        public Illness illness;
        public Illness illness_perpetual;
        public MedicalOperation operation;
        public LegalConviction legal_conviction;
        public LegalCase legal_case;
        private bool illness_isDiagnosed;
        private bool illness_perpetual_isDiagnosed;
        private bool medical_isOperated;
        private bool legal_isConvicted;
        private bool legal_isLawsuited;
        public ControlBackgroundCheck()
        {
            InitializeComponent();
            this.illness = new Illness();
            this.illness_perpetual = new Illness();
            this.operation = new MedicalOperation();
            this.legal_conviction = new LegalConviction();
            this.legal_case = new LegalCase();
        }
        
        #region buttons
        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }
        #endregion

        private void OnLoad(object sender, System.EventArgs e)
        {

        }

        public bool ValidateFields()
        {
            bool result = true;

            if (q1.ImageIndex == 1)
                result = false;
            if (q2.ImageIndex == 1)
                result = false;
            if (q3.ImageIndex == 1)
                result = false;
            if (q4.ImageIndex == 1)
                result = false;
            if (q5.ImageIndex == 1)
                result = false;
            if (q6.ImageIndex == 1)
                result = false;

            return result;
        }
        public void LoadValues()
        {
            //
            // illness
            //
            this.illness.IsDiagnosed = illness_isDiagnosed;
            this.illness.Details = (q1.ImageIndex == -1) ? "-" : tbx_illness_details.Text;
            //
            // medical operation
            //
            this.operation.IsOperated = medical_isOperated;
            this.operation.Details = (q2.ImageIndex == -1) ? "-" : tbx_med_operation_details.Text;
            //
            // perpetual ilness
            //
            this.illness_perpetual.IsDiagnosed = illness_perpetual_isDiagnosed;
            this.illness_perpetual.Details = (q3.ImageIndex == -1) ? "-" : tbx_perpetual_illness.Text;
            //
            // legal conviction
            //
            this.legal_conviction.IsConvicted = legal_isConvicted;
            this.legal_conviction.Details = (q4.ImageIndex == -1) ? "-" : tbx_convicted_details.Text;
            //
            // legal case
            //
            this.legal_case.IsLawsuited = legal_isLawsuited;
            this.legal_case.Type = (q5.ImageIndex == -1) ? "-" : tbx_legalcase_type.Text;
            this.legal_case.Status = (q5.ImageIndex == -1) ? "-" : tbx_legalcase_status.Text;
        }

        #region Validation
        private void no_illness_CheckedChanged(object sender, System.EventArgs e)
        {
            if (no_illness.Checked)
            {
                illness_isDiagnosed = false;
                q1.ImageIndex = -1;
            }
            else
            {
                illness_isDiagnosed = true;
                q1.ImageIndex = 1;
            }
        }

        private void no_med_op_CheckedChanged(object sender, System.EventArgs e)
        {
            if (no_med_op.Checked)
            {
                medical_isOperated = false;
                q2.ImageIndex = -1;
            }
            else
            {
                medical_isOperated = true;
                q2.ImageIndex = 1;
            }
        }

        private void no_perpetual_CheckedChanged(object sender, System.EventArgs e)
        {
            if (no_perpetual.Checked)
            {
                illness_perpetual_isDiagnosed = false;
                q3.ImageIndex = -1;
            }
            else
            {
                illness_perpetual_isDiagnosed = true;
                q3.ImageIndex = 1;
            }
        }

        private void no_convicted_CheckedChanged(object sender, System.EventArgs e)
        {
            if (no_convicted.Checked)
            {
                legal_isConvicted = false;
                q4.ImageIndex = -1;
            }
            else
            {
                legal_isConvicted = true;
                q4.ImageIndex = 1;
            }
        }

        private void no_legalcase_CheckedChanged(object sender, System.EventArgs e)
        {
            if (no_convicted.Checked)
            {
                legal_isLawsuited = false;
                q5.ImageIndex = -1;
                q6.ImageIndex = -1;
            }
            else
            {
                legal_isLawsuited = true;
                q5.ImageIndex = 1;
                q6.ImageIndex = 1;
            }
        }

        private void tbx_illness_details_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_illness_details.Text, q1, 5);
        }

        private void tbx_med_operation_details_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_med_operation_details.Text, q2, 5);
        }

        private void tbx_perpetual_illness_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_perpetual_illness.Text, q3, 5);
        }

        private void tbx_convicted_details_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_convicted_details.Text, q4, 5);
        }

        private void tbx_legalcase_type_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_legalcase_type.Text, q5, 5);
        }

        private void tbx_legalcase_status_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_legalcase_status.Text, q6, 5);
        }
        #endregion
    }
}
