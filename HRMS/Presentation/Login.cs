using Presentation.DialogBox;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Login : Form
    {
        private Color ArvatoBlue = Color.FromArgb(0, 104, 169);
        private Color ArvatoGreen = Color.FromArgb(176, 200, 0);
        private Color ArvatoRed = Color.FromArgb(233, 15, 64);
        
        private ApplicationForm applicationForm;
        public Login()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, ArvatoBlue);
            this.applicationForm = new ApplicationForm();
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

        private void OnApplyClick(object sender, System.EventArgs e)
        {
            applicationForm.ShowDialog();
        }
    }
}
