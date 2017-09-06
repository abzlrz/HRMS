using System.Windows.Forms;

namespace Presentation.DialogBox.BackgroundHistory
{
    public partial class LegalHistory : UserControl
    {
        public LegalHistory()
        {
            InitializeComponent();
        }

        void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        private void yesConvicted_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(true, convictionPanel);
        }

        private void noConvicted_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(false, convictionPanel);
        }

        private void yesLegalCase_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(true, legalCasePanel);
        }

        private void noLegalCase_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableControls(false, legalCasePanel);
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            
        }
    }
}
