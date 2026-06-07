using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.Gui.Pages.Pet;

namespace Clinic.Gui.Pages.StaffDashboard;

public partial class staffDashboard : Form
{
    private readonly AnimalsRepository animalsRepository;
    private readonly ClientsRepository clientsRepository;

    public staffDashboard(AnimalsRepository animalsRepository)
    {
        this.animalsRepository = animalsRepository;
        clientsRepository = new ClientsRepository();

        InitializeComponent();
        InitializeAndDesign();




    }

    private void InitializeAndDesign()
    {
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.SizeGripStyle = SizeGripStyle.Hide;

        InitSearchComboBox();
        ConfigurePetsGrid();

        MakeInvisibleButton(btnSearch);
        MakeInvisibleButton(btnAddPet);

    }


    private void MakeInvisibleButton(Button btn)
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




    private void ConfigurePetsGrid()
    {
        dgvPets.AutoGenerateColumns = true;
        dgvPets.Columns.Clear();
        dgvPets.DataSource = new List<AnimalDisplay>();
    }

    private void InitSearchComboBox()
    {
        comboBoxSearch.Items.Add("name");
        comboBoxSearch.Items.Add("chip");
    }

    private void staffDashboard_Load(object sender, EventArgs e)
    {
        dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void btnAddPet_Click(object sender, EventArgs e)
    {
        PetForm petForm = new PetForm(animalsRepository);
        petForm.ShowDialog();
    }

    private bool IsOnlyLetters(string name)
    {
        foreach (char ch in name)
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }
        }

        return true;
    }

    private bool IsOnlyDigits(string chip)
    {
        foreach (char ch in chip)
        {
            if (!char.IsDigit(ch))
            {
                return false;
            }
        }

        return true;
    }

    private void handleName(string name)
    {
        if (!IsOnlyLetters(name))
        {
            MessageBox.Show(
                "Please enter a valid name.",
                "Invalid name",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            txtSearch.Text = string.Empty;
            return;
        }

        List<Animal> foundAnimals = animalsRepository.GetByName(name);

        if (foundAnimals.Count == 0)
        {
            dgvPets.DataSource = new List<AnimalDisplay>();
            MessageBox.Show(
                "No animal found.",
                "Invalid name",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        dgvPets.DataSource = MapToDisplayAnimals(foundAnimals);
    }

    private void handleChip(string chip)
    {
        chip = chip.Trim();

        if (!IsOnlyDigits(chip))
        {
            MessageBox.Show(
                "Please enter a valid chip.",
                "Invalid chip ID",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            txtSearch.Text = string.Empty;
            return;
        }

        try
        {
            Animal foundAnimal = animalsRepository.GetByChipSerial(chip);
            dgvPets.DataSource = MapToDisplayAnimals(new List<Animal> { foundAnimal });
        }
        catch (Exception ex)
        {
            dgvPets.DataSource = new List<AnimalDisplay>();
            MessageBox.Show(
                ex.Message,
                "Search failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private List<AnimalDisplay> MapToDisplayAnimals(List<Animal> animals)
    {
        List<Client> clients = clientsRepository.GetAll();

        return animals.Select(animal =>
        {
            Client owner = clients.First(c => c._Id == animal.OwnerId);

            return new AnimalDisplay
            {
                Name = animal.Name,
                AnimalType = animal.AnimalType,
                Weight = animal.Weight,
                Birthdate = animal.Birthdate,
                LastVaccine = animal.LastVaccine,
                ChipSerial = animal.ChipSerial,
                OwnerNationalId = owner.Id
            };
        }).ToList();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string searchType = comboBoxSearch.Text.Trim().ToLower();
        string searchValue = txtSearch.Text.Trim();

        if (string.IsNullOrEmpty(searchType))
        {
            MessageBox.Show(
                "Please choose search type.",
                "Invalid Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (string.IsNullOrEmpty(searchValue))
        {
            MessageBox.Show(
                "Please enter a search value.",
                "Invalid Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (searchType == "name")
        {
            handleName(searchValue);
        }
        else if (searchType == "chip")
        {
            handleChip(searchValue);
        }
        else
        {
            MessageBox.Show(
                "Please choose search type: name or chip.",
                "Invalid Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }

    

    
}

public class AnimalDisplay
{
    public string Name { get; set; } = string.Empty;
    public string AnimalType { get; set; } = string.Empty;
    public double Weight { get; set; }
    public DateOnly Birthdate { get; set; }
    public DateOnly? LastVaccine { get; set; }
    public string ChipSerial { get; set; } = string.Empty;
    public string OwnerNationalId { get; set; } = string.Empty;
}
