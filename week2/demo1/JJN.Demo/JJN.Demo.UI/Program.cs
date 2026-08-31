namespace JJN.Demo.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Disable dpi scaling
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);

            Application.Run(new frmWinMain());
        }
    }
}