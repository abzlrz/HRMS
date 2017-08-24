using System.Windows.Forms;
using UI.SubForms;
namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeModules();
        }

        private void InitializeModules()
        {
            this.employeeform = new EmployeeRegistrationForm();
            this.interviewform = new InterviewEvaluationForm();
            this.performanceform = new PerformanceAppraisalForm();
            this.trainingform = new TrainingFeedbackAssesmentForm();
            this.checklistform = new PERChecklistForm();
            this.exitform = new ExitInterviewForm();
        }
        private void OnRegisterClick(object sender, System.EventArgs e)
        {
            employeeform.ShowDialog();
        }
        //private 

        private EmployeeRegistrationForm employeeform;
        private InterviewEvaluationForm interviewform;
        private PerformanceAppraisalForm performanceform;
        private TrainingFeedbackAssesmentForm trainingform;
        private PERChecklistForm checklistform;
        private ExitInterviewForm exitform;

        
    }
 
}
