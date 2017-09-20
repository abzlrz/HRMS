using Presentation.Maintenance;
using Presentation.Modules;
using Presentation.View;
using System.Collections.Generic;
using System.Windows.Forms;

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
            this.mod_employeeRegistrationEx = new ControlExistingEmployeeRegistration();
            this.mod_evaluation = new ControlInterviewEvaluation();
            this.mod_resignation = new ControlEmployeeResignation();
            this.mod_appraisal = new ControlPerformanceAppraisal();
            this.mod_checklist = new ControlPERChecklist();
            this.mod_trainingFeedback = new ControlTrainingFeedback();
            this.mod_trainingSchedule = new ControlTrainingSchedule();

            this.usermgr = new FormUserManager();
            this.clrLogin = new FormClearanceLogin();
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
                

            if (selectedNode == "Employee Registration (Existing)")
            {
                ShowControlOnPanel2(modPanel, mod_employeeRegistrationEx);
                ShowControlOnPanel2(viewsPanel, view_recruitment);
            }
                

            if (selectedNode == "Employee PER Checklist")
            {
                ShowControlOnPanel2(modPanel, mod_checklist);
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
            this.Close();
        }
        private void OnLoad(object sender, System.EventArgs e)
        {
            var mods = new List<UserControl>()
            {
                mod_employeeRegistration, mod_employeeRegistrationEx, mod_evaluation, mod_appraisal,
                mod_checklist, mod_resignation, mod_trainingFeedback, mod_trainingSchedule
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
        private void manageUsersClick(object sender, System.EventArgs e)
        {
            
        }

        private ControlEmployee view_employee;
        private ControlRecruitment view_recruitment;
        private ControlTraining view_training;
        private ControlReliving view_reliving;

        private ControlRecruitmentDashboard dash_recruitment;
        private ControlTrainingDashboard dash_training;
        private ControlRelivingDashboard dash_reliving;

        private ControlEmployeeRegistration mod_employeeRegistration;
        private ControlExistingEmployeeRegistration mod_employeeRegistrationEx;
        private ControlInterviewEvaluation mod_evaluation;
        private ControlPERChecklist mod_checklist;
        private ControlPerformanceAppraisal mod_appraisal;
        private ControlEmployeeResignation mod_resignation;
        private ControlTrainingFeedback mod_trainingFeedback;
        private ControlTrainingSchedule mod_trainingSchedule;

        private FormUserManager usermgr;
        private FormClearanceLogin clrLogin;

        private void flow_procedures_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void flow_procedures_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
    
}
