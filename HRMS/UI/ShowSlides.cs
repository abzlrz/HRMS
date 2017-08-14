using System;
using System.Windows.Forms;
using UI.SubForms;
namespace UI
{
    public partial class ShowSlides : Form
    {
        public ShowSlides()
        {
            InitializeComponent();
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            applicationForm.ShowDialog();
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            registrationForm.ShowDialog();
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            interviewForm.ShowDialog();
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            mainform.ShowDialog();
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            appraisalForm.ShowDialog();
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            trainingForm.ShowDialog();
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            scheduleForm.ShowDialog();
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            checkListForm.ShowDialog();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            exitForm.ShowDialog();
        }


        private ApplicationForm applicationForm = new ApplicationForm();
        private InterviewEvaluationForm interviewForm = new InterviewEvaluationForm();
        private EmployeeRegistrationForm registrationForm = new EmployeeRegistrationForm();
        private PerformanceAppraisalForm appraisalForm = new PerformanceAppraisalForm();
        private LoginForm loginForm = new LoginForm();
        private MainForm mainform = new MainForm();
        private TrainingFeedbackAssesmentForm trainingForm = new TrainingFeedbackAssesmentForm();
        private TrainingScheduleDialogForm scheduleForm = new TrainingScheduleDialogForm();
        private PERChecklistForm checkListForm = new PERChecklistForm();
        private ExitInterviewForm exitForm = new ExitInterviewForm();

        
    }
}
