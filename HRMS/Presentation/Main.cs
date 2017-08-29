using Presentation.Modules;
using Presentation.View;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeGridView();
        }

        private void InitializeGridView()
        {
            this.recruitmentView = new VRecruitment();
            this.trainingView = new VTraining();
            this.relivingView = new VReliving();
            this.employeeView = new VEmployee();
        }
        private void ShowControl(UserControl ctrl1, UserControl ctrl2)
        {
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();

            ctrl1.Dock = DockStyle.Fill;
            ctrl2.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(ctrl1);
            splitContainer1.Panel2.Controls.Add(ctrl2);
        }
        private void OnTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNode = treeView.SelectedNode.Text;

            #region recruitment
            if (selectedNode == "Recruitment")
                ShowControl(recruitmentView.dasboard, recruitmentView);

            if (selectedNode == "Employee Registration")
                ShowControl(recruitmentView.employeeRegistration, recruitmentView);

            if (selectedNode == "Interview Evaluation")
                ShowControl(recruitmentView.interviewEvaluation, recruitmentView);

            if (selectedNode == "Employee Registration (Existing)")
                ShowControl(recruitmentView.employeeRegistrationExisting, recruitmentView);

            if (selectedNode == "Employee PER Checklist")
                ShowControl(employeeView.checklist, employeeView);
            
            if (selectedNode == "Employee Performance Appraisal")
                ShowControl(employeeView.performanceAppraisal, employeeView);

            #endregion

            #region training
            if (selectedNode == "Training")
                ShowControl(trainingView.dashboard, trainingView);

            if (selectedNode == "Training Schedule")
                ShowControl(trainingView.trainingSchedule, trainingView);

            if (selectedNode == "Training Feedback & Assesment")
                ShowControl(trainingView.trainingFeedback, trainingView);
            #endregion

            #region reliving
            if (selectedNode == "Reliving")
                ShowControl(relivingView.dashboard, relivingView);

            if (selectedNode == "Employee Resignation")
                ShowControl(relivingView.resignation, relivingView);
            
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

        private VEmployee employeeView;
        private VRecruitment recruitmentView;
        private VTraining trainingView;
        private VReliving relivingView;
    }
    
}
