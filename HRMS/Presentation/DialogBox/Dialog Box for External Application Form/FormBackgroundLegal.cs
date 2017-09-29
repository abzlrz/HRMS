using Data.Entities;
using System;
using System.Windows.Forms;
using System.Drawing;
using Data.Access;
using System.Data;
using System.Linq;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundLegal : Form
    {
        public DataTable table_legalcase;
        public DataTable table_conviction;

        private DataAccess access;
        public FormBackgroundLegal()
        {
            InitializeComponent();
            this.IsLawsuited.Yes.ForeColor = Color.White;
            this.IsLawsuited.No.ForeColor = Color.White;
            this.IsConvicted.Yes.ForeColor = Color.White;
            this.IsConvicted.No.ForeColor = Color.White;
            this.IsLawsuited.Yes.CheckedChanged += RadioButton1_CheckedChanged;
            this.IsLawsuited.No.CheckedChanged += RadioButton2_CheckedChanged;
            this.IsConvicted.Yes.CheckedChanged += RadioButton1_CheckedChanged1;
            this.IsConvicted.No.CheckedChanged += RadioButton2_CheckedChanged1;
            
            this.access = new DataAccess();
            this.table_legalcase = new DataTable();
            this.table_conviction = new DataTable();
        }
        public bool CheckValue()
        {
            bool legalcase_haveVal = table_legalcase != null;
            bool conviction_haveVal = table_conviction != null;
            return legalcase_haveVal && conviction_haveVal;
        }
        private void EnableControl(bool arg, DataGridView view, Panel panel)
        {
            view.Enabled = arg;
            panel.Enabled = arg;
        }
        private void CheckIfNoHaveValues_Conviction()
        {
            if (table_conviction.Rows.Count > 0)
                table_conviction.Rows.RemoveAt(0);
        }

        private void CheckIfNoHaveValues_LegalCase()
        {
            if (table_legalcase.Rows.Count > 0)
                table_legalcase.Rows.RemoveAt(0);
        }
        private void CheckNoValues()
        {
            if(IsLawsuited.GetValue() == "No")
            {
                table_legalcase.Rows.Add(0, IsLawsuited.GetValue(), null, null);
                table_legalcase.Rows.RemoveAt(0);
                CheckIfNoHaveValues_LegalCase();
            }

            if(IsConvicted.GetValue() == "No")
            {
                table_conviction.Rows.Add(0, IsConvicted.GetValue(), null, null);
                table_conviction.Rows.RemoveAt(0);
                CheckIfNoHaveValues_Conviction();
            }
        }
        private bool ValidateFields()
        {
            bool result = true;

            if (IsLawsuited.Yes.Checked == true)
            {
                if (view_legalcase.Rows.Count > 0)
                    result = true;
                else
                    result = false;
            }

            if (IsConvicted.Yes.Checked == true)
            {
                if (view_conviction.Rows.Count > 0)
                    result = true;
                else
                    result = false;
            }

            return result;
        }
        private void ResetFieldsLegalCase()
        {
            tbx_legalcase_description.ResetText();
            tbx_legalcase_details.ResetText();
        }

        private DataTable GetLegalCaseData()
        {
            this.table_legalcase.Columns.Add("ApplicantID", typeof(int));
            this.table_legalcase.Columns.Add("IsLawsuited", typeof(string));
            this.table_legalcase.Columns.Add("Description", typeof(string));
            this.table_legalcase.Columns.Add("Details", typeof(string));

            return table_legalcase;
        }

        private DataTable GetConvictionData()
        {
            this.table_conviction.Columns.Add("ApplicantID", typeof(int));
            this.table_conviction.Columns.Add("IsConvicted", typeof(string));
            this.table_conviction.Columns.Add("Description", typeof(string));
            this.table_conviction.Columns.Add("Details", typeof(string));

            return table_conviction;
        }
        
        public void ImplementNotSortable(DataGridView view)
        {
            view.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private bool ValidateOperationFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_conviction_desc.Text) ||
                string.IsNullOrWhiteSpace(tbx_conviction_details.Text))
                result = false;

            if (string.IsNullOrEmpty(tbx_conviction_details.Text) ||
                string.IsNullOrWhiteSpace(tbx_conviction_details.Text))
                result = false;

            return result;
        }

        private bool ValidateIllnessFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_legalcase_description.Text) ||
               string.IsNullOrWhiteSpace(tbx_legalcase_description.Text))
                result = false;

            if (string.IsNullOrEmpty(tbx_legalcase_details.Text) ||
                string.IsNullOrWhiteSpace(tbx_legalcase_details.Text))
                result = false;

            return result;
        }

        #region Events
        private void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {
            EnableControl(false, view_conviction, panel_operations);
        }

        private void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            EnableControl(true, view_conviction, panel_operations);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(false, view_legalcase, panel_illness);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(true, view_legalcase, panel_illness);
        }
        #endregion 

        private void OnLoad(object sender, EventArgs e)
        {
            //
            // illness datagridview
            //
            if(view_legalcase.DataSource is null)
            {
                this.view_legalcase.DataSource = GetLegalCaseData();
                this.view_legalcase.Columns["ApplicantID"].Visible = false;
                this.view_legalcase.Columns["IsLawsuited"].Visible = false;
                ImplementNotSortable(view_legalcase);
            }
            //
            // medical operation datagridview
            //
            if(view_conviction.DataSource is null)
            {
                this.view_conviction.DataSource = GetConvictionData();
                this.view_conviction.Columns["ApplicantID"].Visible = false;
                this.view_conviction.Columns["IsConvicted"].Visible = false;
                ImplementNotSortable(view_conviction);
            }

            CheckNoValues();
        }

        private void btn_illness_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateIllnessFields())
                {
                    var row = new LegalCase()
                    {
                        ApplicantID = 0,
                        IsLawsuited = IsLawsuited.GetValue(),
                        Description = tbx_legalcase_description.Text,
                        Details = tbx_legalcase_details.Text
                    };

                    table_legalcase.Rows.Add(row.ApplicantID,
                        row.IsLawsuited,
                        row.Description,
                        row.Details);

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
                view_legalcase.ClearSelection();
                ResetFieldsLegalCase();
            }
        }

        private void btn_illness_delete_Click(object sender, EventArgs e)
        {
            try
            {
                table_legalcase.Rows.RemoveAt(view_legalcase.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_legalcase.ClearSelection();
                ResetFieldsLegalCase();
            }
        }

        private void btn_operated_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateOperationFields())
                {
                    var row = new LegalConviction()
                    {
                        ApplicantID = 0,
                        IsConvicted = IsConvicted.GetValue(),
                        Description = tbx_conviction_desc.Text,
                        Details = tbx_conviction_details.Text
                    };

                    table_conviction.Rows.Add(row.ApplicantID,
                        row.IsConvicted,
                        row.Description,
                        row.Details);

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
                view_legalcase.ClearSelection();
                ResetFieldsConvicted();
            }
        }

        private void btn_operated_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(view_conviction.SelectedRows.Count > 0)
                    table_conviction.Rows.RemoveAt(view_conviction.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_conviction.ClearSelection();
                ResetFieldsConvicted();
            }
        }

        private void ResetFieldsConvicted()
        {
            tbx_conviction_desc.ResetText();
            tbx_conviction_details.ResetText();
        }

        private void view_illness_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(view_legalcase.Rows.Count > 0)
            {
                btn_legalcase_delete.Enabled = true;
            }
        }

        private void view_operations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (view_conviction.Rows.Count > 0)
            {
                btn_conviction_delete.Enabled = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                this.Hide();
            }
            else
            {
                CheckNoValues();
                MessageBox.Show("Your input data is required!");
            }
        }
    }
}