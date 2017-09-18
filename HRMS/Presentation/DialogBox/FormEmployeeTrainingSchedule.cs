using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEmployeeTrainingSchedule : Form
    {
        public FormEmployeeTrainingSchedule()
        {
            InitializeComponent();
        }

        private void EmployeeTrainingSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Data you entered will be disregarded. Are you sure?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }
    }
}
