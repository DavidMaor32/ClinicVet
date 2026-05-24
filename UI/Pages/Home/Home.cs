using Clinic.Gui.Pages.StaffDashboard;

using ClinicVet.Data.Enums;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.UI.Pages.ClientsPage;
using ClinicVet.UI.Pages.WorkersPage;

namespace ClinicVet.Gui.Pages.Home;

public partial class Home : Form
{
    private readonly Worker currentWorker;
    private readonly WorkerRepository workersRepository;
    private readonly ClientsRepository clientsRepository;
    private readonly AnimalsRepository animalsRepository;

    public Home(Worker loggedUser)
    {
        InitializeComponent();

        currentWorker = loggedUser;
        workersRepository = new WorkerRepository();
        clientsRepository = new ClientsRepository();
        animalsRepository = new AnimalsRepository();

        btnWorkersPage.Click += CreateOpenFormHandler(new WorkersPage(workersRepository));
        btnClientsPage.Click += CreateOpenFormHandler(new ClientsPage(clientsRepository, animalsRepository));

        btnPetsManagement.Click += CreateOpenFormHandler(new staffDashboard(animalsRepository));
        // Add AnimalsPage
        if (loggedUser.Role == Role.Vet.Value) { 
            // add ClientsPage
        }

        if (loggedUser.Role == Role.Secretary.Value) { 
            // VisitsPage
        }
    }

    private EventHandler CreateOpenFormHandler(Form form) {
        return (sender, e) => {
            form.Show();
            form.FormClosed += (sender, e) => this.Show();
            this.Hide();
        };
    }
}
