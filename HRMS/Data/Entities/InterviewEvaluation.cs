using System;

namespace Data.Entities
{
    class InterviewEvaluation
    {
        public EvaluationDetails Details { get; set; }
        public EvaluationAnalysis InterviewQuestions { get; set; }
    }

    class EvaluationDetails
    {
        public int ApplicantID { get; set; }
        public int HiringManagerID { get; set; }
        public string ArvatoLevel { get; set; }
        public string Bucket { get; set; }
        public string TitanLevel { get; set; }
        public bool LanguageRequirement { get; set; }
        public DateTime DateInterviewed { get; set; }
    }

    class EvaluationAnalysis
    {
        public int ApplicantID { get; set; }
        public string Impression { get; set; }
        public string Attitude { get; set; }
        public string Dress { get; set; }
        public string EyeContact { get; set; }
        public string Interest { get; set; }
        public string Confidence { get; set; }
        public string Knowledge { get; set; }
        public string Training { get; set; }
        public string Experience { get; set; }
        public string AnswersQuestions { get; set; }
        public string Strengths { get; set; }
        public string Skills { get; set; }
        public string CS_SKills { get; set; }
        public string CommunicationSkills { get; set; }
        public string NonVerbal { get; set; }
        public string Listening { get; set; }
        public string CopingAbility { get; set; }
        public string SelfMotivation { get; set; }
        public string DecisionMaking { get; set; }
        public string PlanningSkills { get; set; }
        public string GoodWorkQuestions { get; set; }
    }
}
