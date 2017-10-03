using Presentation.DialogBox.ExternalApplication;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormExternalApplicant : Form
    {
        private ControlPersonalInformation ctrl_info;
        private ControlApplicationDetails ctrl_appDetails;
        private ControlAddress ctrl_address;
        private ControlBackgroundCheck ctrl_others;
        private int ID;
        public FormExternalApplicant(int Id)
        {
            InitializeComponent();

            this.ctrl_info = new ControlPersonalInformation();
            this.ctrl_address = new ControlAddress();
            this.ctrl_appDetails = new ControlApplicationDetails();
            this.ctrl_others = new ControlBackgroundCheck();

            ID = Id;
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            
        }
    }
}
