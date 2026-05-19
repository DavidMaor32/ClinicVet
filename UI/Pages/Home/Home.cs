using ClinicVet.Data.Enums;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.UI.Pages.WorkersPage;

using System.Data;
using System.Security.Cryptography;

namespace ClinicVet.Gui.Pages.Home;

public partial class Home : Form
{
    private readonly Worker currentWorker;
    private readonly WorkerRepository workersRepository;

    public Home(Worker loggedUser)
    {
        InitializeComponent();

        currentWorker = loggedUser;
        workersRepository = new WorkerRepository();

        btnWorkersPage.Click += (sender, e) => OpenForm(new WorkersPage(workersRepository));

        // Add WorkersPage
        // Add AnimalsPage

        if (loggedUser.Role == Role.Vet.Value) { 
            // add ClientsPage
        }

        if (loggedUser.Role == Role.Vet.Value) { 
            // VisitsPage
        }
    }

    private void OpenForm(Form form) {
        form.Show();
        form.FormClosed += (sender, e) => this.Show();
        this.Hide();
    }
}
