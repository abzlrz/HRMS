using Presentation.DialogBox;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class ControlTrainingFeedback : UserControl
    {
        private FormEmployeeTrainingFeedback feedback;
        public ControlTrainingFeedback()
        {
            InitializeComponent();
            this.feedback = new FormEmployeeTrainingFeedback();
        }

        #region Help Button
        private void OnP1MouseUp(object sender, MouseEventArgs e)
        {
            p1.Image = global::Presentation.Properties.Resources.Help;
        }

        private void OnP1MouseDown(object sender, MouseEventArgs e)
        {
            p1.Image = global::Presentation.Properties.Resources.Help_small;
        }
        #endregion

        private void OnTrainingFeedbackToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            feedback.ShowDialog();
        }
    }
}
