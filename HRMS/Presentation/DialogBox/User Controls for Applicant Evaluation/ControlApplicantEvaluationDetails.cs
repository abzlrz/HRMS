using System.Windows.Forms;

namespace Presentation.DialogBox.ApplicantEvaluation
{
    public partial class ControlApplicantEvaluationDetails : UserControl
    {
        public UserControl Next { get; set; }

        public ControlApplicantEvaluationDetails()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            cbx_arvatoLevel.SelectedIndex = -1;
            cbx_bucket.SelectedIndex = -1;
            cbx_jobTitle.SelectedIndex = -1;
            cbx_languageRequirement.SelectedIndex = -1;
            cbx_managerID.SelectedIndex = -1;
            cbx_managerName.SelectedIndex = -1;
            cbx_titanTitle.SelectedIndex = -1;
        }
        #endregion

        #region If fields are empty conditions
        private void cbx_jobTitle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_jobTitle.Text, lbl_jobTitle);
        }

        private void cbx_bucket_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_bucket.SelectedIndex, lbl_bucket);
        }

        private void cbx_titanTitle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_titanTitle.Text, lbl_titanTitle);
        }

        private void cbx_languageRequirement_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_languageRequirement.SelectedIndex, lbl_langRequirement);
        }

        private void cbx_arvatoLevel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_arvatoLevel.SelectedIndex, lbl_arvatoLevel);
        }

        private void cbx_managerID_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_managerID.SelectedIndex, lbl_managerID);
        }

        private void cbx_managerName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_managerName.SelectedIndex, lbl_managerName);
        }
        #endregion
    }
}
