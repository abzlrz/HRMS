using Presentation.DialogBox.ExternalApplicationForm;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlBackgroundCheck : UserControl
    {
        #region properties
        public UserControl Previous { get; set; }
        #endregion
        
        public ControlBackgroundCheck()
        {
            InitializeComponent();
        }
        
        #region buttons
        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }
        #endregion
    }
}
