using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundIllness : Form
    {
        #region fields
        private BindingList<Illness> _illnesses;
        private BindingList<MedicalOperation> _medOperations;
        private Illness _illness;
        private MedicalOperation _medOperation;
        private string _IsDiagnosed => confirmationIllness.GetRadioButtonValue();
        private string _IsOperated => confirmationOperation.GetRadioButtonValue();
        private string procedure;
        #endregion

        public FormBackgroundIllness()
        {
            InitializeComponent();
            this._illnesses = new BindingList<Illness>();
            this._medOperations = new BindingList<MedicalOperation>();
        }

        #region get values
        
        #endregion

        #region methods
        private void EnableControls(bool arg, Panel panel)
        {
            panel.Enabled = arg;
        }

        private bool ValidateFields()
        {
            bool result = true;

            if(this._IsDiagnosed == "Yes")
            {
                if (lbl_illness.ImageIndex == 1)
                    result = false;
            }
            if(this._IsOperated == "Yes")
            {
                if (lbl_operation.ImageIndex == 1)
                    result = false;
            }

            return result;
        }
        #endregion

        #region If fields are empty conditions
        private void yesIllness_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, illnessPanel);
            lbl_illness.ImageIndex = 1;
            lbl_lifetime.ImageIndex = 1;
        }

        private void noIllness_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, illnessPanel);
            lbl_illness.ImageIndex = -1;
            lbl_lifetime.ImageIndex = -1;
        }

        private void yesOperation_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(true, operationPanel);
            lbl_operation.ImageIndex = 1;
        }

        private void noOperation_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls(false, operationPanel);
            lbl_operation.ImageIndex = -1;
        }

        private void tbx_School_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_illness.Text) || string.IsNullOrWhiteSpace(tbx_illness.Text))
                lbl_illness.ImageIndex = 1;
            else
                lbl_illness.ImageIndex = 0;
        }

        private void tbx_operation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_operation.Text) || string.IsNullOrWhiteSpace(tbx_operation.Text))
                lbl_operation.ImageIndex = 1;
            else
                lbl_operation.ImageIndex = 0;
        }
        #endregion

        #region buttons
        private void btn_add1_Click(object sender, EventArgs e)
        {
            procedure = "insert";
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            if (CheckFieldsIllness())
            {
                _illnesses.Add(new Illness()
                {
                    ApplicantID = int.Parse(lbl_appID.Text),
                    IsDiagnosed = _IsDiagnosed.Equals("Yes", StringComparison.CurrentCultureIgnoreCase),
                    Description = tbx_illness.Text,
                    Details = tbx_details.Text,
                    IsLifetime = panel_yesNo.GetRadioButtonValue().Equals("Yes", StringComparison.CurrentCultureIgnoreCase)
                });
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool CheckFieldsIllness()
        {
            bool result = true;
            if (this._IsDiagnosed == "Yes")
            {
                if (lbl_illness.ImageIndex == 1)
                    result = false;
            }
            return result;
        }

        private void btn_delete1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
