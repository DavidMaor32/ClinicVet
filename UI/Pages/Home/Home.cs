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
    }

    private void OpenForm(Form form) {
        form.Show();
        form.FormClosed += (sender, e) => this.Show();
        this.Hide();
    }
}
