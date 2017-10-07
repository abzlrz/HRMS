using Data.Access;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormAudit : Form
    {
        private DataAccess access;
        public FormAudit()
        {
            InitializeComponent();
            this.access = new DataAccess();
        }

        private void FormAudit_Load(object sender, System.EventArgs e)
        {
            view_audit.DataSource = access.ShowLog();
        }
    }
}
