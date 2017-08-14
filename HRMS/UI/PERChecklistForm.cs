using System;
using System.Windows.Forms;

namespace UI
{
    public partial class PERChecklistForm : Form
    {
        public PERChecklistForm()
        {
            InitializeComponent();
        }
        void CheckAllCheckbox(TableLayoutPanel panel, bool arg)
        {
            foreach (var control in panel.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox cbx = (CheckBox)control;
                    cbx.Checked = arg;
                }
            }
        }

        private void OnCheckAll1CheckedChanged(object sender, EventArgs e)
        {
            if(checkAll1.Checked == true)
            {
                CheckAllCheckbox(tableLayoutPanel1, true);
            }
            else
            {
                CheckAllCheckbox(tableLayoutPanel1, false);
            }
        }

        private void OnCheckAll2CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll2.Checked == true)
            {
                CheckAllCheckbox(tableLayoutPanel2, true);
            }
            else
            {
                CheckAllCheckbox(tableLayoutPanel2, false);
            }
        }
    }
}
