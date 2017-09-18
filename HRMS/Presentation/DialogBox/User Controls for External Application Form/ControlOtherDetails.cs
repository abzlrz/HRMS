using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlOtherDetails : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        public ControlOtherDetails()
        {
            InitializeComponent();
        }

        private void link_education_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_illness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_legal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_employment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_contacts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }
    }
}
