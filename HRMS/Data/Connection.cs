namespace Data
{
    static class DB
    {
        public static string ConnectionString = Properties.Settings.Default.ConnectionString;

        //USER SCHEMA
        public static string LoginUser = "[User].[sp_login]";
        public static string PopulateUser = "[User].[sp_populateUser]";
        public static string ChangePassword = "[User].[sp_changePassword]";

        //EXTERNAL APPLICANT SCHEMA
        public static string InsertApplicant = "[ExternalApplicant].[sp_insert]";
    }
}
