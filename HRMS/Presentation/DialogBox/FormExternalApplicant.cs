using Data.Access;
using Data.Entities;
using Presentation.DialogBox.ExternalApplication;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormExternalApplicant : Form
    {
        private ExternalApplicant applicant;
        private ExternalApplicantAccess access_applicant;
        private JobPostingAccess access_jobposting;
        public int jobPostingID;
        public FormExternalApplicant()
        {
            InitializeComponent();
            this.access_applicant = new ExternalApplicantAccess();
            this.access_jobposting = new JobPostingAccess();
            this.applicant = new ExternalApplicant();
            this.controlOtherDetails1.btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, System.EventArgs e)
        {
            controlOtherDetails1.LoadValues();
            applicant.Applicant = controlPersonalInformation1.applicant;
            applicant.Contacts = controlPersonalInformation1.contact;
            applicant.PermanentAddress = controlAddress1.permanent_address;
            applicant.PresentAddress = controlAddress1.present_address;
            applicant.ApplicationSource = controlApplicationDetails1.source;
            applicant.ApplicationPosition = controlApplicationDetails1.position;
            applicant.EducationHistory = controlApplicationDetails1.table_education;
            applicant.EmploymentHistory = controlApplicationDetails1.table_employment;
            applicant.Illness = controlOtherDetails1.illness;
            applicant.PerpetualIllness = controlOtherDetails1.illness_perpetual;
            applicant.MedicalOperation = controlOtherDetails1.operation;
            applicant.LegalConviction = controlOtherDetails1.legal_conviction;
            applicant.LegalCase = controlOtherDetails1.legal_case;

            var success = access_applicant.InsertData(applicant);
            if (success)
            {

            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            DataRow row_jobposting = access_jobposting.GetDataByID(jobPostingID);
            this.controlApplicationDetails1.lbl_position_title.Text = row_jobposting["Position"].ToString();
            this.controlApplicationDetails1.lbl_site.Text = row_jobposting["Location"].ToString();
        }
    }
}
