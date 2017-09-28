using Data.Entities;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundEducation : Form
    {
        private BindingList<Education> educations;

        public FormBackgroundEducation()
        {
            InitializeComponent();
            ResetText();

            this.educations = new BindingList<Education>();
            this.bs_education = new BindingSource(educations, null);

            this.view_educ.DataSource = bs_education;
            this.view_educ.Columns["ApplicantID"].Visible = false;
            this.view_educ.Columns["CourseProgram"].HeaderText = "Program Course";
            this.view_educ.Columns["AcademicDegree"].HeaderText = "Academic Degree";
            this.view_educ.Columns["FromDate"].HeaderText = "From Date";
            this.view_educ.Columns["ToDate"].HeaderText = "To Date";

            this.educations.ListChanged += Educations_ListChanged;
        }

        private void ResetAddFields()
        {
            tbx_add_school.ResetText();
            tbx_add_location.ResetText();
            tbx_add_program.ResetText();
            cbx_add_degree.SelectedIndex = -1;
            date_add_from.ResetText();
            date_add_to.ResetText();
            lbl_add_from.ImageIndex = 1;
            lbl_add_to.ImageIndex = 1;
        }
        private void ResetEditFields()
        {
            tbx_edit_location.ResetText();
            tbx_edit_program.ResetText();
            tbx_edit_school.ResetText();
            cbx_edit_degree.SelectedIndex = -1;
            date_edit_from.ResetText();
            date_edit_to.ResetText();
            lbl_edit_from.ImageIndex = 1;
            lbl_edit_to.ImageIndex = 1;
        }
        private void RefreshData()
        {
            this.view_educ.DataSource = bs_education;
        }
        private bool ValidateAddFields()
        {
            bool result = true;

            if (lbl_add_school.ImageIndex == 1)
                result = false;
            if (lbl_add_location.ImageIndex == 1)
                result = false;
            if (lbl_add_degree.ImageIndex == 1)
                result = false;
            if (lbl_add_program.ImageIndex == 1)
                result = false;
            if (lbl_add_from.ImageIndex == 1)
                result = false;
            if (lbl_add_to.ImageIndex == 1)
                result = false;

            return result;
        }
        private bool ValidateEditFields()
        {
            bool result = true;

            if (lbl_edit_school.ImageIndex == 1)
                result = false;
            if (lbl_edit_location.ImageIndex == 1)
                result = false;
            if (lbl_edit_degree.ImageIndex == 1)
                result = false;
            if (lbl_edit_program.ImageIndex == 1)
                result = false;
            if (lbl_edit_from.ImageIndex == 1)
                result = false;
            if (lbl_edit_to.ImageIndex == 1)
                result = false;

            return result;
        }
        
        #region Events
        private void OnLoad(object sender, System.EventArgs e)
        {
            ResetText();
        }

        private void btn_add_save_Click(object sender, System.EventArgs e)
        {
            if (ValidateAddFields())
            {
                var education = new Education()
                {
                    School = tbx_add_school.Text,
                    Location = tbx_add_location.Text,
                    AcademicDegree = cbx_add_degree.Text,
                    CourseProgram = tbx_add_program.Text,
                    FromDate = date_add_from.Value,
                    ToDate = date_add_to.Value
                };

                educations.Add(education);
                ResetAddFields();
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void Educations_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (educations.Count == 0)
                btn_delete.Enabled = false;
            else
                btn_delete.Enabled = true;
        }

        private void tbx_add_school_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_school.Text, lbl_add_school);
        }

        private void tbx_add_location_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_location.Text, lbl_add_location);
        }

        private void cbx_add_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_degree.SelectedIndex, lbl_add_degree);
        }

        private void tbx_add_program_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_program.Text, lbl_add_program);
        }

        private void date_add_from_ValueChanged(object sender, EventArgs e)
        {
            lbl_add_from.ImageIndex = 0;
        }

        private void date_add_to_ValueChanged(object sender, EventArgs e)
        {
            lbl_add_to.ImageIndex = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                view_educ.Rows.Remove(view_educ.SelectedRows[0]);
                RefreshData();
                ResetEditFields();
                view_educ.ClearSelection();
            }
            catch { }
        }

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            int index = view_educ.SelectedRows[0].Index;

            if (ValidateEditFields())
            {
                var education = new Education()
                {
                    School = tbx_edit_school.Text,
                    Location = tbx_edit_location.Text,
                    AcademicDegree = cbx_edit_degree.Text,
                    CourseProgram = tbx_edit_program.Text,
                    FromDate = date_edit_from.Value,
                    ToDate = date_edit_to.Value
                };
                // Update Procedure
                educations[index] = education;
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void view_educ_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var item = view_educ.SelectedRows[0].DataBoundItem as Education;

                if (view_educ.SelectedRows.Count > 0)
                {
                    tbx_edit_school.Text = item.School;
                    tbx_edit_location.Text = item.Location;
                    cbx_edit_degree.Text = item.AcademicDegree;
                    tbx_edit_program.Text = item.CourseProgram;
                    date_edit_from.Value = item.FromDate;
                    date_edit_to.Value = item.ToDate;
                }
            }
            catch { }
        }
        private void tbx_edit_school_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_school.Text, lbl_edit_school);
        }

        private void tbx_edit_location_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_location.Text, lbl_edit_location);
        }

        private void cbx_edit_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_degree.SelectedIndex, lbl_edit_degree);
        }

        private void tbx_edit_program_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_program.Text, lbl_edit_program);
        }

        private void date_edit_from_ValueChanged(object sender, EventArgs e)
        {
            lbl_edit_from.ImageIndex = 0;
        }

        private void date_edit_to_ValueChanged(object sender, EventArgs e)
        {
            lbl_edit_to.ImageIndex = 0;
        }

        private void view_educ_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (view_educ.SelectedRows[0] == null)
                btn_delete.Enabled = false;
            else
                btn_delete.Enabled = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ResetEditFields();
            ResetAddFields();
            this.Hide();
        }

        private void FormBackgroundEducation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (educations.Count > 0)
            {
                DialogResult = MessageBox.Show("All data you input will be disregarded,\nAre you sure?",
                "Background Education", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    ResetAddFields();
                    ResetEditFields();
                    educations.Clear();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}
