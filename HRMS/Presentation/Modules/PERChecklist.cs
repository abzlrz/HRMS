using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class PERChecklist : UserControl
    {
        public PERChecklist()
        {
            InitializeComponent();
            this.appraisal = new PerformanceAppraisal();
        }

        private PerformanceAppraisal appraisal;
    }
}
