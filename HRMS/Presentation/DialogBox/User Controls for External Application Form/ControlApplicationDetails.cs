using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlApplicationDetails : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }

        public ControlApplicationDetails()
        {
            InitializeComponent();
        }

        public bool ValidateFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(cbx_source.Text) || string.IsNullOrWhiteSpace(cbx_source.Text))
                result = false;
            if (string.IsNullOrEmpty(cbx_position.Text) || string.IsNullOrWhiteSpace(cbx_position.Text))
                result = false;
            if (string.IsNullOrEmpty(cbx_preferredSite.Text) || string.IsNullOrWhiteSpace(cbx_preferredSite.Text))
                result = false;

            return result;
        }

        private void cbx_source_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbx_source.SelectedIndex == -1)
                lbl_source.ImageIndex = 0;
        }

        private void cbx_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbx_position.SelectedIndex == -1)
                lbl_position.ImageIndex = 0;
        }

        private void cbx_preferredSite_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbx_preferredSite.SelectedIndex == -1)
                lbl_preferredSite.ImageIndex = 0;
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
