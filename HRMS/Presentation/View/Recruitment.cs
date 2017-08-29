using System.Windows.Forms;
using Presentation.Modules;

namespace Presentation.View
{
    public partial class VRecruitment : UserControl
    {
        public VRecruitment()
        {
            InitializeComponent();

            this.interviewEvaluation = new InterviewEvaluation();
            this.employeeRegistration = new EmployeeRegistration();
            this.dasboard = new RecruitmentDashboard();
            this.employeeRegistrationExisting = new ExistingEmployeeRegistration();
            this.checklist = new PERChecklist();
            this.performanceAppraisal = new PerformanceAppraisal();
        }

        public PERChecklist checklist;
        public RecruitmentDashboard dasboard;
        public EmployeeRegistration employeeRegistration;
        public InterviewEvaluation interviewEvaluation;
        public ExistingEmployeeRegistration employeeRegistrationExisting;
        public PerformanceAppraisal performanceAppraisal;
    }
}
