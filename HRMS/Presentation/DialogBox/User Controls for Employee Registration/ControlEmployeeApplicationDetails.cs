using System.Windows.Forms;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeApplicationDetails : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }

        public ControlEmployeeApplicationDetails()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            tbx_agencyFee.ResetText();
            tbx_agencyName.ResetText();
            tbx_referralDue.ResetText();
        }
    }
}
