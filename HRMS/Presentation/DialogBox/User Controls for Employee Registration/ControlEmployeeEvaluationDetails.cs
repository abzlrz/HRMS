using System.Windows.Forms;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeEvaluationDetails : UserControl
    {
        public UserControl Next { get; set; }
        public ControlEmployeeEvaluationDetails()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }
    }
}
