using Data.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormContactPerson : Form
    {
        #region fields
        private BindingList<ContactPerson> contacts;
        #endregion

        public FormContactPerson()
        {
            InitializeComponent();
            this.contacts = new BindingList<ContactPerson>();
            this.bs_contacts = new BindingSource(contacts, null);

            this.view_contacts.DataSource = bs_contacts;
            this.view_contacts.Columns["ApplicantID"].Visible = false;
            this.view_contacts.Columns["ContactNumber"].HeaderText = "Contact Number";

            this.contacts.ListChanged += Contacts_ListChanged;
        }


        private bool ValidateAddFields()
        {
            bool result = true;

            if (lbl_add_firstname.ImageIndex == 1)
                result = false;
            if (lbl_add_lastname.ImageIndex == 1)
                result = false;
            if (lbl_add_relationship.ImageIndex == 1)
                result = false;
            if (lbl_add_contactno.ImageIndex == 1)
                result = false;

            return result;
        }
        private bool ValidateEditFields()
        {
            bool result = true;

            if (lbl_edit_firstname.ImageIndex == 1)
                result = false;
            if (lbl_edit_lastname.ImageIndex == 1)
                result = false;
            if (lbl_edit_relationship.ImageIndex == 1)
                result = false;
            if (lbl_edit_contactno.ImageIndex == 1)
                result = false;

            return result;
        }
        private void RefreshData()
        {
            this.view_contacts.DataSource = bs_contacts;
        }
        private void ResetAddFields()
        {
            tbx_add_firstname.ResetText();
            tbx_add_lastname.ResetText();
            cbx_add_relationship.SelectedIndex = -1;
            tbx_add_contactno.ResetText();
        }
        private void ResetEditFields()
        {
            tbx_edit_firstname.ResetText();
            tbx_edit_lastname.ResetText();
            cbx_edit_relationship.SelectedIndex = -1;
            tbx_edit_contactno.ResetText();
        }
        private void Populate(ContactPerson obj)
        {
            tbx_edit_firstname.Text = obj.Firstname;
            tbx_edit_lastname.Text = obj.Lastname;
            cbx_edit_relationship.Text = obj.RelationShip;
            tbx_edit_contactno.Text = obj.ContactNumber;
        }
        private void ReCheck()
        {
            if(contacts.Count == 0)
            {
                btn_delete.Enabled = false;
                btn_edit_save.Enabled = false;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_edit_save.Enabled = true;
            }

        }

        #region Events
        private void tbx_add_firstname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_firstname.Text, lbl_add_firstname);
        }

        private void tbx_add_lastname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_lastname.Text, lbl_add_lastname);
        }

        private void cbx_add_relationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_relationship.SelectedIndex, lbl_add_relationship);
        }

        private void tbx_add_contactno_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_contactno.Text, lbl_add_contactno);
        }

        private void tbx_edit_firstname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_firstname.Text, lbl_edit_firstname);
        }

        private void tbx_edit_lastname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_lastname.Text, lbl_edit_lastname);
        }

        private void cbx_edit_relationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_relationship.SelectedIndex, lbl_edit_relationship);
        }

        private void tbx_edit_contactno_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_contactno.Text, lbl_edit_contactno);
        }
        
        private void Contacts_ListChanged(object sender, ListChangedEventArgs e)
        {
            ReCheck();
        }

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        private void btn_add_save_Click(object sender, EventArgs e)
        {
            if (ValidateAddFields())
            {
                var contact = new ContactPerson()
                {
                    Firstname = tbx_add_firstname.Text,
                    Lastname = tbx_add_lastname.Text,
                    RelationShip = cbx_add_relationship.Text,
                    ContactNumber = tbx_add_contactno.Text
                };

                contacts.Add(contact);
                ResetAddFields();
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            if (ValidateEditFields())
            {
                if (contacts.Count > 0)
                {
                    int index = view_contacts.SelectedRows[0].Index;

                    var new_contact = new ContactPerson()
                    {
                        Firstname = tbx_edit_firstname.Text,
                        Lastname = tbx_edit_lastname.Text,
                        RelationShip = cbx_edit_relationship.Text,
                        ContactNumber = tbx_edit_contactno.Text
                    };
                    contacts[index] = new_contact;
                }
                
            }
            else
            {
                MessageBox.Show("Please complete all the required fields!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                view_contacts.Rows.Remove(view_contacts.SelectedRows[0]);
                RefreshData();
                ResetEditFields();
                view_contacts.ClearSelection();
            }
            catch { }
        }

        private void view_contacts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var item = view_contacts.SelectedRows[0].DataBoundItem as ContactPerson;

                if (contacts.Count > 0)
                    Populate(item);
            }
            catch { }
        }
        #endregion
    }
}
