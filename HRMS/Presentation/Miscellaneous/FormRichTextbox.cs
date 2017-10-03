using System.Windows.Forms;

namespace Presentation.DialogBox.JobPosting
{
    public partial class FormRichTextbox : Form
    {
        public int MinChars { get; set; }
        public FormRichTextbox()
        {
            InitializeComponent();
            this.TYPE.Text = 0.ToString();
        }
        private void Values_TextChanged(object sender, System.EventArgs e)
        {
            this.TYPE.Text = Values.Text.Length.ToString();
        }
    }
}
