using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormJobPosting : Form
    {
        public FormJobPosting()
        {
            InitializeComponent();
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
    }
}
