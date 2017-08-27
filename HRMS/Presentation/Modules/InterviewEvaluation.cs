using System.Windows.Forms;
using Presentation.DialogBox;

namespace Presentation.Modules
{
    public partial class InterviewEvaluation : UserControl
    {
        private EvaluateApplicant evaluation;
        public InterviewEvaluation()
        {
            InitializeComponent();
            this.evaluation = new EvaluateApplicant();
        }

        private void OnEvaluateToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            evaluation.ShowDialog();
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
    }
}
