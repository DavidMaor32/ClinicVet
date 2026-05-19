using System.Xml.Linq;

using ClinicVet.Data;
using ClinicVet.Data.Enums;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;

namespace ClinicVet.UI.Pages.WorkersPage;

public partial class WorkersPage : Form {
    private readonly WorkerRepository workerRepository;
    public WorkersPage(WorkerRepository workerRepository) {
        InitializeComponent();

        this.workerRepository = workerRepository;
        updateDataGrid(this.workerRepository.GetAll());
        foreach (var item in Role.All) {
            inputRole.Items.Add(item);
        }
    }

    public void updateDataGrid(List<Worker> workers) {
        workersDataGrid.DataSource = workers;
        workersDataGrid.Columns["_id"]!.Visible = false;
    }

    private void btnAddWorker_Click(object sender, EventArgs e) {
        string username = inputUsername.Text;
        string password = inputPassword.Text;
        string email = inputEmail.Text;
        string workerId = inputWorkId.Text;
        string id = inputId.Text;
        string role = inputRole.Text;

        try {
            Worker newWorker = new Worker {
                Username = username,
                Password = password,
                Email = email,
                WorkerId = workerId,
                Id = id,
                Role = role
            };
            bool isValid = ModelValidator.TryValidate(newWorker, out List<string> errors);

            if (!isValid) {
                throw new Exception(string.Join("\n", errors));
            }

            this.workerRepository.Add(newWorker);
            MessageBox.Show("successfully added");
            updateDataGrid(workerRepository.GetAll());
        }
        catch (Exception ex) {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnHome_Click(object sender, EventArgs e) {
        this.Close();
    }
}
