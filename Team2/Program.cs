using ClinicVet.Data;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
namespace Team2
    
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
            DatabaseConfig.Initialize();

            // TEMP TEST DATA - remove before submission
            var clientsRepository = new ClientsRepository();

            try
            {
                clientsRepository.GetById("123456789");
            }
            catch
            {
                var testClient = new Client
                {
                    Id = "123456789",
                    FullName = "Test Owner",
                    Phone = "0501234567",
                    Email = "test.owner@example.com"
                };

                clientsRepository.Add(testClient);
            }
            Application.Run(new staffDashboard());

            //end of test data setup
        }



    }
}