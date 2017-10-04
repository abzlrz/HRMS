using Data.Access;
using Presentation.DialogBox.JobPosting;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormCheckVacancies : Form
    {
        private JobPostingAccess access;
        private BindingSource binding_source;
        private FormRichTextbox qualification;
        private FormRichTextbox job_desc;
        private FormRichTextbox benefits;
        private int ID;

        public FormCheckVacancies()
        {
            InitializeComponent();
            this.access = new JobPostingAccess();

            this.binding_source = new BindingSource();
            this.binding_source.DataSource = access.ShowData();
            this.view_posting.DataSource = binding_source;

            this.view_posting.Columns["ID"].Visible = false;
            this.view_posting.Columns["Qualification"].Visible = false;
            this.view_posting.Columns["JobDescription"].Visible = false;
            this.view_posting.Columns["Comments"].Visible = false;

            this.qualification = new FormRichTextbox();
            this.qualification.Values.ReadOnly = true;
            this.qualification.Text = "Qualification";

            this.job_desc = new FormRichTextbox();
            this.job_desc.Values.ReadOnly = true;
            this.job_desc.Text = "Job Description";

            this.benefits = new FormRichTextbox();
            this.benefits.Values.ReadOnly = true;
            this.benefits.Text = "Benefits";
            
        }

        private void ReloadData()
        {
            this.binding_source.DataSource = access.ShowData();
            this.view_posting.DataSource = binding_source;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var applicant = new FormExternalApplicant();
            applicant.jobPostingID = ID;
            applicant.ShowDialog();
        }

        private void FormCheckVacancies_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void view_employee_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var gridview = sender as DataGridView;

                if (view_posting.SelectedRows.Count > 0)
                {
                    this.panel.Enabled = true;

                    ID = int.Parse(gridview.SelectedRows[0].Cells[0].Value.ToString());
                    var item = access.GetDataByID(ID);

                    lbl_detail_positiontype.Text = item["PositionType"].ToString();
                    lbl_detail_position.Text = item["Position"].ToString();
                    lbl_detail_posteddate.Text = item["PostedDate"].ToString();
                    lbl_detail_closedate.Text = item["CloseDate"].ToString();
                    lbl_detail_wage.Text = item["Wage"].ToString();
                    lbl_detail_headcount.Text = item["HeadCount"].ToString();
                    lbl_detail_location.Text = item["Location"].ToString();
                    benefits.Values.Text = item["Benefits"].ToString();
                    qualification.Values.Text = item["Qualification"].ToString();
                    job_desc.Values.Text = item["JobDescription"].ToString();
                }
                else
                {
                    this.panel.Enabled = false;
                }
            }
            catch { }
            finally
            {

            }
        }

        private void link_detail_qualification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.qualification.ShowDialog();
        }

        private void link_detail_jobdesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.job_desc.ShowDialog();
        }

        private void link_benefits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.benefits.ShowDialog();
        }
    }
}
