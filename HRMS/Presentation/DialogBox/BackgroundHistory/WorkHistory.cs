using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.DialogBox.BackgroundHistory
{
    public partial class WorkHistory : UserControl
    {
        public List<WorkHistory> Output;
        public WorkHistory()
        {
            InitializeComponent();
            this.Output = new List<WorkHistory>();
        }

        private void addClick(object sender, System.EventArgs e)
        {

        }
    }
}
