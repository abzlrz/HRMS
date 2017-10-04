using Data.Entities;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Data;
using System.Linq;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundEducation : Form
    {
        public DataTable table_education;

        public FormBackgroundEducation()
        {
            InitializeComponent();
            this.table_education = new DataTable();
        }

        public bool CheckValue()
        {
            return table_education.Rows.Count > 0;
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
            //
            // education datagridview
            //
            if (view_educ.DataSource is null)
            {
                this.view_educ.DataSource = GetEducations();
                this.view_educ.Columns["ApplicantID"].Visible = false;
                ImplementNotSortable(view_educ);
            }
        }

        private DataTable GetEducations()
        {
            this.table_education.Columns.Add("ApplicantID", typeof(int));
            this.table_education.Columns.Add("School", typeof(string));
            this.table_education.Columns.Add("Location", typeof(string));
            this.table_education.Columns.Add("AcademicDegree", typeof(string));
            this.table_education.Columns.Add("CourseProgram", typeof(string));
            this.table_education.Columns.Add("FromDate", typeof(DateTime));
            this.table_education.Columns.Add("ToDate", typeof(DateTime));

            return table_education;
        }
        public void ImplementNotSortable(DataGridView view)
        {
            view.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void btn_add_save_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ValidateAddFields())
                {
                    var row = new Education()
                    {
                        ApplicantID = 0,
                        School = tbx_add_school.Text,
                        Location = tbx_add_location.Text,
                        AcademicDegree = cbx_add_degree.Text,
                        CourseProgram = tbx_add_program.Text,
                        FromDate = date_add_from.Value,
                        ToDate = date_add_to.Value
                    };

                    table_education.Rows.Add(row.ApplicantID,
                        row.School,
                        row.Location,
                        row.AcademicDegree,
                        row.CourseProgram,
                        row.FromDate,
                        row.ToDate);

                    MessageBox.Show("Data Successfully Added!");
                }
                else
                {
                    MessageBox.Show("Please complete all the required fields!");
                }
            }
            catch { }
            finally
            {
                view_educ.ClearSelection();
                ResetAddFields();
            }
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
                table_education.Rows.RemoveAt(view_educ.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_educ.ClearSelection();
                ResetEditFields();
            }
        }

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEditFields())
                {
                    var row = new Education()
                    {
                        ApplicantID = 0,
                        School = tbx_edit_school.Text,
                        Location = tbx_edit_location.Text,
                        AcademicDegree = cbx_edit_degree.Text,
                        CourseProgram = tbx_edit_program.Text,
                        FromDate = date_edit_from.Value,
                        ToDate = date_edit_to.Value
                    };

                    table_education.Rows.RemoveAt(view_educ.SelectedRows[0].Index);
                    table_education.Rows.Add(row.ApplicantID,
                        row.School,
                        row.Location,
                        row.AcademicDegree,
                        row.CourseProgram,
                        row.FromDate,
                        row.ToDate);

                    btn_edit_save.Enabled = false;
                    btn_delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please complete all the required fields!");
                }
            }
            catch { }
            finally
            {
                MessageBox.Show("Saved!");
                view_educ.ClearSelection();
                ResetEditFields();
            }
        }

        private void view_educ_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(view_educ.SelectedRows.Count > 0)
                {
                    var item = table_education.Rows[view_educ.SelectedRows[0].Index];

                    tbx_edit_school.Text = item["School"].ToString();
                    tbx_edit_location.Text = item["Location"].ToString();
                    cbx_edit_degree.Text = item["AcademicDegree"].ToString();
                    tbx_edit_program.Text = item["CourseProgram"].ToString();
                    date_edit_from.Value = DateTime.Parse(item["FromDate"].ToString());
                    date_edit_to.Value = DateTime.Parse(item["ToDate"].ToString());

                    btn_edit_save.Enabled = true;
                    btn_delete.Enabled = true;
                }
                else
                {
                    btn_edit_save.Enabled = false;
                    btn_delete.Enabled = false;
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
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            ResetEditFields();
            ResetAddFields();
            this.Hide();
        }

        private void FormBackgroundEducation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        private void view_educ_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(view_educ.Rows.Count > 0)
            {
                btn_edit_save.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}
