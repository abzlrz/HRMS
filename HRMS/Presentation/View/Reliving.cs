using System.Windows.Forms;
using Presentation.Modules;

namespace Presentation.View
{
    public partial class VReliving : UserControl
    {
        public VReliving()
        {
            InitializeComponent();
            this.resignation = new EmployeeResignation();
            this.dashboard = new RelivingDashboard();
        }

        public EmployeeResignation resignation;
        public RelivingDashboard dashboard;
    }
}
