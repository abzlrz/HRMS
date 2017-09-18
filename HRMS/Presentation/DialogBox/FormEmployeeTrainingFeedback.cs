using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEmployeeTrainingFeedback : Form
    {
        public FormEmployeeTrainingFeedback()
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
