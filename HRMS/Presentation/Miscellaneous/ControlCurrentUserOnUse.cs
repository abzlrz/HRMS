using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class ControlCurrentUserOnUse : UserControl
    {
        public ControlCurrentUserOnUse()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            toolTip.SetToolTip(EmployeeID, EmployeeID.Text);
            toolTip.SetToolTip(Firstname, Firstname.Text);
            toolTip.SetToolTip(Lastname, Lastname.Text);
        }
    }
}
