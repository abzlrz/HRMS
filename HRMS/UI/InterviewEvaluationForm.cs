﻿using System;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class InterviewEvaluationForm : Form
    {
        public string errorMsg;
        public InterviewEvaluationForm()
        {
            InitializeComponent();
        }
        private void AddErrorMessage(string error)
        {
            if (this.errorMsg == string.Empty)
            {
                this.errorMsg = Resources.ErrorMsgHeader + "\n\n";
            }
            this.errorMsg += error + "\n";
        }
        private bool ValidateSelectionInfo()
        {
            errorMsg = string.Empty;
            if(gdv.SelectedRows.Count == 0)
            {
                this.AddErrorMessage("Applicant is required.");
            }

            if(cbxJobTitle.SelectedIndex == -1)
            {
                this.AddErrorMessage("Job Title is Required.");
            }

            if (cbxBucket.SelectedIndex == -1)
            {
                this.AddErrorMessage("Bucket field is Required.");
            }

            if (cbxLanguageReq.SelectedIndex == -1)
            {
                this.AddErrorMessage("Language Requirement field is Required.");
            }

            if (cbxArvatoLevel.SelectedIndex == -1)
            {
                this.AddErrorMessage("Arvato Level is Required.");
            }

            if (cbxJobTitle.SelectedIndex == -1)
            {
                this.AddErrorMessage("Manager's Employee ID is Required.");
            }

            return errorMsg != string.Empty ? false : true;
        }
        private void EnableControl(bool arg)
        {
            gbxEvaluationAnalysis.Enabled = arg;
            gbxView.Enabled = !arg;
            gbxInfo.Enabled = !arg;
        }
        private void OnLoad(object sender, EventArgs e)
        {
        }

        private void OnBtnEvaluateClick(object sender, EventArgs e)
        {
            EnableControl(true);
            /*
            if (this.ValidateSelectionInfo())
            {
                evaluationAnalysis.Enabled = true;
            }
            else
            {
                MessageBox.Show(errorMsg);
            }*/
        }

        private void OnLabel3Click(object sender, EventArgs e)
        {

        }

        private void OnResetClick(object sender, EventArgs e)
        {
            EnableControl(false);
        }
    }
}
