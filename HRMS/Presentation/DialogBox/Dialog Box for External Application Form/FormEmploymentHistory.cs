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
        private BindingList<Employment> employments;

        public FormEmploymentHistory()
        {
            InitializeComponent();
            ResetText();

            this.employments = new BindingList<Employment>();
            this.bs_employment = new BindingSource(employments, null);

            this.view_employee.DataSource = bs_employment;
            this.view_employee.Columns["ApplicantID"].Visible = false;
            this.view_employee.Columns["PositionTitle"].HeaderText = "Position Title";
            this.view_employee.Columns["MonthlyCompensation"].HeaderText = "Monthly Compensation";
            this.view_employee.Columns["ReasonForLeaving"].HeaderText = "Reason for Leaving";

            this.employments.ListChanged += Employments_ListChanged;
        }

        private void Employments_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (employments.Count == 0)
                btn_delete.Enabled = false;
            else
                btn_delete.Enabled = true;
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
        private void RefreshData()
        {
            this.view_employee.DataSource = bs_employment;
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

        #region Events

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        private void btn_add_save_Click(object sender, EventArgs e)
        {
            if (ValidateAddFields())
            {
                var employment = new Employment()
                {
                    PositionTitle = tbx_add_postionTitle.Text,
                    Company = tbx_add_company.Text,
                    Location = tbx_add_location.Text,
                    Supervisor = tbx_add_supervisor.Text,
                    FromDate = date_add_from.Value,
                    ToDate = date_add_to.Value,
                    Nature = tbx_add_nature.Text,
                    MonthlyCompensation = decimal.Parse(tbx_add_compensation.Text),
                    ReasonForLeaving = tbx_add_compensation.Text
                };

                employments.Add(employment);
                ResetAddFields();
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            if (ValidateEditFields())
            {
                int index = view_employee.SelectedRows[0].Index;
                var employment = new Employment()
                {
                    PositionTitle = tbx_add_postionTitle.Text,
                    Company = tbx_add_company.Text,
                    Location = tbx_add_location.Text,
                    Supervisor = tbx_add_supervisor.Text,
                    FromDate = date_add_from.Value,
                    ToDate = date_add_to.Value,
                    Nature = tbx_add_nature.Text,
                    MonthlyCompensation = decimal.Parse(tbx_add_compensation.Text),
                    ReasonForLeaving = tbx_add_compensation.Text
                };

                employments[index] = employment;
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void view_employee_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var item = view_employee.SelectedRows[0].DataBoundItem as Employment;

                if (view_employee.SelectedRows.Count > 0)
                {
                    tbx_edit_position.Text = item.PositionTitle;
                    tbx_edit_company.Text = item.Company;
                    tbx_edit_location.Text = item.Location;
                    tbx_edit_supervisor.Text = item.Supervisor;
                    date_edit_from.Value = item.FromDate;
                    date_edit_to.Value = item.ToDate;
                    tbx_edit_nature.Text = item.Nature;
                    tbx_edit_compensation.Text = item.MonthlyCompensation.ToString();
                    tbx_edit_reason.Text = item.ReasonForLeaving;
                }
            }
            catch { }
        }
        private void OnLoad(object sender, System.EventArgs e)
        {
            ResetText();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                view_employee.Rows.Remove(view_employee.SelectedRows[0]);
                RefreshData();
                ResetEditFields();
                view_employee.ClearSelection();
            }
            catch { }
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
            lbl_date_from.ImageIndex = 1;
        }

        private void date_edit_to_ValueChanged(object sender, EventArgs e)
        {
            lbl_date_to.ImageIndex = 1;
        }

        private void tbx_edit_nature_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_nature.Text, lbl_edit_nature);
        }

        private void tbx_edit_reason_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_reason.Text, lbl_edit_reason);
        }

        private void FormEmploymentHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (employments.Count > 0)
            {
                DialogResult = MessageBox.Show("All data you input will be disregarded,\nAre you sure?",
                "Background Education", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    ResetAddFields();
                    ResetEditFields();
                    employments.Clear();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ResetEditFields();
            ResetAddFields();
            this.Hide();
        }
        #endregion
    }
}
