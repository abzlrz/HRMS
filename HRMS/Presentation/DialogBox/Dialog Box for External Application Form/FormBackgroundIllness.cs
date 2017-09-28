﻿using Data.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Data.Access;
using System.Data;
using System.Linq;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundIllness : Form
    {
        public DataTable table_illnesses;
        public DataTable table_operations;

        private DataAccess access;
        public FormBackgroundIllness()
        {
            InitializeComponent();
            this.IsDiagnosedByIlness.radioButton1.ForeColor = Color.White;
            this.IsDiagnosedByIlness.radioButton2.ForeColor = Color.White;
            this.IsMedOperated.radioButton1.ForeColor = Color.White;
            this.IsMedOperated.radioButton2.ForeColor = Color.White;
            this.IsDiagnosedByIlness.radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            this.IsDiagnosedByIlness.radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            this.IsMedOperated.radioButton1.CheckedChanged += RadioButton1_CheckedChanged1;
            this.IsMedOperated.radioButton2.CheckedChanged += RadioButton2_CheckedChanged1;
            
            this.access = new DataAccess();
            this.table_illnesses = new DataTable();
            this.table_operations = new DataTable();
        }
        
        private void EnableControl(bool arg, DataGridView view, Panel panel)
        {
            view.Enabled = arg;
            panel.Enabled = arg;
        }

        private void ResetIllnessFields()
        {
            tbx_illness_description.ResetText();
            tbx_illness_details.ResetText();
            IsLifetimeIllness.radioButton2.Checked = true;
        }

        private DataTable GetIllnessData()
        {
            this.table_illnesses.Columns.Add("ApplicantID", typeof(int));
            this.table_illnesses.Columns.Add("IsDiagnosed", typeof(string));
            this.table_illnesses.Columns.Add("IsLifetime", typeof(string));
            this.table_illnesses.Columns.Add("Description", typeof(string));
            this.table_illnesses.Columns.Add("Details", typeof(string));

            return table_illnesses;
        }

        private DataTable GetMedOperationData()
        {
            this.table_operations.Columns.Add("ApplicantID", typeof(int));
            this.table_operations.Columns.Add("IsOperated", typeof(string));
            this.table_operations.Columns.Add("Description", typeof(string));
            this.table_operations.Columns.Add("Details", typeof(string));

            return table_operations;
        }
        
        public void ImplementNotSortable(DataGridView view)
        {
            view.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private bool ValidateOperationFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_operated_desc.Text) ||
                string.IsNullOrWhiteSpace(tbx_operated_details.Text))
                result = false;

            if (string.IsNullOrEmpty(tbx_operated_details.Text) ||
                string.IsNullOrWhiteSpace(tbx_operated_details.Text))
                result = false;

            return result;
        }

        private bool ValidateIllnessFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_illness_description.Text) ||
               string.IsNullOrWhiteSpace(tbx_illness_description.Text))
                result = false;

            if (string.IsNullOrEmpty(tbx_illness_details.Text) ||
                string.IsNullOrWhiteSpace(tbx_illness_details.Text))
                result = false;

            return result;
        }

        #region Events
        private void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {
            EnableControl(false, view_operations, panel_operations);
        }

        private void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            EnableControl(true, view_operations, panel_operations);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(false, view_illness, panel_illness);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(true, view_illness, panel_illness);
        }
        #endregion 

        private void OnLoad(object sender, EventArgs e)
        {
            //
            // illness datagridview
            //
            this.view_illness.DataSource = GetIllnessData();
            this.view_illness.Columns["ApplicantID"].Visible = false;
            this.view_illness.Columns["IsDiagnosed"].Visible = false;
            ImplementNotSortable(view_illness);
            //
            // medical operation datagridview
            //
            this.view_operations.DataSource = GetMedOperationData();
            this.view_operations.Columns["ApplicantID"].Visible = false;
            this.view_operations.Columns["IsOperated"].Visible = false;
            ImplementNotSortable(view_operations);
        }

        private void btn_illness_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateIllnessFields())
                {
                    var rows = new Illness()
                    {
                        ApplicantID = 0,
                        IsDiagnosed = IsDiagnosedByIlness.GetValue(),
                        IsLifetime = IsLifetimeIllness.GetValue(),
                        Description = tbx_illness_description.Text,
                        Details = tbx_illness_details.Text
                    };

                    table_illnesses.Rows.Add(rows.ApplicantID,
                        rows.IsDiagnosed,
                        rows.IsLifetime,
                        rows.Description,
                        rows.Details);

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
                view_illness.ClearSelection();
                ResetIllnessFields();
            }
        }

        private void btn_illness_delete_Click(object sender, EventArgs e)
        {
            try
            {
                table_illnesses.Rows.RemoveAt(view_illness.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_illness.ClearSelection();
                ResetIllnessFields();
            }
        }

        private void btn_operated_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateOperationFields())
                {
                    var row = new MedicalOperation()
                    {
                        ApplicantID = 0,
                        IsOperated = IsMedOperated.GetValue(),
                        Description = tbx_operated_desc.Text,
                        Details = tbx_operated_details.Text
                    };

                    table_operations.Rows.Add(row.ApplicantID,
                        row.IsOperated,
                        row.Description,
                        row.Details);

                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("Please complete the fields!");
                }
            }
            catch { }
            finally
            {
                view_illness.ClearSelection();
                ResetIllnessFields();
            }
        }

        private void btn_operated_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(view_operations.SelectedRows.Count > 0)
                    table_operations.Rows.RemoveAt(view_operations.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_operations.ClearSelection();
                ResetOperationFields();
            }
        }

        private void ResetOperationFields()
        {
            tbx_operated_desc.ResetText();
            tbx_operated_details.ResetText();
        }

        private void view_illness_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(view_illness.Rows.Count > 0)
            {
                btn_illness_delete.Enabled = true;
            }
        }

        private void view_operations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (view_operations.Rows.Count > 0)
            {
                btn_operated_delete.Enabled = true;
            }
        }
    }
}