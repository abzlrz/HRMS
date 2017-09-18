using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundEducation : Form
    {
        public FormBackgroundEducation()
        {
            InitializeComponent();
        }

        private bool ValidateFields()
        {
            bool result = true;


            if (string.IsNullOrEmpty(tbx_school.Text))
                result = false;
            else
                result = true;

            if (string.IsNullOrEmpty(tbx_location.Text))
                result = false;
            else
                result = true;

            return result;
        }
        private void ResetFields()
        {
            tbx_school.ResetText();
            tbx_location.ResetText();
            tbx_course.ResetText();
            cbx_degree.SelectedIndex = -1;
            date_from.ResetText();
            date_to.ResetText();
        }
        private void ValidateDates(Label from, Label to, int toDateImgIndex, int fromDateImgIndex)
        {
            if (date_from.Value.ToShortDateString() == date_to.Value.ToShortDateString())
            {
                from.ImageIndex = 1;
                to.ImageIndex = 1;
            }
            else if(date_from.Value.ToShortDateString() != date_to.Value.ToShortDateString())
            {
                from.ImageIndex = 0;
                to.ImageIndex = 0;
            }
            else
            {
                from.ImageIndex = fromDateImgIndex;
                to.ImageIndex = toDateImgIndex;
            }
        }
        
        #region CRUD operations
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {

                ResetFields();
            }
            else
            {
                MessageBox.Show("Please complete the fields!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //specify what index of an item should be removed

            //enable specific buttons

            btn_add.BringToFront();

            //resets all fields
            ResetFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //save data from fields to dataList Output

            //changes current item text on listbox

            //reset all fields
            ResetFields();

            //enable specific button
            btn_add.BringToFront();
        }
        #endregion

        #region If fields are empty conditions
        private void tbx_school_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_school.Text) || string.IsNullOrWhiteSpace(tbx_school.Text))
                lbl_school.ImageIndex = 1;
            else
                lbl_school.ImageIndex = 0;
        }

        private void tbx_location_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_location.Text) || string.IsNullOrWhiteSpace(tbx_location.Text))
                lbl_location.ImageIndex = 1;
            else
                lbl_location.ImageIndex = 0;
        }

        private void cbx_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_degree.SelectedIndex == -1)
                lbl_degree.ImageIndex = 1;
            else
                lbl_degree.ImageIndex = 0;
        }

        private void tbx_course_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_course.Text) || string.IsNullOrWhiteSpace(tbx_course.Text))
                lbl_course.ImageIndex = 1;
            else
                lbl_course.ImageIndex = 0;
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            if (date_from.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                lbl_fromdate.ImageIndex = 1;
            else
                ValidateDates(lbl_fromdate, lbl_todate, 1, 0);
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            if (date_to.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                lbl_todate.ImageIndex = 1;
            else
                ValidateDates(lbl_fromdate, lbl_todate, 0, 1);
        }
        #endregion
    }
}
