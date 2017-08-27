using System.Windows.Forms;
using Presentation.Modules;

namespace Presentation.View
{
    public partial class Recruitment : UserControl
    {
        public Recruitment()
        {
            InitializeComponent();

            this.interviewEvaluation = new InterviewEvaluation();
            this.employeeRegistration = new EmployeeRegistration();
            this.dasboard = new RecruitmentDashboard();
            this.employeeRegistrationExisting = new ExistingEmployeeRegistration();
        }
        public RecruitmentDashboard dasboard;
        public EmployeeRegistration employeeRegistration;
        public InterviewEvaluation interviewEvaluation;
        public ExistingEmployeeRegistration employeeRegistrationExisting;
    }
}
