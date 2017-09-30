using Data.Access;
using Data.Entities;
using System.IO;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormJobPosting : Form
    {
        private JobPostingAccess access;
        private DataAccess access1;
        public FormJobPosting()
        {
            InitializeComponent();
            this.access = new JobPostingAccess();
            this.access1 = new DataAccess();
        }
        private void ResetAddFields()
        {
            tbx_add_comment.ResetText();
            tbx_add_headcount.ResetText();
            tbx_add_positiontype.ResetText();
            tbx_add_wage.ResetText();
            date_add_close.ResetText();
            date_add_posted.ResetText();
            cbx_add_location.SelectedIndex = -1;
            cbx_add_position.SelectedIndex = -1;
        }
        private void ResetFields()
        {
            tbx_add_comment.ResetText();
            tbx_add_headcount.ResetText();
            tbx_add_positiontype.ResetText();
            tbx_add_wage.ResetText();
            tbx_edit_comment.ResetText();
            tbx_edit_headcount.ResetText();
            tbx_edit_position.ResetText();
            tbx_edit_positiontype.ResetText();
            tbx_edit_wage.ResetText();
            tbx_search.ResetText();
            date_add_close.ResetText();
            date_add_posted.ResetText();
            date_edit_close.ResetText();
            date_edit_posted.ResetText();
            cbxSearchBy.SelectedIndex = -1;
            cbx_add_location.SelectedIndex = -1;
            cbx_add_position.SelectedIndex = -1;
            cbx_edit_location.SelectedIndex = -1;
        }
        private void RefreshData()
        {
            this.view_posting.DataSource = access.ShowData();
        }
        private bool ValidateAddFields()
        {
            bool result = true;

            if (lbl_add_positiontype.ImageIndex == 1)
                result = false;
            if (lbl_add_position.ImageIndex == 1)
                result = false;
            if (lbl_add_headcount.ImageIndex == 1)
                result = false;
            if (lbl_add_location.ImageIndex == 1)
                result = false;
            if (lbl_add_qualification.ImageIndex == 1)
                result = false;
            if (lbl_add_jobdesc.ImageIndex == 1)
                result = false;

            return result;
        }

        #region Events 
        private void btn_reset_Click(object sender, System.EventArgs e)
        {
            ResetAddFields();
        }

        private void FormJobPosting_Load(object sender, System.EventArgs e)
        {
            //
            // jobposting datagridview
            //
            this.view_posting.DataSource = access.ShowData();
            //
            // position combobox
            //
            this.cbx_add_position.DataSource = access1.ShowJobTitleData();
            this.cbx_add_position.DisplayMember = "Title";
            this.cbx_add_position.ValueMember = "Title";
            this.cbx_add_position.SelectedIndex = -1;
        }

        private void tbx_add_positiontype_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_positiontype.Text, lbl_add_positiontype);
        }

        private void cbx_add_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_position.SelectedIndex, lbl_add_position);
        }

        private void tbx_add_headcount_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_add_headcount.Text, lbl_add_headcount);
        }

        private void cbx_add_location_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_add_location.SelectedIndex, lbl_add_location);
        }

        private void link_add_qualification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(dialog_qualification.ShowDialog() == DialogResult.OK)
            {
                link_add_qualification.Text = string.Format(Path.GetFullPath(dialog_qualification.FileName));
                lbl_add_qualification.ImageIndex = -1;
            }
        }

        private void link_add_jobdesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(dialog_jobdesc.ShowDialog() == DialogResult.OK)
            {
                link_add_jobdesc.Text = string.Format(Path.GetFullPath(dialog_jobdesc.FileName));
                lbl_add_jobdesc.ImageIndex = 0;
            }
        }

        private void link_edit_jobdesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_edit_qualification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cbx_edit_location_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_edit_location.SelectedIndex, lbl_edit_location);
        }

        private void tbx_edit_headcount_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_headcount.Text, lbl_edit_headcount);
        }

        private void tbx_edit_position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_position.Text, lbl_edit_position);
        }

        private void tbx_edit_positiontype_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_edit_positiontype.Text, lbl_edit_positiontype);
        }
        #endregion

        private void btn_add_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ValidateAddFields())
                {
                    var item = new JobPosting()
                    {
                        PositionType = tbx_add_positiontype.Text,
                        Position = cbx_add_position.Text,
                        PostedDate = date_add_posted.Value,
                        CloseDate = date_add_close.Value,
                        Wage = decimal.Parse(tbx_add_wage.Text),
                        HeadCount = int.Parse(tbx_add_headcount.Text),
                        Qualification = link_add_qualification.Text,
                        JobDescription = link_add_jobdesc.Text,
                        Location = cbx_add_location.Text,
                        Comments = tbx_add_comment.Text
                    };

                    if (access.InsertData(item))
                    {
                        MessageBox.Show("Data Successfully Added!");
                        RefreshData();
                        ResetAddFields();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all the fields!");
                }
            }
            catch { }
        }
    }
}
