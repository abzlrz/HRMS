﻿using System.Windows.Forms;
using Presentation.DialogBox;
using Data;

namespace Presentation.Modules
{
    public partial class ControlEmployeeRegistration : UserControl
    {
        private FormRegisterEmployee registerEmployee;
        public ControlEmployeeRegistration()
        {
            InitializeComponent();
            this.registerEmployee = new FormRegisterEmployee();
        }

        #region Help Button
        private void OnP1MouseUp(object sender, MouseEventArgs e)
        {
            p1.Image = global::Presentation.Properties.Resources.Help;
        }

        private void OnP1MouseDown(object sender, MouseEventArgs e)
        {
            p1.Image = global::Presentation.Properties.Resources.Help_small;
        }
        #endregion

        private void OnRegisterAsEmployeeToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            registerEmployee.ShowDialog();
        }
    }
}
