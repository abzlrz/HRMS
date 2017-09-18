using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormRegisterEmployee : Form
    {
        public FormRegisterEmployee()
        {
            InitializeComponent();
        }

        private void RegisterEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }
    }
}
