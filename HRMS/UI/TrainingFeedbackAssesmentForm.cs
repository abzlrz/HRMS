using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TrainingFeedbackAssesmentForm : Form
    {
        public TrainingFeedbackAssesmentForm()
        {
            InitializeComponent();
            btnProceed.Click += (a, x) => EnableControls(true);
            btnReset.Click += (a, x) => {

                if(MessageBox.Show("Are you sure?", "Question", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EnableControls(false);
                    this.ClearAllFields();
                }
            };
            btnChangeEmployee.Click += (a, x) => EnableControls(false);
        }
        private void EnableControls(bool arg)
        {
            gbxPerformance.Enabled = arg;
            gbxSummary.Enabled = arg;
            gbxShortlist.Enabled = !arg;
            gbxInfo.Enabled = !arg;
        }

        private void OnProceedClick(object sender, EventArgs e)
        {

        }
    }
}
