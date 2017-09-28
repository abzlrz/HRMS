using Data.Access;
using Data.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Maintenance
{
    public partial class FormUserManagement : Form
    {
        private string procedure;
        private int ID;
        private UserAccess access;

        public FormUserManagement()
        {
            InitializeComponent();
            this.access = new UserAccess();
            view_user.DataSource = access.ShowData();
            view_user.Columns["ID"].Visible = false;
            ReloadData();
        }
        private void ReloadData()
        {
            view_user.DataSource = access.ShowData();
        }

        private void ResetFields()
        {
            tbx_username.ResetText();
            tbx_password.ResetText();
        }
        private void EnableMenuStrip(bool arg)
        {
            if (arg == true)
                view_user.ContextMenuStrip = menu_strip;
            else
                view_user.ContextMenuStrip = null;
        }
        private void PopulateFields(int iD)
        {
            try
            {
                DataRow row = access.GetUserByID(ID);
                tbx_username.Text = row["Username"].ToString();
                tbx_password.Text = row["Password"].ToString();
            }
            catch { }
        }
        private bool ValidateFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_username.Text) || string.IsNullOrWhiteSpace(tbx_username.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_password.Text) || string.IsNullOrWhiteSpace(tbx_password.Text))
                result = false;

            return result;
        }
        private void BackToNormal()
        {
            main.Visible = false;
            view_user.Enabled = true;
            ResetFields();
            ReloadData();
        }

        private void view_user_SelectionChanged(object sender, EventArgs e)
        {
            var gdv = (DataGridView)sender;
            if(gdv.SelectedRows.Count > 0)
                ID = int.Parse(gdv.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedure = "insert";
            main.Visible = true;
            view_user.Enabled = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedure = "update";
            main.Visible = true;
            view_user.Enabled = false;
            PopulateFields(ID);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            BackToNormal();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if(procedure == "insert")
                {
                    var user = new User()
                    {
                        Username = tbx_username.Text,
                        Password = tbx_password.Text
                    };

                    try
                    {
                        var success = access.Insert(user);
                        if (success)
                        {
                            MessageBox.Show("Data Successfully added!");
                            BackToNormal();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                if(procedure == "update")
                {
                    var user = new User()
                    {
                        Username = tbx_username.Text,
                        Password = tbx_password.Text
                    };

                    var success = access.Update(ID, user);
                    if(success)
                    {
                        MessageBox.Show("Data Updated!");
                        BackToNormal();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete the fields!");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ( MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var success = access.Delete(ID);

                    if (success)
                    {
                        MessageBox.Show("Done!");
                        BackToNormal();
                    }
                }
            }
            catch { }
        }

        private void seeLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetFields();
        }
    }
}
