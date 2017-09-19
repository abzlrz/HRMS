using Presentation.DialogBox;
using System;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class ControlPerformanceAppraisal : UserControl
    {
        public ControlPerformanceAppraisal()
        {
            InitializeComponent();
            this.appraisal = new FormEmployeePerformanceAppraisal();
        }

        private void OnPerformanceAppraisalToolStripMenuItemClick(object sender, EventArgs e)
        {
            appraisal.ShowDialog();
        }

        private FormEmployeePerformanceAppraisal appraisal;
    }
}
