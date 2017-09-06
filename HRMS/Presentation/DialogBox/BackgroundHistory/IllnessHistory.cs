using System.Windows.Forms;

namespace Presentation.DialogBox.BackgroundHistory
{
    public partial class IllnessHistory : UserControl
    {
        public IllnessHistory()
        {
            InitializeComponent();
        }

        void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
        }

        private void yesIllness_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(true, illnessPanel);
        }

        private void noIllness_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(false, illnessPanel);
        }

        private void yesOperation_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(true, operationPanel);
        }

        private void noOperation_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(false, operationPanel);
        }
    }
}
