using Data.Access;
using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class FormReApplicationDate : Form
    {
        private ExternalApplicantAccess access;
        private int applicantID;
        private int ID;
        public FormReApplicationDate()
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
        }
        public FormReApplicationDate(int id)
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
            this.ID = 0;
            this.applicantID = id;
        }
        public FormReApplicationDate(int id, int applicantID)
        {
            InitializeComponent();
            this.access = new ExternalApplicantAccess();
            this.ID = id;
            this.applicantID = id;
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            try
            {
                access.SaveReapplication(ID, applicantID, dateTimePicker.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
