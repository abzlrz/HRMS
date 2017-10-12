using Data.Access;
using Data.Entities;
using Presentation.Miscellaneous;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEvaluateApplicant : Form
    {
        public int Id;
        public ExternalApplicantAccess access;
        public FormEvaluateApplicant(int ID)
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
            this.Id = ID;

            this.ctrl_eval.btn_accept.Click += AcceptApplicant;
            this.ctrl_eval.btn_reject.Click += RejectApplicant;
            this.ctrl_eval.btn_shortlist.Click += ShortlistApplicant;
        }

        private void ShortlistApplicant(object sender, EventArgs e)
        {
            try
            {
                ctrl_eval.LoadData();

                var interview = new InterviewEvaluation()
                {
                    Id = Id,
                    Details = ctrl_eval_details.evaluation,
                    InterviewQuestions = ctrl_eval.questions
                };

                var success = access.SaveInterview(interview);
                if (success)
                {
                    access.SaveResult(Id, "Shortlisted");
                    MessageBox.Show("Applicant shortlisted!");
                }
            }
            catch { }
            finally
            {
                this.Hide();
            }
        }

        private void RejectApplicant(object sender, EventArgs e)
        {
            try
            {
                ctrl_eval.LoadData();

                var interview = new InterviewEvaluation()
                {
                    Id = Id,
                    Details = ctrl_eval_details.evaluation,
                    InterviewQuestions = ctrl_eval.questions
                };

                var success = access.SaveInterview(interview);
                if (success)
                {
                    access.SaveResult(Id, "Rejected");
                    var msgbox = new FormReApplicationDate(Id);

                    if(msgbox.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Applicant rejected!");
                    }
                }
            }
            catch { }
            finally
            {
                this.Hide();
            }
        }

        private void AcceptApplicant(object sender, EventArgs e)
        {
            try
            {
                ctrl_eval.LoadData();

                var interview = new InterviewEvaluation()
                {
                    Id = Id,
                    Details = ctrl_eval_details.evaluation,
                    InterviewQuestions = ctrl_eval.questions
                };

                var success = access.SaveInterview(interview);
                if (success)
                {
                    access.SaveResult(Id, "Accepted");
                    MessageBox.Show("Applicant accepted!");

                    var form = new FormRegisterEmployee(Id);
                    form.ShowDialog();
                }
            }
            catch { }
            finally
            {
                this.Hide();
            }
        }
        
        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
                DataRow row = access.GetApplicantByID(Id);
                ctrl_eval_details.lbl_name.Text = row["Name"].ToString();
                ctrl_eval_details.lbl_applicationDate.Text = row["ApplicationDate"].ToString();
                ctrl_eval_details.lbl_positionApplied.Text = row["Position"].ToString();
            }
            catch
            {
                this.Hide();
            }
        }
    }
}
