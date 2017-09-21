using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Maintenance
{
    public partial class FormUserManager : Form
    {
        //IUser data = new User();
        public FormUserManager()
        {
            InitializeComponent();
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            view_education.DataSource = ShowData();
        }

        private DataTable ShowData()
        {
            // return data.Show();
        }
    }
}
