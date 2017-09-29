using Data.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormContactPerson : Form
    {
        #region fields
        public DataTable table_contacts;
        #endregion

        public FormContactPerson()
        {
            InitializeComponent();
            this.table_contacts = new DataTable();
        }

        private DataTable GetContacts()
        {
            this.table_contacts.Columns.Add("ApplicantID", typeof(int));
            this.table_contacts.Columns.Add("Firstname", typeof(string));
            this.table_contacts.Columns.Add("Lastname", typeof(string));
            this.table_contacts.Columns.Add("Relationship", typeof(string));
            this.table_contacts.Columns.Add("ContactNumber", typeof(string));

            return table_contacts;
        }

        public void ImplementNotSortable(DataGridView view)
        {
            view.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
        public bool CheckValue()
        {
            return table_contacts.Rows.Count > 0;
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

        private void OnLoad(object sender, EventArgs e)
        {
            //
            // contacts datagridview
            //
            if (view_contacts.Rows.Count is 0)
            {
                this.view_contacts.DataSource = GetContacts();
                this.view_contacts.Columns["ApplicantID"].Visible = false;
                ImplementNotSortable(view_contacts);
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

        private void btn_add_reset_Click(object sender, EventArgs e)
        {
            ResetAddFields();
        }

        #endregion

        private void btn_add_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAddFields())
                {
                    var row = new ContactPerson()
                    {
                        ApplicantID = 0,
                        Firstname = tbx_add_firstname.Text,
                        Lastname = tbx_add_lastname.Text,
                        RelationShip = cbx_add_relationship.Text,
                        ContactNumber = tbx_add_contactno.Text
                    };

                    table_contacts.Rows.Add(row.ApplicantID,
                        row.Firstname,
                        row.Lastname,
                        row.RelationShip,
                        row.ContactNumber);

                    MessageBox.Show("Data Successfully Added!");
                }
                else
                {
                    MessageBox.Show("Please complete the fields!");
                }
            }
            catch { }
            finally
            {
                view_contacts.ClearSelection();
                ResetAddFields();
            }
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEditFields())
                {
                    var row = new ContactPerson()
                    {
                        ApplicantID = 0,
                        Firstname = tbx_edit_firstname.Text,
                        Lastname = tbx_edit_lastname.Text,
                        ContactNumber = tbx_edit_contactno.Text,
                        RelationShip = cbx_edit_relationship.Text
                    };

                    table_contacts.Rows.RemoveAt(view_contacts.SelectedRows[0].Index);
                    table_contacts.Rows.Add(row.ApplicantID,
                        row.Firstname,
                        row.Lastname,
                        row.RelationShip,
                        row.ContactNumber);

                    btn_edit_save.Enabled = false;
                    btn_delete.Enabled = false;
                }
            }
            catch { }
            finally
            {
                view_contacts.ClearSelection();
                ResetEditFields();
            }
        }

        private void view_contacts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (view_contacts.SelectedRows.Count > 0)
                {
                    var item = table_contacts.Rows[view_contacts.SelectedRows[0].Index];

                    tbx_edit_firstname.Text = item["Firstname"].ToString();
                    tbx_edit_lastname.Text = item["Lastname"].ToString();
                    cbx_edit_relationship.Text = item["Relationship"].ToString();
                    tbx_edit_contactno.Text = item["ContactNumber"].ToString();


                    btn_edit_save.Enabled = true;
                    btn_delete.Enabled = true;
                }
                else
                {
                    btn_edit_save.Enabled = false;
                    btn_delete.Enabled = false;
                }
            }
            catch { }
        }

        private void view_contacts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(view_contacts.Rows.Count > 0)
            {
                btn_edit_save.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                table_contacts.Rows.RemoveAt(view_contacts.SelectedRows[0].Index);
            }
            catch { }
            finally
            {
                view_contacts.ClearSelection();
                ResetEditFields();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (view_contacts.Rows.Count is 0)
                table_contacts.Columns.Clear();
            this.Hide();
        }
    }
}
