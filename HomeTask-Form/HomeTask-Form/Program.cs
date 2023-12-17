namespace HomeTask_Form
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

            Employee_Management_System sys = new Employee_Management_System();
            Main main = new Main(sys);

            Application.Run(main);
        }
    }
}