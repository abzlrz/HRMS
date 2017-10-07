using Presentation.DialogBox;
using Presentation.Maintenance;
using Presentation.Miscellaneous;
using Presentation.Modules;
using Presentation.View;
using System.Collections.Generic;
using System.Windows.Forms;
using static Presentation.Properties.Settings;

namespace Presentation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.view_recruitment = new ControlRecruitment();
            this.view_training = new ControlTraining();
            this.view_reliving = new ControlReliving();
            this.view_employee = new ControlEmployee();

            this.dash_recruitment = new ControlRecruitmentDashboard();
            this.dash_reliving = new ControlRelivingDashboard();
            this.dash_training = new ControlTrainingDashboard();

            this.mod_employeeRegistration = new ControlEmployeeRegistration();
            this.mod_evaluation = new ControlInterviewEvaluation();
            this.mod_resignation = new ControlEmployeeResignation();
            this.mod_appraisal = new ControlPerformanceAppraisal();
            this.mod_trainingFeedback = new ControlTrainingFeedback();
            this.mod_trainingSchedule = new ControlTrainingSchedule();

            this.usermgr = new FormUserManagement();
            this.refmngr = new FormRefManager();
            this.jobposting = new FormJobPosting();
            this.audit = new FormAudit();

            this.about = new AboutBox();
        }
        private void ShowControlOnPanel1(UserControl ctrl)
        {
            if (!panel1.Controls.Contains(ctrl))
                ctrl.Dock = DockStyle.Fill;

            ctrl.BringToFront();
            panel1.BringToFront();
        }
        private void ShowControlOnPanel2(Panel panel, UserControl ctrl)
        {
            if (!panel.Controls.Contains(ctrl))
                ctrl.Dock = DockStyle.Fill;

            ctrl.BringToFront();
            panel2.BringToFront();
        }

        private void OnTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNode = treeView.SelectedNode.Text;

            #region recruitment
            if (selectedNode == "Recruitment")
                ShowControlOnPanel1(dash_recruitment);

            if (selectedNode == "Employee Registration")
            {
                ShowControlOnPanel2(modPanel, mod_employeeRegistration);
                ShowControlOnPanel2(viewsPanel, view_recruitment);
            }

            if (selectedNode == "Interview Evaluation")
            {
                ShowControlOnPanel2(modPanel, mod_evaluation);
                ShowControlOnPanel2(viewsPanel, view_recruitment);
            } 

            if (selectedNode == "Employee Performance Appraisal")
            {
                ShowControlOnPanel2(modPanel, mod_appraisal);
                ShowControlOnPanel2(viewsPanel, view_recruitment);
            }
                

            #endregion

            #region training
            if (selectedNode == "Training")
            {
                ShowControlOnPanel1(dash_training);
            }


            if (selectedNode == "Training Schedule")
            {
                ShowControlOnPanel2(modPanel, mod_trainingSchedule);
                ShowControlOnPanel2(viewsPanel, view_training);
            }

            if (selectedNode == "Training Feedback & Assesment")
            {
                ShowControlOnPanel2(modPanel, mod_trainingFeedback);
                ShowControlOnPanel2(viewsPanel, view_training);
            }
            #endregion

            #region reliving
            if (selectedNode == "Reliving")
            {
                ShowControlOnPanel1(dash_reliving);
            }
              
            if (selectedNode == "Employee Resignation")
            {
                ShowControlOnPanel2(modPanel, mod_resignation);
                ShowControlOnPanel2(viewsPanel, view_reliving);
            }
            
            #endregion

            #region reporting

            #endregion
        }

        private void OnSignoutToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            var login = new FormLogin();
            login.Show();
            this.Hide();
        }
        private void auditLogsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            audit.ShowDialog();
        }
        private void OnLoad(object sender, System.EventArgs e)
        {
            var mods = new List<UserControl>()
            {
                mod_employeeRegistration, mod_evaluation, mod_appraisal,
                mod_resignation, mod_trainingFeedback, mod_trainingSchedule
            };

            var views = new List<UserControl>()
            {
                view_employee, view_recruitment, view_training, view_reliving
            };

            var dash = new List<UserControl>()
            {
                dash_recruitment, dash_reliving, dash_training
            };

            mods.ForEach(x => { modPanel.Controls.Add(x); x.Dock = DockStyle.Fill; } );
            views.ForEach(x => { viewsPanel.Controls.Add(x); x.Dock = DockStyle.Fill; });
            dash.ForEach(x => { panel1.Controls.Add(x); x.Dock = DockStyle.Fill; });

            if (Default.UserAccessType.Equals("Admin"))
            {
                toolsToolStripMenuItem.Visible = true;
                dash_recruitment.modifyToolStripMenuItem.Visible = true;
                dash_recruitment.editEmployeeToolStripMenuItem.Visible = true;
                dash_recruitment.deleteToolStripMenuItem1.Visible = true;
                
            } 
            else
            {
                toolsToolStripMenuItem.Visible = false;
                dash_recruitment.modifyToolStripMenuItem.Visible = false;
                dash_recruitment.editEmployeeToolStripMenuItem.Visible = false;
                dash_recruitment.deleteToolStripMenuItem1.Visible = false;
            }

            this.controlCurrentUserOnUse1.Firstname.Text = Default.UserFirstname;
            this.controlCurrentUserOnUse1.Lastname.Text = Default.UserLastname;
            this.controlCurrentUserOnUse1.EmployeeID.Text = Default.EmployeeID;
        }

        private void closeClick(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Arvato HRMS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeClick(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            about.ShowDialog();
        }

        private void manageReferencesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            refmngr.ShowDialog();
        }

        private void customizeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            usermgr.ShowDialog();
        }

        private void jobPostingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.jobposting.ShowDialog();
        }

        private ControlEmployee view_employee;
        private ControlRecruitment view_recruitment;
        private ControlTraining view_training;
        private ControlReliving view_reliving;

        private ControlRecruitmentDashboard dash_recruitment;
        private ControlTrainingDashboard dash_training;
        private ControlRelivingDashboard dash_reliving;

        private ControlEmployeeRegistration mod_employeeRegistration;
        private ControlInterviewEvaluation mod_evaluation;
        private ControlPerformanceAppraisal mod_appraisal;
        private ControlEmployeeResignation mod_resignation;
        private ControlTrainingFeedback mod_trainingFeedback;
        private ControlTrainingSchedule mod_trainingSchedule;

        private FormUserManagement usermgr;
        private FormRefManager refmngr;
        private FormJobPosting jobposting;
        private FormAudit audit;

        private AboutBox about;
    }
    
}
