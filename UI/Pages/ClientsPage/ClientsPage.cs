using ClinicVet.Data;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;

namespace ClinicVet.UI.Pages.ClientsPage;

public partial class ClientsPage : Form
{
    private readonly ClientsRepository clientRepository;
    private readonly AnimalsRepository animalsRepository;

    public ClientsPage(ClientsRepository clientsRepository, AnimalsRepository animalsRepository)
    {
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.SizeGripStyle = SizeGripStyle.Hide;


        MakeInvisibleButton(btnSearch);
        MakeInvisibleButton(btnHome);
        MakeInvisibleButton(btnAddClient);
        MakeInvisibleButton(btnDeleteClient);
        clientRepository = clientsRepository;
        this.animalsRepository = animalsRepository;

        RefreshClients();
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



    private void RefreshClients(string? searchTerm = null)
    {
        var clients = clientRepository.GetAll(searchTerm);
        clientsDataGrid.DataSource = clients;

        if (clientsDataGrid.Columns.Count > 0 && clientsDataGrid.Columns.Contains("_Id"))
        {
            clientsDataGrid.Columns["_Id"]!.Visible = false;
        }

        if (clients.Count > 0)
        {
            clientsDataGrid.Rows[0].Selected = true;
            LoadAnimalsForSelectedClient();
            return;
        }

        animalsDataGrid.DataSource = new List<Animal>();
    }

    private Client? GetSelectedClient()
    {
        return clientsDataGrid.CurrentRow?.DataBoundItem as Client;
    }

    private void LoadAnimalsForSelectedClient()
    {
        var selectedClient = GetSelectedClient();

        if (selectedClient is null)
        {
            animalsDataGrid.DataSource = new List<Animal>();
            return;
        }

        animalsDataGrid.DataSource = animalsRepository.GetAll(selectedClient._Id.ToString());

        if (animalsDataGrid.Columns.Count > 0 && animalsDataGrid.Columns.Contains("_Id"))
        {
            animalsDataGrid.Columns["_Id"]!.Visible = false;
        }
    }

    private void ClearInputs()
    {
        inputId.Text = string.Empty;
        inputFullName.Text = string.Empty;
        inputPhone.Text = string.Empty;
        inputEmail.Text = string.Empty;
    }

    private void btnAddClient_Click(object sender, EventArgs e)
    {
        try
        {
            var newClient = new Client
            {
                Id = inputId.Text.Trim(),
                FullName = inputFullName.Text.Trim(),
                Phone = inputPhone.Text.Trim(),
                Email = inputEmail.Text.Trim()
            };

            bool isValid = ModelValidator.TryValidate(newClient, out List<string> errors);

            if (!isValid)
            {
                throw new Exception(string.Join("\n", errors));
            }

            clientRepository.Add(newClient);
            ClearInputs();
            RefreshClients();
            MessageBox.Show("successfully added");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnDeleteClient_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedClient = GetSelectedClient();

            if (selectedClient is null)
            {
                throw new Exception("Please select a client to delete.");
            }

            clientRepository.Delete(selectedClient.Id);
            RefreshClients();
            MessageBox.Show("successfully deleted");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        RefreshClients(inputSearch.Text.Trim());
    }

    private void btnHome_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void clientsDataGrid_SelectionChanged(object sender, EventArgs e)
    {
        LoadAnimalsForSelectedClient();
    }

    private void inputSearch_TextChanged(object sender, EventArgs e)
    {
        RefreshClients(inputSearch.Text.Trim());
    }

    private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void clientsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void animalsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
