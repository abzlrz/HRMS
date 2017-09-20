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
                lbl_source.ImageIndex = 1;
            else
                lbl_source.ImageIndex = 0;
            
            if(cbx_source.SelectedIndex == 1)
            {
                cbx_employeeID.Enabled = true;
                cbx_employeeName.Enabled = true;
                lbl_employeeID.ImageIndex = 1;
                lbl_employeeName.ImageIndex = 1;
            }
            else
            {
                cbx_employeeID.Enabled = false;
                cbx_employeeName.Enabled = false;
                lbl_employeeID.ImageIndex = -1;
                lbl_employeeName.ImageIndex = -1;
            }
        }

        private void tbx_employeeID_TextChanged(object sender, System.EventArgs e)
        {
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

        private void cbx_employeeName_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_employeeName.Text) || string.IsNullOrWhiteSpace(cbx_employeeName.Text))
                lbl_employeeName.ImageIndex = 1;
            else
                lbl_employeeName.ImageIndex = 0;
        }

        private void cbx_employeeID_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_employeeID.Text) || string.IsNullOrWhiteSpace(cbx_employeeID.Text))
                lbl_employeeID.ImageIndex = 1;
            else
                lbl_employeeID.ImageIndex = 0;
        }
    }
}
