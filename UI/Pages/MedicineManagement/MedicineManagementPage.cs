using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;

namespace ClinicVet.UI.Pages.MedicineManagement;

public partial class MedicineManagementPage : Form {
    private readonly MedicineRepository medicineRepository;
    private string selectedMedicineName = "";

    public MedicineManagementPage(MedicineRepository medicineRepository) {
        InitializeComponent();

        this.medicineRepository = medicineRepository;

        LoadMedicines();

        medicineGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        medicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        medicineGridView.MultiSelect = false;
        medicineGridView.ReadOnly = true;
    }

    private void LoadMedicines() {
        List<Medicine> medicines = medicineRepository.GetAll();

        medicineGridView.DataSource = null;

        medicineGridView.DataSource = medicines;
    }

    private void refreshButton_Click(object sender, EventArgs e) {
        LoadMedicines();
    }

    private void addMedButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrWhiteSpace(medNameAddTextBox.Text)) {
            MessageBox.Show("Please enter medicine name");
            return;
        }

        try {
            Medicine medicine = new Medicine {
                Name = medNameAddTextBox.Text.Trim(),
                Quantity = (int)quantityAddNumeric.Value,
                Price = (double)priceAddNumeric.Value
            };

            medicineRepository.Add(medicine);

            MessageBox.Show("Medicine added successfully");

            LoadMedicines();
            ClearAddFields();
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }

    private void clearButton_Click(object sender, EventArgs e) {
        ClearAddFields();
    }

    private void ClearAddFields() {
        medNameAddTextBox.Clear();
        quantityAddNumeric.Value = 0;
        priceAddNumeric.Value = 0;
    }

    private void medicineGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0)
            return;

        DataGridViewRow row = medicineGridView.Rows[e.RowIndex];

        selectedMedicineName = row.Cells["Name"].Value.ToString()!;

        medNameSelectedTextBox.Text = selectedMedicineName;

        quantitySelectedNumeric.Value =
            Convert.ToDecimal(row.Cells["Quantity"].Value);

        priceSelectedNumeric.Value =
            Convert.ToDecimal(row.Cells["Price"].Value);
    }

    private void deleteButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrWhiteSpace(medNameSelectedTextBox.Text)) {
            MessageBox.Show("Please select medicine");
            return;
        }

        medicineRepository.Delete(medNameSelectedTextBox.Text);
        LoadMedicines();
        ClearSelectedFields();
    }

    private void ClearSelectedFields() {
        medNameSelectedTextBox.Clear();
        quantitySelectedNumeric.Value = 0;
        priceSelectedNumeric.Value = 0;
    }

    private void updateButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrWhiteSpace(selectedMedicineName)) {
            MessageBox.Show("Please select medicine");
            return;
        }

        try {
            Medicine updatedMedicine = new Medicine {
                Name = medNameSelectedTextBox.Text.Trim(),
                Quantity = (int)quantitySelectedNumeric.Value,
                Price = (double)priceSelectedNumeric.Value
            };

            medicineRepository.Update(selectedMedicineName, updatedMedicine);

            MessageBox.Show("Medicine updated successfully");

            LoadMedicines();

            selectedMedicineName = "";

            ClearSelectedFields();
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }
}
