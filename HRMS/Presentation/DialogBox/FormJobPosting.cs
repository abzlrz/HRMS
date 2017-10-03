using Data.Access;
using Presentation.DialogBox.JobPosting;
using System.IO;
using System.Windows.Forms;
using System;
using System.Data;

namespace Presentation.DialogBox
{
    public partial class FormJobPosting : Form
    {
        private JobPostingAccess access;
        private DataAccess access1;
        private FormRichTextbox form_add_qualification;
        private FormRichTextbox form_add_jobdesc;
        private FormRichTextbox form_add_benefits;
        private FormRichTextbox form_edit_qualification;
        private FormRichTextbox form_edit_jobdesc;
        private FormRichTextbox form_edit_benefits;
        private int ID;
        private BindingSource binding_source;

        public FormJobPosting()
        {
            InitializeComponent();
            this.access = new JobPostingAccess();
            this.access1 = new DataAccess();
            this.form_add_qualification = new FormRichTextbox();
            this.form_add_jobdesc = new FormRichTextbox();
            this.form_add_benefits = new FormRichTextbox();
            this.form_edit_qualification = new FormRichTextbox();
            this.form_edit_jobdesc = new FormRichTextbox();
            this.form_edit_benefits = new FormRichTextbox();
            this.binding_source = new BindingSource();

            this.binding_source.DataSource = access.ShowData();
            this.view_posting.DataSource = binding_source;

            this.form_edit_benefits.Values.TextChanged += Form_Edit_BenefitsValues_Textchanged;
            this.form_edit_jobdesc.Values.TextChanged += Form_Edit_JobDescValues_Textchanged;
            this.form_edit_qualification.Values.TextChanged += Form_Edit_QualificationValues_Textchanged;
        }

        

        #region Methods
        private void ResetAddFields()
        {
            tbx_add_comment.ResetText();
            tbx_add_headcount.ResetText();
            cbx_add_positiontype.ResetText();
            tbx_add_wage.ResetText();
            date_add_close.ResetText();
            date_add_posted.ResetText();
            cbx_add_location.SelectedIndex = -1;
            cbx_add_position.SelectedIndex = -1;
        }
        private void ResetFields()
        {
            tbx_add_comment.ResetText();
            tbx_add_headcount.ResetText();
            cbx_add_positiontype.ResetText();
            tbx_add_wage.ResetText();
            tbx_edit_comment.ResetText();
            tbx_edit_headcount.ResetText();
            cbx_edit_position.ResetText();
            cbx_edit_positiontype.ResetText();
            tbx_edit_wage.ResetText();
            tbx_search.ResetText();
            date_add_close.ResetText();
            date_add_posted.ResetText();
            date_edit_close.ResetText();
            date_edit_posted.ResetText();
            cbxSearchBy.SelectedIndex = -1;
            cbx_add_location.SelectedIndex = -1;
            cbx_add_position.SelectedIndex = -1;
            cbx_edit_location.SelectedIndex = -1;
        }
        private void RefreshData()
        {
            this.binding_source.DataSource = access.ShowData();
            this.view_posting.DataSource = binding_source;
        }
        private bool ValidateAddFields()
        {
            bool result = true;

            if (lbl_add_positiontype.ImageIndex == 1)
                result = false;
            if (lbl_add_position.ImageIndex == 1)
                result = false;
            if (lbl_add_headcount.ImageIndex == 1)
                result = false;
            if (lbl_add_location.ImageIndex == 1)
                result = false;
            if (lbl_add_benefits.ImageIndex == 1)
                result = false;
            if (lbl_add_qualification.ImageIndex == 1)
                result = false;
            if (lbl_add_jobdesc.ImageIndex == 1)
                result = false;

            return result;
        }
        private bool ValidateEditFields()
        {
            bool result = true;

            if (lbl_edit_positiontype.ImageIndex == 1)
                result = false;
            if (lbl_edit_position.ImageIndex == 1)
                result = false;
            if (lbl_edit_headcount.ImageIndex == 1)
                result = false;
            if (lbl_edit_location.ImageIndex == 1)
                result = false;
            if (lbl_edit_benefits.ImageIndex == 1)
                result = false;
            if (lbl_edit_qualification.ImageIndex == 1)
                result = false;
            if (lbl_edit_jobdesc.ImageIndex == 1)
                result = false;

            return result;
        }
        private void PopulateFields(int Id)
        {
            DataRow row = access.GetDataByID(Id);
            cbx_edit_positiontype.Text = row["PositionType"].ToString();
            cbx_edit_position.Text = row["Position"].ToString();
            date_edit_posted.Value = DateTime.Parse(row["PostedDate"].ToString());
            date_edit_close.Value = DateTime.Parse(row["CloseDate"].ToString());
            tbx_edit_wage.Text = row["Wage"].ToString();
            tbx_edit_headcount.Text = row["HeadCount"].ToString();
            cbx_edit_location.Text = row["Location"].ToString();
            form_edit_benefits.Values.Text = row["Benefits"].ToString();
            form_edit_qualification.Values.Text = row["Qualification"].ToString();
            form_edit_jobdesc.Values.Text = row["JobDescription"].ToString();
            tbx_edit_comment.Text = row["Comments"].ToString();
        }
        
