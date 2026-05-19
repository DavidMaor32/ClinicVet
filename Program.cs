using ClinicVet.Data;
using ClinicVet.Gui.Pages.Home;
using ClinicVet.UI.Pages.Login;
using ClinicVet.UI.Pages.WorkersPage;

namespace ClinicVet;

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
        DatabaseConfig.Initialize();
        Application.Run(new Home(null));
    }
}
