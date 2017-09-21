using Data.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormContactPerson : Form
    {
        #region fields
        private BindingList<ContactPerson> _contacts;
        #endregion

        public FormContactPerson()
        {
            InitializeComponent();
            this._contacts = new BindingList<ContactPerson>();
        }

        #region methods
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_firstname.ImageIndex == 1)
                result = false;
            if (lbl_lastname.ImageIndex == 1)
                result = false;
            if (lbl_relationship.ImageIndex == 1)
                result = false;
            if (lbl_contactNo.ImageIndex == 1)
                result = false;

            return result;
        }
        private bool HaveValues()
        {
            bool result = true;

            if (_contacts.Count < 2)
                result = false;

            return result;
        }
        #endregion

        #region If fields are empty conditions
        private void tbx_firstname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_firstname.Text, lbl_firstname);
        }

        private void tbx_lastname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_lastname.Text, lbl_lastname);
        }

        private void tbx_contactNo_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_contactNo.Text, lbl_contactNo);
        }

        private void cbx_relationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_relationship.SelectedIndex, lbl_relationship);
        }
        #endregion

        private void view_contact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
