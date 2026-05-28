using ClinicVet.Data.Repositories;

namespace ClinicVet.Gui.Pages.PetCatalog;

public partial class PetCatalogForm : Form
{
    private readonly AnimalTypesRepository animalTypesRepository;

    public PetCatalogForm(AnimalsRepository animalsRepository)
    {
        animalTypesRepository = new AnimalTypesRepository();
        InitializeComponent();
        LoadAnimalTypes();
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string newTypeName = textBox1.Text.Trim();

        if (string.IsNullOrEmpty(newTypeName))
        {
            MessageBox.Show(
                "Must enter a value",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!newTypeName.All(char.IsLetter))
        {
            MessageBox.Show(
                "Must contain only letters",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        try
        {
            animalTypesRepository.Add(newTypeName);
            textBox1.Clear();
            LoadAnimalTypes();

            MessageBox.Show(
                "Animal type added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null)
        {
            MessageBox.Show(
                "You must choose an animal type to delete",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string selectedTypeName = listBox1.SelectedItem.ToString() ?? string.Empty;

        DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete '{selectedTypeName}'?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            animalTypesRepository.Delete(selectedTypeName);
            LoadAnimalTypes();

            MessageBox.Show(
                "Animal type deleted successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Delete Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void LoadAnimalTypes()
    {
        listBox1.DataSource = null;
        listBox1.DataSource = animalTypesRepository.GetAll().Select(type => type.Name).ToList();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }
}
