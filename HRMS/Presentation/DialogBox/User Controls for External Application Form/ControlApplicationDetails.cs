using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlApplicationDetails : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        #endregion

        public ControlApplicationDetails()
        {
            InitializeComponent();
        }

        #region methods
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_source.ImageIndex == 1)
                result = false;
            if(lbl_source.ImageIndex == 0)
            {
                if (lbl_employeeID.ImageIndex == 1)
                    result = false;
                if (lbl_employeeName.ImageIndex == 1)
                    result = false;
            }
            if (lbl_position.ImageIndex == 1)
                result = false;
            if (lbl_preferredSite.ImageIndex == 1)
                result = false;

            return result;
        }
        #endregion

        #region if fields are empty conditions
        private void cbx_source_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_source.SelectedIndex, lbl_source);
            
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

        private void cbx_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_position.SelectedIndex, lbl_position);
        }

        private void cbx_preferredSite_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_preferredSite.SelectedIndex, lbl_preferredSite);
        }

        private void cbx_employeeName_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_employeeName.SelectedIndex, lbl_employeeName);
        }

        private void cbx_employeeID_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_employeeID.SelectedIndex, lbl_employeeID);
        }
        #endregion

        #region buttons
        private void btn_clearAll_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            Next.BringToFront();
            /*
            if (ValidateFields())
            {
                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        #endregion
    }
}
