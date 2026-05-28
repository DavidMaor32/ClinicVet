using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using ClinicVet.UI.Pages.PriceSummary;

namespace ClinicVet.UI.Pages.OpenVisit;

public partial class OpenVisit : Form
{

    private readonly MedicineRepository medicineRepository;
    private readonly List<PrescribedMedicine> selectedMedicines;

    public OpenVisit(MedicineRepository medicineRepository)
    {
        InitializeComponent();

        this.medicineRepository = medicineRepository;

        selectedMedicines = new List<PrescribedMedicine>();

        LoadMedicines();
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

        Visit visit = new Visit
        {
            Reason = VisitTextBox.Text,
            Diagnosis = diagnosisTextBox.Text,
            VetWorkerId = pracName.Text,
            AnimalId = 1,
            PrescribedMedicines = selectedMedicines
        };

        PriceSummaryPage summaryForm = new PriceSummaryPage(visit);
        summaryForm.Show();
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
}