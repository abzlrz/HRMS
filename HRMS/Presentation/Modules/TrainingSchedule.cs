using Presentation.DialogBox;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class TrainingSchedule : UserControl
    {
        public TrainingSchedule()
        {
            InitializeComponent();
            this.schedule = new EmployeeTrainingSchedule();
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

        private void OnScheduleTrainingToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            schedule.ShowDialog();
        }

        private EmployeeTrainingSchedule schedule;
    }
}
