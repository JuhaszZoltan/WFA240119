namespace WFA240119
{
    internal static class Program
    {
        static internal string connStr = 
            "SERVER=(localdb)\\MSSQLLocalDB;" +
            "DATABASE=koboldbikersdb;";


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}