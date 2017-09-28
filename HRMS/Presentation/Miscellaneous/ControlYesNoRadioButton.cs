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

            if (radioButton1.Checked)
                result = radioButton1.Text;
            if (radioButton2.Checked)
                result = radioButton2.Text;

            return result;
        }
    }
}