        #endregion

        #region Events 
        private void btn_reset_Click(object sender, System.EventArgs e)
        {
            ResetAddFields();
        }
        private void Form_Edit_QualificationValues_Textchanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(form_edit_qualification.Values.Text, lbl_edit_qualification, form_edit_qualification.MinChars);
        }

        private void Form_Edit_JobDescValues_Textchanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(form_edit_jobdesc.Values.Text, lbl_edit_jobdesc, form_edit_jobdesc.MinChars);
        }

        private void Form_Edit_BenefitsValues_Textchanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(form_edit_benefits.Values.Text, lbl_edit_benefits, form_edit_benefits.MinChars);
        }
        private void FormJobPosting_Load(object sender, System.EventArgs e)
        {
            //
            // jobposting datagridview
            //
            this.view_posting.DataSource = binding_source;
            this.view_posting.Columns["ID"].Visible = false;
            this.view_posting.Columns["Qualification"].Visible = false;
            this.view_posting.Columns["JobDescription"].Visible = false;
            this.view_posting.Columns["Comments"].Visible = false;
            //
            // add_position combobox
            //
            this.cbx_add_position.DataSource = access1.ShowJobTitleData();
            this.cbx_add_position.DisplayMember = "Title";
            this.cbx_add_position.ValueMember = "Title";
            this.cbx_add_position.SelectedIndex = -1;
            //
            // edit_position combobox
            //
            this.cbx_edit_position.DataSource = access1.ShowJobTitleData();
            this.cbx_edit_position.DisplayMember = "Title";
            this.cbx_edit_position.ValueMember = "Title";
            this.cbx_edit_position.SelectedIndex = -1;
            //
            // add_position type combobox
            //
            this.cbx_add_positiontype.DataSource = access1.ShowTitanTitleData();
            this.cbx_add_positiontype.DisplayMember = "Title";
            this.cbx_add_positiontype.ValueMember = "TitanTitle";
            this.cbx_add_positiontype.SelectedIndex = -1;
            //
            // edit_position type combobox
            //
            this.cbx_edit_positiontype.DataSource = access1.ShowTitanTitleData();
            this.cbx_edit_positiontype.DisplayMember = "Title";
            this.cbx_edit_positiontype.ValueMember = "TitanTitle";
            this.cbx_edit_positiontype.SelectedIndex = -1;
            //
            // form rich textbox qualification, job description, & benefits
            //
            this.form_add_qualification.Text = "Add Job Qualifications";
            this.form_add_jobdesc.Text = "Add Job Description";
            this.form_add_benefits.Text = "Add Benefits Details";
            this.form_edit_qualification.Text = "Edit Job Qualification";
            this.form_edit_jobdesc.Text = "Edit Job Description";
            this.form_edit_benefits.Text = "Edit Benefits Details";
            this.form_add_qualification.MinChars = 10;
            this.form_add_jobdesc.MinChars = 10;
            this.form_add_benefits.MinChars = 15;
            this.form_edit_qualification.MinChars = 10;
            this.form_edit_jobdesc.MinChars = 10;
            this.form_edit_benefits.MinChars = 15;
            // clear all
            //
            this.view_posting.ClearSelection();
            ResetFields();
        }
        
        private void cbx_add_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_position.SelectedIndex, lbl_add_position);
        }

        private void tbx_add_headcount_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_headcount.Text, lbl_add_headcount, 1);
        }

        private void cbx_add_location_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_location.SelectedIndex, lbl_add_location);
        }

        private void link_add_qualification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(form_add_qualification.ShowDialog() == DialogResult.OK)
            {
                Misc.TurnGreenIndicator(form_add_qualification.Values.Text, lbl_add_qualification, form_add_qualification.MinChars);
            }
        }

        private void link_add_jobdesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(form_add_jobdesc.ShowDialog() == DialogResult.OK)
            {
                Misc.TurnGreenIndicator(form_add_jobdesc.Values.Text, lbl_add_jobdesc, form_add_jobdesc.MinChars);
            }
        }
        private void link_add_benefits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (form_add_benefits.ShowDialog() == DialogResult.OK)
            {
                Misc.TurnGreenIndicator(form_add_benefits.Values.Text, lbl_add_benefits, form_add_benefits.MinChars);
            }
        }

        private void link_edit_benefits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_edit_benefits.ShowDialog();
        }
        private void link_edit_jobdesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_edit_jobdesc.ShowDialog();
        }

        private void link_edit_qualification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_edit_qualification.ShowDialog();
        }

        private void cbx_edit_location_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_location.SelectedIndex, lbl_edit_location);
        }

        private void tbx_edit_headcount_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_headcount.Text, lbl_edit_headcount, 1);
        }

        private void tbx_edit_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_position.Text, lbl_edit_position);
        }
        
        private void btn_add_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ValidateAddFields())
                {
                    var item = new Data.Entities.JobPosting()
                    {
                        ID = 0,
                        PositionType = cbx_add_positiontype.Text,
                        Position = cbx_add_position.Text,
                        PostedDate = date_add_posted.Value,
                        CloseDate = date_add_close.Value,
                        Wage = tbx_add_wage.Text,
                        HeadCount = int.Parse(tbx_add_headcount.Text),
                        Benefits = form_add_benefits.Values.Text,
                        Qualification = form_add_qualification.Values.Text,
                        JobDescription = form_add_jobdesc.Values.Text,
                        Location = cbx_add_location.Text,
                        Comments = tbx_add_comment.Text
                    };

                    if (access.InsertUpdateData(item))
                    {
                        MessageBox.Show("Data Successfully Added!");
                        view_posting.ClearSelection();
                        btn_delete.Enabled = false;
                        btn_save.Enabled = false;
                        RefreshData();
                        ResetAddFields();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all the fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }
        }

        private void view_posting_SelectionChanged(object sender, System.EventArgs e)
        {
            var gdv = sender as DataGridView;
            if (gdv.SelectedRows.Count > 0)
            {
                ID = int.Parse(gdv.SelectedRows[0].Cells[0].Value.ToString());
                btn_delete.Enabled = true;
                btn_save.Enabled = true;
                PopulateFields(ID);
            }
            else
            {
                btn_delete.Enabled = false;
                btn_save.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEditFields())
                {
                    var item = new Data.Entities.JobPosting()
                    {
                        ID = ID,
                        PositionType = cbx_edit_positiontype.Text,
                        Position = cbx_edit_position.Text,
                        PostedDate = date_edit_posted.Value,
                        CloseDate = date_edit_close.Value,
                        Wage = tbx_edit_wage.Text,
                        HeadCount = int.Parse(tbx_edit_headcount.Text),
                        Benefits = form_edit_benefits.Values.Text,
                        Qualification = form_edit_qualification.Values.Text,
                        JobDescription = form_edit_jobdesc.Values.Text,
                        Location = cbx_edit_location.Text,
                        Comments = tbx_edit_comment.Text
                    };

                    if (access.InsertUpdateData(item))
                    {
                        MessageBox.Show("Data Successfully Added!");
                        RefreshData();
                        ResetAddFields();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all the fields!");
                }
            }
            catch { }
        }

        private void cbx_edit_positiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_positiontype.SelectedIndex, lbl_edit_positiontype);
        }

        private void cbx_add_positiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_positiontype.SelectedIndex, lbl_add_positiontype);
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            switch (cbxSearchBy.SelectedIndex)
            {
                case -1:
                    tbx_search.TextChanged -= tbx_search_TextChanged;
                    MessageBox.Show("Choose a field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbx_search.ResetText();
                    tbx_search.TextChanged += tbx_search_TextChanged;
                    break;

                case 0:
                    binding_source.Filter = string.Format("Location like '%{0}%'", tbx_search.Text);
                    break;

                case 1:
                    binding_source.Filter = string.Format("PositionType like '%{0}%'", tbx_search.Text);
                    break;

                case 2:
                    binding_source.Filter = string.Format("Position like '%{0}%'", tbx_search.Text);
                    break;

                case 3:
                    binding_source.Filter = string.Format("PostedDate like '%{0}%'", tbx_search.Text);
                    break;

                default:
                    break;
            }
        }
        #endregion

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.access.Delete(ID))
                    {
                        MessageBox.Show("Deleted!");
                        RefreshData();
                        ResetText();
                    }
                }
            }
        }
    }
}
