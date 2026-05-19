using ClinicVet.Data;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.Gui.Pages.Home;

namespace ClinicVet.UI.Pages.Login; 

public partial class Login : Form {
    private readonly WorkerRepository workerRepository;
    public Login() {
        InitializeComponent();

        workerRepository = new WorkerRepository();
    }

    private void button1_Click(object sender, EventArgs e) {
        try {
            Worker worker = workerRepository.Login(inputName.Text.ToString().Trim(), inputPassword.Text.ToString().Trim());

            bool isValid = ModelValidator.TryValidate(worker, out List<string> errors);

            if (!isValid) {
                throw new Exception(string.Join("\n", errors));
            }

            Form homePage = new Home(worker);
            homePage.FormClosed += (sender, e) => this.Close();
            homePage.Show();
            this.Hide();
        }
        catch (Exception error) {
            MessageBox.Show(error.Message);
        }
    }

    private void TogglePasswordVisible_CheckedChanged(object sender, EventArgs e) {
        inputPassword.UseSystemPasswordChar = !inputPassword.UseSystemPasswordChar;
    }
}
