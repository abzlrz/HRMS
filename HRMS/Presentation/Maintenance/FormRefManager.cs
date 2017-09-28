using Data.Access;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Maintenance
{
    public partial class FormRefManager : Form
    {
        private DataAccess access;
        public FormRefManager()
        {
            InitializeComponent();
            this.access = new DataAccess();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
                LoadData(view_appSource, access.ShowApplicationSourceData(), "Source");
                LoadData(view_appraisal_type, access.ShowAppraisalTypeData(), "Type");
                LoadData(view_bucket, access.ShowBucketData(), "Description");
                LoadData(view_jobtitle, access.ShowJobTitleData(), "Title");
                LoadData(view_reason_analysis, access.ShowReasonAnalysisData(), "Description");
                LoadData(view_reason_leaving, access.ShowReasonForLeavingData(), "Description");
                LoadData(view_role, access.ShowRoleData(), "Description");
                LoadData(view_team, access.ShowTeamData(), "Description");
                LoadData(view_titantitle, access.ShowTitanTitleData(), "TitanTitle");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.ExitThread();
            }
        }
        private void LoadData(ListView view, DataTable table, string column)
        {
            view.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row[column].ToString());
                view.Items.Add(item);
            }
        }

        #region Behaviors
        private void FormOnShown(object sender, EventArgs e)
        {
            MessageBox.Show("Put values on the textbox first, \nthen Add button will be enabled",
                    "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void view_appSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_appSource.SelectedItems.Count > 0)
                btn_delete_appsource.Enabled = true;
            else
                btn_delete_appsource.Enabled = false;
        }

        private void view_appraisal_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_appraisal_type.SelectedItems.Count > 0)
                btn_delete_appraisaltype.Enabled = true;
            else
                btn_delete_appraisaltype.Enabled = false;
        }

        private void view_bucket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_bucket.SelectedItems.Count > 0)
                btn_delete_bucket.Enabled = true;
            else
                btn_delete_bucket.Enabled = false;
        }

        private void view_jobtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_jobtitle.SelectedItems.Count > 0)
                btn_delete_jobtitle.Enabled = true;
            else
                btn_delete_jobtitle.Enabled = false;
        }

        private void view_reason_analysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_reason_analysis.SelectedItems.Count > 0)
                btn_delete_reason_analysis.Enabled = true;
            else
                btn_delete_reason_analysis.Enabled = false;
        }

        private void view_reason_leaving_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_reason_leaving.SelectedItems.Count > 0)
                btn_delete_reason_leaving.Enabled = true;
            else
                btn_delete_reason_leaving.Enabled = false;
        }

        private void view_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_role.SelectedItems.Count > 0)
                btn_delete_role.Enabled = true;
            else
                btn_delete_role.Enabled = false;
        }

        private void view_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_team.SelectedItems.Count > 0)
                btn_delete_team.Enabled = true;
            else
                btn_delete_team.Enabled = false;
        }

        private void view_titantitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view_titantitle.SelectedItems.Count > 0)
                btn_delete_titantitle.Enabled = true;
            else
                btn_delete_titantitle.Enabled = false;
        }

        private void tbx_appSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_appSource.Text) || string.IsNullOrWhiteSpace(tbx_appSource.Text))
                btn_add_appsource.Enabled = false;
            else
                btn_add_appsource.Enabled = true;
        }

        private void tbx_appraisal_type_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_appraisal_type.Text) || string.IsNullOrWhiteSpace(tbx_appraisal_type.Text))
                btn_add_appraisaltype.Enabled = false;
            else
                btn_add_appraisaltype.Enabled = true;
        }

        private void tbx_bucket_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_bucket.Text) || string.IsNullOrWhiteSpace(tbx_bucket.Text))
                btn_add_bucket.Enabled = false;
            else
                btn_add_bucket.Enabled = true;
        }

        private void tbx_jobtitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_jobtitle.Text) || string.IsNullOrWhiteSpace(tbx_jobtitle.Text))
                btn_add_jobtitle.Enabled = false;
            else
                btn_add_jobtitle.Enabled = true;
        }

        private void tbx_reason_analysis_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_reason_analysis.Text) || string.IsNullOrWhiteSpace(tbx_reason_analysis.Text))
                btn_add_reason_analysis.Enabled = false;
            else
                btn_add_reason_analysis.Enabled = true;
        }

        private void tbx_reason_leaving_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_reason_leaving.Text) || string.IsNullOrWhiteSpace(tbx_reason_leaving.Text))
                btn_add_reason_leaving.Enabled = false;
            else
                btn_add_reason_leaving.Enabled = true;
        }

        private void tbx_role_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_role.Text) || string.IsNullOrWhiteSpace(tbx_role.Text))
                btn_add_role.Enabled = false;
            else
                btn_add_role.Enabled = true;
        }

        private void tbx_team_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_team.Text) || string.IsNullOrWhiteSpace(tbx_team.Text))
                btn_add_team.Enabled = false;
            else
                btn_add_team.Enabled = true;
        }

        private void tbx_titantitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_titantitle.Text) || string.IsNullOrWhiteSpace(tbx_titantitle.Text))
                btn_add_titantitle.Enabled = false;
            else
                btn_add_titantitle.Enabled = true;
        }

        #endregion

        #region Inserting

        private void btn_add_appsource_Click(object sender, EventArgs e)
        {
            var success = access.InsertAppSource(tbx_appSource.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_appSource, access.ShowApplicationSourceData(), "Source");
                tbx_appSource.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_appraisaltype_Click(object sender, EventArgs e)
        {
            var success = access.InsertAppraisalType(tbx_appraisal_type.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_appraisal_type, access.ShowAppraisalTypeData(), "Type");
                tbx_appraisal_type.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_bucket_Click(object sender, EventArgs e)
        {
            var success = access.InsertBucket(tbx_bucket.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_bucket, access.ShowBucketData(), "Description");
                tbx_bucket.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_jobtitle_Click(object sender, EventArgs e)
        {
            var success = access.InsertJobTitle(tbx_jobtitle.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_jobtitle, access.ShowJobTitleData(), "Title");
                tbx_jobtitle.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_reason_analysis_Click(object sender, EventArgs e)
        {
            var success = access.InsertReasonAnalysis(tbx_reason_analysis.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_reason_analysis, access.ShowReasonAnalysisData(), "Description");
                tbx_reason_analysis.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_reason_leaving_Click(object sender, EventArgs e)
        {
            var success = access.InsertReasonForLeaving(tbx_reason_leaving.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_reason_leaving, access.ShowReasonForLeavingData(), "Description");
                tbx_reason_leaving.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_role_Click(object sender, EventArgs e)
        {
            var success = access.InsertRole(tbx_role.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_role, access.ShowRoleData(), "Description");
                tbx_role.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_team_Click(object sender, EventArgs e)
        {
            var success = access.InsertTeam(tbx_team.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_team, access.ShowTeamData(), "Description");
                tbx_team.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_add_titantitle_Click(object sender, EventArgs e)
        {
            var success = access.InsertTitanTitle(tbx_titantitle.Text);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                LoadData(view_titantitle, access.ShowTitanTitleData(), "TitanTitle");
                tbx_titantitle.ResetText();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }
        #endregion

        private void btn_delete_appsource_Click(object sender, EventArgs e)
        {
            var success = access.DeleteApplicationSource(view_appSource.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_appSource, access.ShowApplicationSourceData(), "Source");
                tbx_appSource.ResetText();
                btn_delete_appsource.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_appraisaltype_Click(object sender, EventArgs e)
        {
            var success = access.DeleteAppraisalType(view_appraisal_type.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_appraisal_type, access.ShowAppraisalTypeData(), "Type");
                tbx_appraisal_type.ResetText();
                btn_delete_appraisaltype.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_bucket_Click(object sender, EventArgs e)
        {
            var success = access.DeleteBucket(view_bucket.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_bucket, access.ShowBucketData(), "Description");
                tbx_appraisal_type.ResetText();
                btn_delete_bucket.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_jobtitle_Click(object sender, EventArgs e)
        {
            var success = access.DeleteJobTitle(view_jobtitle.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_jobtitle, access.ShowJobTitleData(), "Title");
                tbx_jobtitle.ResetText();
                btn_delete_jobtitle.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_reason_analysis_Click(object sender, EventArgs e)
        {
            var success = access.DeleteReasonAnalysis(view_reason_analysis.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_reason_analysis, access.ShowReasonAnalysisData(), "Description");
                tbx_reason_analysis.ResetText();
                btn_delete_reason_analysis.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_reason_leaving_Click(object sender, EventArgs e)
        {
            var success = access.DeleteReasonForLeaving(view_reason_leaving.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_reason_leaving, access.ShowReasonForLeavingData(), "Description");
                tbx_reason_leaving.ResetText();
                btn_delete_reason_leaving.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_role_Click(object sender, EventArgs e)
        {
            var success = access.DeleteRole(view_role.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_role, access.ShowRoleData(), "Description");
                tbx_role.ResetText();
                btn_delete_role.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_team_Click(object sender, EventArgs e)
        {
            var success = access.DeleteTeam(view_team.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_team, access.ShowTeamData(), "Description");
                tbx_team.ResetText();
                btn_delete_team.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_delete_titantitle_Click(object sender, EventArgs e)
        {
            var success = access.DeleteTitanTitle(view_titantitle.SelectedItems[0].Text);
            if (success)
            {
                MessageBox.Show("Deleted!");
                LoadData(view_titantitle, access.ShowTitanTitleData(), "TitanTitle");
                tbx_titantitle.ResetText();
                btn_delete_titantitle.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}