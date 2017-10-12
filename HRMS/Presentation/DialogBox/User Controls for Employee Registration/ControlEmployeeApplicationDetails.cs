using Data.Access;
using System.Data;
using System.Windows.Forms;
using System;
using Data.Entities;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeApplicationDetails : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        private ExternalApplicantAccess access;
        public ReferralDue referral;
        public int ID;

        public ControlEmployeeApplicationDetails()
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            tbx_agencyFee.ResetText();
            tbx_agencyName.ResetText();
            tbx_referralDue.ResetText();
        }

        private void ControlEmployeeApplicationDetails_Load(object sender, System.EventArgs e)
        {
            DataRow row = access.GetApplicationSource(ID);
            string appSource = row["ApplicationSource"].ToString();

            lbl_applicationSource.Text = appSource;
            lbl_referralID.Text = appSource.Equals("Employee Referral") ? row["ReferralEmployeeID"].ToString() : "";
            lbl_referralName.Text = appSource.Equals("Employee Referral") ? row["ReferralName"].ToString() : "";
        }
    }
}
