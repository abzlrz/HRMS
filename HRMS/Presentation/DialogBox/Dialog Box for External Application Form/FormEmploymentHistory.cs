using Data.Entities;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Data;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormEmploymentHistory : Form
    {
        public DataTable table_employment;

        public FormEmploymentHistory()
        {
            InitializeComponent();
            this.table_employment = new DataTable();
        }
        
        public bool CheckValue()
        {
            return this.table_employment.Rows.Count > 0;
        }
        private void ResetAddFields()
        {
            tbx_add_company.ResetText();
            tbx_add_location.ResetText();
            tbx_add_nature.ResetText();
            tbx_add_postionTitle.ResetText();
            tbx_add_reason.ResetText();
            tbx_add_supervisor.ResetText();
            tbx_add_compensation.ResetText();

            date_add_from.ResetText();
            date_add_to.ResetText();
            lbl_add_from.ImageIndex = 1;
            lbl_add_to.ImageIndex = 1;
        }
        private void ResetEditFields()
        {
            tbx_edit_company.ResetText();
            tbx_edit_location.ResetText();
            tbx_edit_nature.ResetText();
            tbx_edit_position.ResetText();
            tbx_edit_reason.ResetText();
            tbx_edit_supervisor.ResetText();
            tbx_edit_compensation.ResetText();

            date_edit_from.ResetText();
            date_edit_to.ResetText();
            lbl_date_from.ImageIndex = 1;
            lbl_date_to.ImageIndex = 1;
        }

        private bool ValidateAddFields()
        {
            bool result = true;

            if (lbl_add_position.ImageIndex == 1)
                result = false;
            if (lbl_add_company.ImageIndex == 1)
                result = false;
            if (lbl_add_location.ImageIndex == 1)
                result = false;
            if (lbl_add_from.ImageIndex == 1)
                result = false;
            if (lbl_add_to.ImageIndex == 1)
                result = false;
            if (lbl_add_nature.ImageIndex == 1)
                result = false;
            if (lbl_add_reasonLeaving.ImageIndex == 1)
                result = false;

            return result;
        }
        private bool ValidateEditFields()
        {
            bool result = true;

            if (lbl_edit_position.ImageIndex == 1)
                result = false;
            if (lbl_edit_company.ImageIndex == 1)
                result = false;
            if (lbl_edit_location.ImageIndex == 1)
                result = false;
            if (lbl_date_from.ImageIndex == 1)
                result = false;
            if (lbl_date_to.ImageIndex == 1)
                result = false;
            if (lbl_edit_nature.ImageIndex == 1)
                result = false;
            if (lbl_edit_reason.ImageIndex == 1)
                result = false;

            return result;
        }
        
        private DataTable GetEmployments()
        {
            this.table_employment.Columns.Add("ApplicantID", typeof(int));
            this.table_employment.Columns.Add("PositionTitle", typeof(string));
            this.table_employment.Columns.Add("Company", typeof(string));
            this.table_employment.Columns.Add("Location", typeof(string));
            this.table_employment.Columns.Add("Supervisor", typeof(string));
            this.table_employment.Columns.Add("FromDate", typeof(string));
            this.table_employment.Columns.Add("ToDate", typeof(string));
            this.table_employment.Columns.Add("Nature", typeof(string));
            this.table_employment.Columns.Add("MonthlyCompensation", typeof(string));
            this.table_employment.Columns.Add("ReasonForLeaving", typeof(string));

            return table_employment;
        }

        public void ImplementNotSortable(DataGridView view)
        {
            view.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        #region Events

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        private void btn_add_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAddFields())
                {
                    var row = new Employment()
                    {
                        ApplicantID = 0,
                        PositionTitle = tbx_add_postionTitle.Text,
                        Company = tbx_add_company.Text,
                        Location = tbx_add_location.Text,
                        Supervisor = tbx_add_supervisor.Text,
                        FromDate = date_add_from.Value,
                        ToDate = date_add_to.Value,
                        Nature = tbx_add_nature.Text,
                        MonthlyCompensation = decimal.Parse(tbx_add_compensation.Text),
                        ReasonForLeaving = tbx_add_reason.Text
                    };

                    table_employment.Rows.Add(row.ApplicantID,
                        row.PositionTitle,
                        row.Company,
                        row.Location,
                        row.Supervisor,
                        row.FromDate,
                        row.ToDate,
                        row.Nature,
                        row.MonthlyCompensation,
                        row.ReasonForLeaving);

                    MessageBox.Show("Data Successfully Added!");
                }
                else
                {
                    MessageBox.Show("Please complete the fields!");
                }
            }
            catch { }
            finally
            {
                view_employee.ClearSelection();
                ResetAddFields();
            }
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEditFields())
                {
                    var row = new Employment()
                    {
                        ApplicantID = 0,
                        PositionTitle = tbx_edit_position.Text,
                        Company = tbx_edit_company.Text,
                        Location = tbx_edit_location.Text,
                        Supervisor = tbx_edit_supervisor.Text,
                        FromDate = date_edit_from.Value,
                        ToDate = date_edit_to.Value,
                        Nature = tbx_edit_nature.Text,
                        MonthlyCompensation = decimal.Parse(tbx_edit_compensation.Text),
                        ReasonForLeaving = tbx_edit_reason.Text
                    };

                    table_employment.Rows.RemoveAt(view_employee.SelectedRows[0].Index);
                    table_employment.Rows.Add(row.ApplicantID,
                        row.PositionTitle,
                        row.Company,
                        row.Location,
                        row.Supervisor,
                        row.FromDate,
                        row.ToDate,
                        row.Nature,
                        row.MonthlyCompensation,
                        row.ReasonForLeaving);

                    btn_edit_save.Enabled = false;
                    btn_delete.Enabled = false;

                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("Please complete all the required fields!");
                }
            }
            catch { }
            finally
            {
                view_employee.ClearSelection();
                ResetEditFields();
            }
        }

        private void view_employee_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(view_employee.SelectedRows.Count > 0)
                {
                    var item = table_employment.Rows[view_employee.SelectedRows[0].Index];

                    tbx_edit_position.Text = item["PositionTitle"].ToString();
                    tbx_edit_company.Text = item["Company"].ToString();
                    tbx_edit_location.Text = item["Location"].ToString();
                    tbx_edit_supervisor.Text = item["Supervisor"].ToString();
                    date_edit_from.Value = DateTime.Parse(item["FromDate"].ToString());
                    date_edit_to.Value = DateTime.Parse(item["ToDate"].ToString());
                    tbx_edit_nature.Text = item["Nature"].ToString();
                    tbx_edit_compensation.Text = item["MonthlyCompensation"].ToString();
                    tbx_edit_reason.Text = item["ReasonForLeaving"].ToString();

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
        private void OnLoad(object sender, System.EventArgs e)
        {
            //
            // employment datagridview
            //
            if (view_employee.DataSource is null)
            {
                this.view_employee.DataSource = GetEmployments();
                this.view_employee.Columns["ApplicantID"].Visible = false;
                ImplementNotSortable(view_employee);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                table_employment.Rows.RemoveAt(view_employee.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_employee.ClearSelection();
                ResetEditFields();
            }
        }

        private void tbx_add_postionTitle_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_postionTitle.Text, lbl_add_position);
        }

        private void tbx_add_company_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_company.Text, lbl_add_company);
        }

        private void tbx_add_location_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_location.Text, lbl_add_location);
        }

        private void date_add_from_ValueChanged(object sender, EventArgs e)
        {
            lbl_add_from.ImageIndex = 0;
        }

        private void date_add_to_ValueChanged(object sender, EventArgs e)
        {
            lbl_add_to.ImageIndex = 0;
        }

        private void tbx_add_nature_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_nature.Text, lbl_add_nature);
        }

        private void tbx_add_reason_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_reason.Text, lbl_add_reasonLeaving);
        }

        private void tbx_edit_position_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_position.Text, lbl_edit_position);
        }

        private void tbx_edit_company_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_company.Text, lbl_edit_company);
        }

        private void tbx_edit_location_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_location.Text, lbl_edit_location);
        }

        private void date_edit_from_ValueChanged(object sender, EventArgs e)
        {
            lbl_date_from.ImageIndex = 0;
        }

        private void date_edit_to_ValueChanged(object sender, EventArgs e)
        {
            lbl_date_to.ImageIndex = 0;
        }

        private void tbx_edit_nature_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_nature.Text, lbl_edit_nature);
        }

        private void tbx_edit_reason_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_reason.Text, lbl_edit_reason);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (view_employee.Rows.Count is 0)
                table_employment.Columns.Clear();
            this.Hide();
        }
        #endregion

        private void view_employee_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(view_employee.Rows.Count > 0)
            {
                btn_edit_save.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}
