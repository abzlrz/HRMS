using Presentation.DialogBox.BackgroundHistory;
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
    public partial class BackgroundHistoryForm : Form
    {
        public BackgroundHistoryForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.mod_educ = new EducationBackground();
            this.mod_work = new WorkHistory();
            this.mod_legal = new LegalHistory();
            this.mod_ill = new IllnessHistory();
        }
        private void ShowControl(UserControl ctrl)
        {
            if (!module.Controls.Contains(ctrl))
                ctrl.Dock = DockStyle.Fill;

            ctrl.BringToFront();
        }

        //show controls added in the panel
        private void listboxCategorySelectedIndexChanged(object sender, EventArgs e)
        {
            //selected index indicator
            int selectedItem = lbx_category.SelectedIndex;
            
            if (selectedItem == 0) // Work History 
            {
                ShowControl(mod_work);
                groupBox1.Text = "Work History";
            }

            if(selectedItem == 1) // Educational Background
            {
                ShowControl(mod_educ);
                groupBox1.Text = "Educational Background";
            }

            if(selectedItem == 2) // History of Illness
            {
                ShowControl(mod_ill);
                groupBox1.Text = "History of Illness";
            }

            if(selectedItem == 3) // Legal History
            {
                ShowControl(mod_legal);
                groupBox1.Text = "Legal History";
            }
            
            //resets scrollbar position
            mod_ill.ResetScrollbar();
            mod_legal.ResetScrollbar();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //add usercontrols to list
            var mods = new List<UserControl>()
            {
                mod_educ, mod_ill,
                mod_work, mod_legal
            };
            
            //add all usercontrol inside the panel
            mods.ForEach(x => { module.Controls.Add(x); x.Dock = DockStyle.Fill; });
            
            //sets listbox index to 0
            lbx_category.SelectedIndex = 0;
        }

        private EducationBackground mod_educ;
        private WorkHistory mod_work;
        private LegalHistory mod_legal;
        private IllnessHistory mod_ill;
    }
}
