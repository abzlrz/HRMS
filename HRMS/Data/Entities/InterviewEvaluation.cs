using System;

namespace Data.Entities
{
    public class InterviewEvaluation
    {
        public EvaluationDetails Details { get; set; } = new EvaluationDetails();
        public EvaluationAnalysis InterviewQuestions { get; set; } = new EvaluationAnalysis();
        public int Id { get; set; }
    }

    public class EvaluationDetails
    {
        public int HiringManagerID { get; set; }
        public string ArvatoLevel { get; set; }
        public string Bucket { get; set; }
        public string TitanTitle { get; set; }
        public bool LanguageRequirement { get; set; }
        public DateTime DateInterviewed { get; set; }
        public string JobTitle { get; set; }
        public string ApplicantName { get; set; }
    }

    public class EvaluationAnalysis
    {
        public int ApplicantID { get; set; }
        public string GreetingToCommittee { get; set; }
        public string MadeGoodForImpression { get; set; }
        public string Attitude { get; set; }
        public string DressAppropriately { get; set; }
        public string EyeContact { get; set; }
        public string LevelofInterest { get; set; }
        public string Confidence { get; set; }
        public string KnowledgeofJob { get; set; }
        public string Education { get; set; }
        public string RelatedExperience { get; set; }
        public string AnsweredQuestionsWell { get; set; }
        public string AnswerFocusonStrength { get; set; }
        public string TeamSkills { get; set; }
        public string CustomerServiceSkill { get; set; }
        public string CommunicationSkill { get; set; }
        public string NonVerbal { get; set; }
        public string ListeningSkill { get; set; }
        public string LeadershipSkill { get; set; }
        public string CopingAbility { get; set; }
        public string SelfMotivation { get; set; }
        public string Judgement { get; set; }
        public string Organization { get; set; }
        public string AskedGoodWorkQuestion { get; set; }
    }
}
