using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ShowSlides : Form
    {
        ApplicationForm applicationForm = new ApplicationForm();
        InterviewEvaluationForm interviewForm = new InterviewEvaluationForm();
        EmployeeRegistrationForm registrationForm = new EmployeeRegistrationForm();
        PerformanceAppraisalForm appraisalForm = new PerformanceAppraisalForm();
        LoginForm loginForm = new LoginForm();
        MainForm mainform = new MainForm();
        TrainingFeedbackAssesmentForm trainingForm = new TrainingFeedbackAssesmentForm();
        SubForms.TrainingScheduleDialogForm scheduleForm = new SubForms.TrainingScheduleDialogForm();
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
    }
}
