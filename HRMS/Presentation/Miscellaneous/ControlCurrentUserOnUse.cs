using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class ControlCurrentUserOnUse : UserControl
    {
        private string _id;
        private string _firstname;
        private string _lastname;

        public ControlCurrentUserOnUse()
        {
            InitializeComponent();

            l_employeeID.Text = _id;
            l_firstname.Text = _firstname;
            l_lastname.Text = _lastname;
        }

        public void SetCurrentUser(string id, string firstname, string lastname)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            toolTip.SetToolTip(l_employeeID, l_employeeID.Text);
            toolTip.SetToolTip(l_firstname, l_firstname.Text);
            toolTip.SetToolTip(l_lastname, l_lastname.Text);
        }
    }
}
