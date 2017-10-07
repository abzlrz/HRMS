using Data.Access;
using System.Data;
using System.Windows.Forms;
using System;

namespace Presentation.Maintenance
{
    public partial class FormUserManagement : Form
    {
        private UserAccess access;
        private int ID;

        public FormUserManagement()
        {
            InitializeComponent();
            this.access = new UserAccess();
        }

        private void PopulateUser(int ID)
        {
            DataRow row = access.GetUserByID(ID);

            lbl_employee_id.Text = row["ID"].ToString();
            lbl_name.Text = row["Name"].ToString();
            lbl_position.Text = row["Position"].ToString();
            lbl_titantitle.Text = row["TitanTitle"].ToString();
            //
            // populate user password by datagridview
            //
            tbx_password.Text = view_user.SelectedRows[0].Cells["Password"].Value.ToString();
        }

        private void cx_viewpassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cx_viewpassword.Checked)
                tbx_password.UseSystemPasswordChar = false;
            else
                tbx_password.UseSystemPasswordChar = true;
        }

        private void tbx_password_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_password.Text, lbl_indicator, 6);
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            this.access.ReloadHRUsers();
            this.view_user.DataSource = access.ShowHRUsers();
        }

        private void view_user_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (view_user.SelectedRows.Count > 0)
                {
                    ID = int.Parse(view_user.SelectedRows[0].Cells[0].Value.ToString());
                    PopulateUser(ID);
                }
            }
            catch { }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(!(string.IsNullOrEmpty(tbx_password.Text) || string.IsNullOrWhiteSpace(tbx_password.Text)))
                {
                    if (access.UpdateUserPassword(tbx_password.Text, int.Parse(lbl_employee_id.Text)))
                    {
                        MessageBox.Show("Data Successfully Updated!");
                        this.access.ReloadHRUsers();
                        RefreshData();
                        tbx_password.ResetText();
                    }
                }
            }
            catch { }
        }

        private void RefreshData()
        {
            this.view_user.DataSource = access.ShowHRUsers();
        }

        private void btn_unblock_Click(object sender, EventArgs e)
        {
            if (view_user.SelectedRows[0].Cells["State"].Value.ToString().Equals("Blocked"))
            {
                if (access.UnblockUser(ID))
                {
                    MessageBox.Show("Data Successfully Updated!");
                    this.access.ReloadHRUsers();
                    RefreshData();
                    tbx_password.ResetText();
                }
            }
        }
    }
}
