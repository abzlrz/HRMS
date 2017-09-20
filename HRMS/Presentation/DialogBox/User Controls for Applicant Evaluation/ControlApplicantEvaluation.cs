using System.Windows.Forms;

namespace Presentation.DialogBox.ApplicantEvaluation
{
    public partial class ControlApplicantEvaluation : UserControl
    {
        public UserControl Previous { get; set; }
        public ControlApplicantEvaluation()
        {
            InitializeComponent();
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            tableLayoutPanel1.ClearAll();
        }
    }
}
