namespace Data
{
    static class DBConnection
    {
        public static string ConnectionString = Properties.Settings.Default.ConnectionString;

        static void ChangeConnectionString(string str)
        {
            Properties.Settings.Default.ConnectionString = str;
        }
    }
}
