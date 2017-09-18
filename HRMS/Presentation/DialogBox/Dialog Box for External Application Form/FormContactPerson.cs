using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormContactPerson : Form
    {
        public FormContactPerson()
        {
            InitializeComponent();
        }

        #region If fields are empty conditions
        private void tbx_firstname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_firstname.Text) || string.IsNullOrWhiteSpace(tbx_firstname.Text))
                lbl_firstname.ImageIndex = 1;
            else
                lbl_firstname.ImageIndex = 0;
        }

        private void tbx_lastname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_lastname.Text) || string.IsNullOrWhiteSpace(tbx_lastname.Text))
                lbl_lastname.ImageIndex = 1;
            else
                lbl_lastname.ImageIndex = 0;
        }

        private void tbx_contactNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_contactNo.Text) || string.IsNullOrWhiteSpace(tbx_contactNo.Text))
                lbl_contactNo.ImageIndex = 1;
            else
                lbl_contactNo.ImageIndex = 0;
        }

        private void cbx_relationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_relationship.SelectedIndex == -1)
                lbl_relationship.ImageIndex = 1;
            else
                lbl_relationship.ImageIndex = 0;
        }
        #endregion
    }
}
