using Data.Access;
using Data.Entities;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlApplicationDetails : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        #endregion

        #region fields
        private ApplicationSource source;
        private DataAccess context;
        #endregion

        public ControlApplicationDetails()
        {
            InitializeComponent();
            this.source = new ApplicationSource();
            this.context = new DataAccess();
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
        public void ClearAllFields()
        {
            cbx_source.SelectedIndex = -1;
            cbx_employeeID.SelectedIndex = -1;
            cbx_employeeName.SelectedIndex = -1;

            date_applicationDate.ResetText();
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
            ClearAllFields();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                //
                // application source
                //
                source.Source = cbx_source.Text;
                source.ReferralID = int.Parse(cbx_source.Text);
                source.ReferralName = cbx_employeeName.Text;

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        #endregion

        private void OnLoad(object sender, System.EventArgs e)
        {
            //
            // cbx_applicationsource
            //
            this.cbx_source.DisplayMember = "Source";
            this.cbx_source.ValueMember = "Source";
            this.cbx_source.DataSource = context.ShowApplicationSourceData();
        }
    }
}
