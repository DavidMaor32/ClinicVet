using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.UI.Pages.PriceSummary;

namespace ClinicVet.UI.Pages.OpenVisit;

public partial class OpenVisit : Form
{
    private readonly AnimalsRepository animalsRepository;
    private readonly MedicineRepository medicineRepository;
    private readonly List<PrescribedMedicine> selectedMedicines;
    private List<Animal> animals;
    private readonly VisitsRepository visitsRepository;
    private readonly Worker practitioner;

    public OpenVisit(MedicineRepository medicineRepository, AnimalsRepository animalsRepository, VisitsRepository visitsRepository, Worker paractitioner)
    {
        InitializeComponent();

        this.animalsRepository = animalsRepository;
        this.medicineRepository = medicineRepository;
        selectedMedicines = new List<PrescribedMedicine>();
        this.visitsRepository = visitsRepository;
        this.practitioner = paractitioner;

        pracName.Text = paractitioner.Username;

        LoadMedicines();
        LoadPets();
        UpdateVaccineLabel();

        petComboBox.SelectedIndexChanged += (sender, e) =>
        {
            UpdateVaccineLabel();
        };
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(VisitTextBox.Text))
        {
            MessageBox.Show("Please enter visit reason");
            return;
        }

        if (string.IsNullOrWhiteSpace(diagnosisTextBox.Text))
        {
            MessageBox.Show("Please enter diagnosis");
            return;
        }

        Animal selectedAnimal = animals[petComboBox.SelectedIndex];

        Visit visit = new Visit
        {
            AnimalId = selectedAnimal._Id,
            Reason = VisitTextBox.Text,
            DateTime = DateTime.Now,
            Diagnosis = diagnosisTextBox.Text,
            VetWorkerId = practitioner.WorkerId,
            PrescribedMedicines = selectedMedicines
        };

        try
        {
            visitsRepository.Add(visit);

            MessageBox.Show("Visit saved successfully");

            PriceSummaryPage summaryForm = new PriceSummaryPage(visit);
            summaryForm.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void LoadMedicines()
    {
        medicineComboBox.Items.Clear();

        List<Medicine> medicines = medicineRepository.GetAll();

        foreach (Medicine medicine in medicines)
        {
            medicineComboBox.Items.Add(medicine.Name);
        }
    }

    private void LoadPets()
    {
        petComboBox.Items.Clear();

        animals = animalsRepository.GetAll();

        foreach (Animal animal in animals)
        {
            petComboBox.Items.Add(animal.Name);
        }

        if (petComboBox.Items.Count > 0)
        {
            petComboBox.SelectedIndex = 0;
        }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (medicineComboBox.SelectedItem == null)
        {
            MessageBox.Show("Please select medicine");
            return;
        }

        string medicineName = medicineComboBox.SelectedItem.ToString()!;
        int quantity = (int)quantityNum.Value;

        try
        {
            PrescribedMedicine medicine = medicineRepository.Prescribe(
                medicineName,
                quantity
            );

            selectedMedicines.Add(medicine);

            medicineListBox.Items.Add(
                $"{medicine.MedicineName} x{medicine.Quantity} = {medicine.TotalPrice}"
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void UpdateVaccineLabel()
    {
        if (petComboBox.SelectedIndex < 0 || animals == null)
        {
            vaccineLabel.Text = "";
            return;
        }

        Animal selectedAnimal = animals[petComboBox.SelectedIndex];

        DateTime lastVaccineDate = selectedAnimal.LastVaccine.ToDateTime(TimeOnly.MinValue);

        if (lastVaccineDate >= DateTime.Now.AddYears(-1))
        {
            vaccineLabel.Text = "Vaccinated this past year";
        }
        else
        {
            vaccineLabel.Text = "Not vaccinated this past year";
        }
    }

    private void OpenVisit_Load(object sender, EventArgs e)
    {

    }
}