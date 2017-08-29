using Presentation.DialogBox;
using System;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class PerformanceAppraisal : UserControl
    {
        public PerformanceAppraisal()
        {
            InitializeComponent();
            this.appraisal = new EmployeePerformanceAppraisal();
        }

        private void OnPerformanceAppraisalToolStripMenuItemClick(object sender, EventArgs e)
        {
            appraisal.ShowDialog();
        }

        private EmployeePerformanceAppraisal appraisal;
    }
}
