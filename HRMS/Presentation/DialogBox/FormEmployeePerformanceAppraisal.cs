using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEmployeePerformanceAppraisal : Form
    {
        private int ID;
        public FormEmployeePerformanceAppraisal(int Id)
        {
            InitializeComponent();
            ID = Id;
        }

        private void EmployeePerformanceAppraisal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }
    }
}

