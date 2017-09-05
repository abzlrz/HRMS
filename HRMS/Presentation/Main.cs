using Presentation.Modules;
using Presentation.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.view_recruitment = new VRecruitment();
            this.view_training = new VTraining();
            this.view_reliving = new VReliving();
            this.view_employee = new VEmployee();

            this.dash_recruitment = new RecruitmentDashboard();
            this.dash_reliving = new RelivingDashboard();
            this.dash_training = new TrainingDashboard();

            this.mod_employeeRegistration = new EmployeeRegistration();
            this.mod_employeeRegistrationEx = new ExistingEmployeeRegistration();
            this.mod_evaluation = new InterviewEvaluation();
            this.mod_resignation = new EmployeeResignation();
            this.mod_appraisal = new PerformanceAppraisal();
            this.mod_checklist = new PERChecklist();
            this.mod_trainingFeedback = new TrainingFeedback();
            this.mod_trainingSchedule = new TrainingSchedule();
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
            var login = new Login();
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

        private VEmployee view_employee;
        private VRecruitment view_recruitment;
        private VTraining view_training;
        private VReliving view_reliving;

        private RecruitmentDashboard dash_recruitment;
        private TrainingDashboard dash_training;
        private RelivingDashboard dash_reliving;

        private EmployeeRegistration mod_employeeRegistration;
        private ExistingEmployeeRegistration mod_employeeRegistrationEx;
        private InterviewEvaluation mod_evaluation;
        private PERChecklist mod_checklist;
        private PerformanceAppraisal mod_appraisal;
        private EmployeeResignation mod_resignation;
        private TrainingFeedback mod_trainingFeedback;
        private TrainingSchedule mod_trainingSchedule;
    }
    
}
