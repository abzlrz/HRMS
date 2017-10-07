using Data.Entities;
using System.Windows.Forms;

namespace Presentation.DialogBox.ApplicantEvaluation
{
    public partial class ControlApplicantEvaluation : UserControl
    {
        public EvaluationAnalysis questions;

        public UserControl Previous { get; set; }
        public ControlApplicantEvaluation()
        {
            InitializeComponent();
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            tableLayoutPanel1.ClearAll();
        }
        
        public void LoadData()
        {
            this.questions = new EvaluationAnalysis()
            {
                GreetingToCommittee = cbx_greetings.Text,
                MadeGoodForImpression = cbx_impression.Text,
                Attitude = cbx_attitude.Text,
                DressAppropriately = cbx_dress.Text,
                EyeContact = cbx_eyecontact.Text,
                LevelofInterest = cbx_interest.Text,
                Confidence = cbx_confidence.Text,
                KnowledgeofJob = cbx_knowledge.Text,
                Education = cbx_education.Text,
                RelatedExperience = cbx_experience.Text,
                AnsweredQuestionsWell = cbx_answered_question.Text,
                AnswerFocusonStrength = cbx_strengths.Text,
                TeamSkills = cbx_teamskils.Text,
                CustomerServiceSkill = cbx_csskils.Text,
                CommunicationSkill = cbx_comskils.Text,
                NonVerbal = cbx_nonverbal.Text,
                ListeningSkill = cbx_listeningskills.Text,
                LeadershipSkill  = cbx_leadershipskills.Text,
                CopingAbility = cbx_coping_ability.Text,
                SelfMotivation = cbx_self_motivation.Text,
                Judgement = cbx_judgement.Text,
                Organization = cbx_organization.Text,
                AskedGoodWorkQuestion = cbx_goodwork_question.Text
            };
        }
    }
}
