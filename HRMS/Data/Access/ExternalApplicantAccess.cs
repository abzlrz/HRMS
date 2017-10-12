using System;
using System.ComponentModel;
using Data.Entities;
using System.Data;
using System.Data.SqlClient;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class ExternalApplicantAccess
    {
        public DataTable ShowData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showApplicant";

                adapter.Fill(data);
            }
            return data;
        }

        public DataRow GetEvalDetails(int Id)
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getApplicant_eval_details";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);
                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public DataRow GetApplicantManager(int iD)
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "get_applicant_address";

                adapter.SelectCommand.Parameters.AddWithValue("@id", iD);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public DataRow GetApplicantAddress(int Id)
        {
            DataTable table = new DataTable();
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "get_applicant_address";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public DataRow GetApplicationSource(int Id)
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getApplication_source";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);
                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public bool SaveReapplication(int id, int app_Id, DateTime date)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_insertupdate_applicantReapplication";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@applicant_id", app_Id);
                cmd.Parameters.AddWithValue("@date", date);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public object ShowApplicantShortlisted()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showApplicant_shortlisted";

                adapter.Fill(data);
            }
            return data;
        }

        public DataTable ShowApplicantEvaluated()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showApplicant_evaluated";

                adapter.Fill(data);
            }
            return data;
        }

        public DataTable ShowApplicantRejected()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showApplicant_rejected";

                adapter.Fill(data);
            }
            return data;
        }

        public DataTable ShowApplicantAccepted()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showApplicant_accepted";

                adapter.Fill(data);
            }
            return data;
        }

        public bool SaveInterview(InterviewEvaluation interview)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_insertInterview";

                command.Parameters.AddWithValue("@id", interview.Id);
                command.Parameters.AddWithValue("@applicant_name", interview.Details.ApplicantName);
                command.Parameters.AddWithValue("@hiringmanagerID", interview.Details.HiringManagerID);
                command.Parameters.AddWithValue("@jobtitle", interview.Details.JobTitle);
                command.Parameters.AddWithValue("@titantitle", interview.Details.TitanTitle);
                command.Parameters.AddWithValue("@lang_req", interview.Details.LanguageRequirement);
                command.Parameters.AddWithValue("@bucket", interview.Details.Bucket);
                command.Parameters.AddWithValue("@arvato_level", interview.Details.ArvatoLevel);

                command.Parameters.AddWithValue("@greetings", interview.InterviewQuestions.GreetingToCommittee);
                command.Parameters.AddWithValue("@impression", interview.InterviewQuestions.MadeGoodForImpression);
                command.Parameters.AddWithValue("@attitude", interview.InterviewQuestions.Attitude);
                command.Parameters.AddWithValue("@dress", interview.InterviewQuestions.DressAppropriately);
                command.Parameters.AddWithValue("@eyecontact", interview.InterviewQuestions.EyeContact);
                command.Parameters.AddWithValue("@interest", interview.InterviewQuestions.LevelofInterest);
                command.Parameters.AddWithValue("@confidence", interview.InterviewQuestions.Confidence);
                command.Parameters.AddWithValue("@knowledge", interview.InterviewQuestions.KnowledgeofJob);
                command.Parameters.AddWithValue("@education", interview.InterviewQuestions.Education);
                command.Parameters.AddWithValue("@experience", interview.InterviewQuestions.RelatedExperience);
                command.Parameters.AddWithValue("@answersquestions", interview.InterviewQuestions.AnsweredQuestionsWell);
                command.Parameters.AddWithValue("@strengths", interview.InterviewQuestions.AnswerFocusonStrength);
                command.Parameters.AddWithValue("@skills", interview.InterviewQuestions.TeamSkills);
                command.Parameters.AddWithValue("@cs_skills", interview.InterviewQuestions.CustomerServiceSkill);
                command.Parameters.AddWithValue("@communicationskills", interview.InterviewQuestions.CommunicationSkill);
                command.Parameters.AddWithValue("@nonverbal", interview.InterviewQuestions.NonVerbal);
                command.Parameters.AddWithValue("@leadershipskills", interview.InterviewQuestions.LeadershipSkill);
                command.Parameters.AddWithValue("@listening", interview.InterviewQuestions.ListeningSkill);
                command.Parameters.AddWithValue("@copingability", interview.InterviewQuestions.CopingAbility);
                command.Parameters.AddWithValue("@selfmotivation", interview.InterviewQuestions.SelfMotivation);
                command.Parameters.AddWithValue("@judgement", interview.InterviewQuestions.Judgement);
                command.Parameters.AddWithValue("@organization", interview.InterviewQuestions.Organization);
                command.Parameters.AddWithValue("@goodworkquestions", interview.InterviewQuestions.AskedGoodWorkQuestion);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool SaveResult(int id, string result)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_insert_applicantEvalResult";

                cmd.Parameters.AddWithValue("@applicant_id", id);
                cmd.Parameters.AddWithValue("@result", result);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public bool InsertData(ExternalApplicant applicant)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_insertupdate_external_applicant";
                
                cmd.Parameters.AddWithValue("@firstname", applicant.Applicant.Firstname);
                cmd.Parameters.AddWithValue("@middlename", applicant.Applicant.Middlename);
                cmd.Parameters.AddWithValue("@lastname", applicant.Applicant.Lastname);
                cmd.Parameters.AddWithValue("@nickname", applicant.Applicant.Nickname);
                cmd.Parameters.AddWithValue("@primary_contact_number", applicant.Applicant.PrimaryContactNumber);
                cmd.Parameters.AddWithValue("@secondary_contact_number", applicant.Applicant.SecondaryContactNumber);
                cmd.Parameters.AddWithValue("@is_under18", applicant.Applicant.IsUnder18);
                cmd.Parameters.AddWithValue("@email", applicant.Applicant.Email);
                cmd.Parameters.AddWithValue("@sss", applicant.Applicant.SSS);
                cmd.Parameters.AddWithValue("@tin", applicant.Applicant.TIN);
                cmd.Parameters.AddWithValue("@hdmf", applicant.Applicant.HDMF);
                cmd.Parameters.AddWithValue("@bpi", applicant.Applicant.BankAccount);
                cmd.Parameters.AddWithValue("@app_date", applicant.ApplicationDate);
                cmd.Parameters.AddWithValue("@app_source", applicant.ApplicationSource.Source);
                cmd.Parameters.AddWithValue("@referral_id", applicant.ApplicationSource.ReferralID);
                cmd.Parameters.AddWithValue("@referral_name", applicant.ApplicationSource.ReferralName);
                cmd.Parameters.AddWithValue("@contact_firstname", applicant.Contacts.Firstname);
                cmd.Parameters.AddWithValue("@contact_lastname", applicant.Contacts.Lastname);
                cmd.Parameters.AddWithValue("@ContactNumber", applicant.Contacts.ContactNumber);
                cmd.Parameters.AddWithValue("@relationship", applicant.Contacts.RelationShip);
                cmd.Parameters.AddWithValue("@is_convicted", applicant.LegalConviction.IsConvicted);
                cmd.Parameters.AddWithValue("@Details", applicant.LegalConviction.Details);
                cmd.Parameters.AddWithValue("@education", applicant.EducationHistory);
                cmd.Parameters.AddWithValue("@employment_history", applicant.EmploymentHistory);
                cmd.Parameters.AddWithValue("@is_diagnosed", applicant.Illness.IsDiagnosed);
                cmd.Parameters.AddWithValue("@ill_details", applicant.Illness.Details);
                cmd.Parameters.AddWithValue("@is_lawsuited", applicant.LegalCase.IsLawsuited);
                cmd.Parameters.AddWithValue("@type", applicant.LegalCase.Type);
                cmd.Parameters.AddWithValue("@status", applicant.LegalCase.Status);
                cmd.Parameters.AddWithValue("@is_operated", applicant.MedicalOperation.IsOperated);
                cmd.Parameters.AddWithValue("@operation_details", applicant.MedicalOperation.Details);
                cmd.Parameters.AddWithValue("@permanent_house_no", applicant.PermanentAddress.HouseNo);
                cmd.Parameters.AddWithValue("@permanent_street", applicant.PermanentAddress.Street);
                cmd.Parameters.AddWithValue("@permanent_postal_area", applicant.PermanentAddress.PostalArea);
                cmd.Parameters.AddWithValue("@permanent_postal_no", applicant.PermanentAddress.PostalNo);
                cmd.Parameters.AddWithValue("@perpetual_is_diagnosed", applicant.PerpetualIllness.IsDiagnosed);
                cmd.Parameters.AddWithValue("@perpetual_details", applicant.PerpetualIllness.Details);
                cmd.Parameters.AddWithValue("@position", applicant.ApplicationPosition.PositionTitle);
                cmd.Parameters.AddWithValue("@location", applicant.ApplicationPosition.PreferredSite);
                cmd.Parameters.AddWithValue("@present_address_no", applicant.PresentAddress.HouseNo);
                cmd.Parameters.AddWithValue("@present_street", applicant.PresentAddress.Street);
                cmd.Parameters.AddWithValue("@present_postal_area", applicant.PresentAddress.PostalArea);
                cmd.Parameters.AddWithValue("@present_postal_no", applicant.PresentAddress.PostalNo);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public DataRow GetApplicantByID(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getApplicantID";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public bool DeleteApplicant(int ID)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deleteApplicant";

                cmd.Parameters.AddWithValue("@id", ID);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }
    }
}
