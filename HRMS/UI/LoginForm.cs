using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    public partial class LoginForm : Form
    {
        private Color ArvatoBlue = Color.FromArgb(0, 104, 169);
        private Color ArvatoGreen = Color.FromArgb(176, 200, 0);
        private Color ArvatoRed = Color.FromArgb(233, 15, 64);
        private ApplicationForm applicationform = new ApplicationForm();
        private MainForm mainform = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, ArvatoBlue);
            
        }

        private void OnApplyClick(object sender, System.EventArgs e)
        {
            applicationform.ShowDialog();
        }

        private void OnLoginClick(object sender, System.EventArgs e)
        {
            mainform.Show();
        }
    }
}
