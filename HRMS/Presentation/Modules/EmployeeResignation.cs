using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.DialogBox;

namespace Presentation.Modules
{
    public partial class EmployeeResignation : UserControl
    {
        public EmployeeResignation()
        {
            InitializeComponent();
            this.exit = new FormEmployeeExit();
        }

        private void applyResignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exit.ShowDialog();
        }

        private FormEmployeeExit exit;
    }
}
