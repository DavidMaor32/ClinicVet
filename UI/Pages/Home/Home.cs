using Clinic.Gui.Pages.StaffDashboard;

using ClinicVet.Data.Enums;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.UI.Pages.ClientsPage;
using ClinicVet.UI.Pages.WorkersPage;
using ClinicVet.UI.Pages.MedicineManagement;
using ClinicVet.UI.Pages.OpenVisit;
using ClinicVet.UI.Pages.VisitsManagementPage;

namespace ClinicVet.Gui.Pages.Home;

public partial class Home : Form
{
    private readonly Worker currentWorker;
    private readonly WorkerRepository workersRepository;
    private readonly ClientsRepository clientsRepository;
    private readonly AnimalsRepository animalsRepository;
    private readonly MedicineRepository medicineRepository;
    private readonly VisitsRepository visitsRepository;

    public Home(Worker loggedUser)
    {
        InitializeComponent();

        hideBtns();
        currentWorker = loggedUser;
        workersRepository = new WorkerRepository();
        clientsRepository = new ClientsRepository();
        animalsRepository = new AnimalsRepository();
        medicineRepository = new MedicineRepository();
        visitsRepository = new VisitsRepository();


        btnWorkersPage.Click += CreateOpenFormHandler(() => new WorkersPage(workersRepository));
        btnClientsPage.Click += CreateOpenFormHandler(() => new ClientsPage(clientsRepository, animalsRepository));

        btnPetsManagement.Click += CreateOpenFormHandler(() => new staffDashboard(animalsRepository));
        btnVisitsPage.Click += null;
        btnMedicinePage.Click += CreateOpenFormHandler(() => new MedicineManagementPage(medicineRepository));
        btnViewVisits.Click += CreateOpenFormHandler(() => new VisitsManagementPage(visitsRepository));

        // Add AnimalsPage
        if (loggedUser.Role == Role.Vet.Value)
        {
            // add ClientsPage
            btnVisitsPage.Click += CreateOpenFormHandler(() => new OpenVisit(medicineRepository, animalsRepository, visitsRepository, currentWorker));
        }

        if (loggedUser.Role == Role.Secretary.Value)
        {
            // VisitsPage
        }
    }


    public static void MakeInvisibleButton(Button btn)
    {
        btn.Visible = true;
        btn.Enabled = true;

        btn.Text = "";
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent;

        btn.BackColor = Color.Transparent;
        btn.UseVisualStyleBackColor = false;
        btn.BringToFront();
    }
    private void hideBtns()
    {
        MakeInvisibleButton(btnWorkersPage);
        MakeInvisibleButton(btnClientsPage);
        MakeInvisibleButton(btnPetsManagement);
        MakeInvisibleButton(btnVisitsPage);
        MakeInvisibleButton(btnMedicinePage);
        MakeInvisibleButton(btnViewVisits);
    }



    private EventHandler CreateOpenFormHandler(Func<Form> createForm)
    {
        return (sender, e) =>
        {
            Form form = createForm();
            form.Show();
            form.FormClosed += (sender, e) => this.Show();
            this.Hide();
        };
    }




}
