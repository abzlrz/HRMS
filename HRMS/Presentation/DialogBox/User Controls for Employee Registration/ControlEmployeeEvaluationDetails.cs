using Data.Access;
using Data.Entities;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeEvaluationDetails : UserControl
    {
        private ExternalApplicantAccess access;
        public UserControl Next { get; set; }
        public int ID;

        public ControlEmployeeEvaluationDetails()
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }

        private void ControlEmployeeEvaluationDetails_Load(object sender, System.EventArgs e)
        {
            DataRow row = access.GetEvalDetails(ID);

            lbl_name.Text = row["ApplicantName"].ToString();
            lbl_hiringManager.Text = row["HiringManagerName"].ToString();
            lbl_hiringManagerID.Text = row["HiringManagerID"].ToString();
            lbl_jobTitle.Text = row["JobTitle"].ToString();
            lbl_titanTitle.Text = row["TitanTitle"].ToString();
            lbl_langRequirements.Text = row["LanguageRequirement"].ToString().Equals("1") ? "Yes" : "No";
            lbl_bucket.Text = row["Bucket"].ToString();
            lbl_arvatoLevel.Text = row["ArvatoLevel"].ToString();
        }
    }
}
