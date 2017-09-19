using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class ControlPERChecklist : UserControl
    {
        public ControlPERChecklist()
        {
            InitializeComponent();
            this.appraisal = new ControlPerformanceAppraisal();
        }

        private ControlPerformanceAppraisal appraisal;

        private void label16_Click(object sender, System.EventArgs e)
        {

        }
    }
}
