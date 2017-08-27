using Presentation.Modules;
using System.Windows.Forms;

namespace Presentation.View
{
    public partial class Training : UserControl
    {
        public Training()
        {
            InitializeComponent();
            this.dashboard = new TrainingDashboard();
            this.trainingFeedback = new TrainingFeedback();
            this.trainingSchedule = new TrainingSchedule();
        }

        public TrainingDashboard dashboard;
        public TrainingFeedback trainingFeedback;
        public TrainingSchedule trainingSchedule;
    }
}
