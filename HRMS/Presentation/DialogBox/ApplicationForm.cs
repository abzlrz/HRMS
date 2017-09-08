using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
            this.background = new BackgroundHistoryForm();
            this.contacts = new ContactPersonForm();
        }

        private void ApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }

        private void backgroundHistoryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            background.ShowDialog();
        }

        private void contactPersonLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contacts.ShowDialog();
        }

        private BackgroundHistoryForm background;
        private ContactPersonForm contacts;
    }
}
