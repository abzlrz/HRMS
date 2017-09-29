using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class ControlYesNoRadioButton : UserControl
    {
        public ControlYesNoRadioButton()
        {
            InitializeComponent();
        }
        public string GetValue()
        {
            string result = string.Empty;

            if (Yes.Checked)
                result = Yes.Text;
            if (No.Checked)
                result = No.Text;

            return result;
        }
    }
}
