using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class EmployeeTrainingFeedback : Form
    {
        public EmployeeTrainingFeedback()
        {
            InitializeComponent();
        }

        private void EmployeeTrainingFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }
    }
}
