using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using System.ComponentModel;

namespace ClinicVet.Gui.Pages.Pet;

public partial class PetForm : Form
{
    private readonly BindingList<string> animalTypes = new BindingList<string>();
    private readonly AnimalsRepository animalsRepository;
    private readonly ClientsRepository clientsRepository;
    private readonly AnimalTypesRepository animalTypesRepository;

    public PetForm(AnimalsRepository animalsRepository)
    {
        this.animalsRepository = animalsRepository;
        clientsRepository = new ClientsRepository();
        animalTypesRepository = new AnimalTypesRepository();

        InitializeComponent();
        InitializeInputs();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.SizeGripStyle = SizeGripStyle.Hide;

        catalog.DataSource = animalTypes;
        CBxPetType.DataSource = animalTypes;
        LoadAnimalTypes();
        MakeInvisibleButton(btnFinishAddPet);
        MakeInvisibleButton(deleteBtn);
        MakeInvisibleButton(addAnimalBtn);
        CBxPetType.DropDownStyle = ComboBoxStyle.DropDown;
        CBxPetType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        CBxPetType.AutoCompleteSource = AutoCompleteSource.ListItems;
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


    private void InitializeInputs()
    {
        TB_pet_name.PlaceholderText = "Only letters allowed";
        TB_pet_weight.PlaceholderText = "Weight must be between 0.1 and 100 kg";
        TB_owner.PlaceholderText = "9 digit owner ID";
        Date_vac.Visible = false;
    }

    private void LoadAnimalTypes()
    {
        animalTypes.Clear();

        foreach (AnimalType type in animalTypesRepository.GetAll())
        {
            animalTypes.Add(type.Name);
        }
    }

    private bool CheckPetType()
    {
        if (CBxPetType.SelectedIndex == -1)
        {
            lblPetTaype.Visible = true;
            return false;
        }

        lblPetTaype.Visible = false;
        return true;
    }

    private void CBxPetType_TextChanged(object sender, EventArgs e)
    {
        string typed = CBxPetType.Text.Trim();

        int index = CBxPetType.FindStringExact(typed);

        if (index != -1)
        {
            CBxPetType.SelectedIndex = index;
        }
    }

    private bool CheckPetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            lblPetNameValid.Visible = true;
            return false;
        }

        bool isOnlyLetters = name.All(char.IsLetter);

        lblPetNameValid.Visible = !isOnlyLetters;
        return isOnlyLetters;
    }

    private bool IsOnlyLetters(string value)
    {
        return value.All(char.IsLetter);
    }

    private bool CheckOwnerId(string ownerId)
    {
        ownerId = ownerId.Trim();

        if (ownerId.Length != 9 || ownerId.Any(ch => !char.IsDigit(ch)))
        {
            X_ownerVal.Visible = true;
            return false;
        }

        X_ownerVal.Visible = false;
        return true;
    }

    private void btnFinishAddPet_Click(object sender, EventArgs e)
    {
        if (!IsAnimalFormValid())
        {
            MessageBox.Show(
                "Please check the highlighted fields.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        try
        {
            Client owner = clientsRepository.GetById(TB_owner.Text.Trim());

            Animal newAnimal = new Animal
            {
                Name = TB_pet_name.Text.Trim(),
                AnimalType = CBxPetType.Text.Trim(),
                Weight = double.Parse(TB_pet_weight.Text),
                Birthdate = DateOnly.FromDateTime(Date_birth.Value),
                LastVaccine = radioButtonGotVaccine.Checked
                    ? DateOnly.FromDateTime(Date_vac.Value)
                    : null,
                OwnerId = owner._Id,
                ChipSerial = string.Empty
            };

            animalsRepository.Add(newAnimal);

            MessageBox.Show(
                $"Animal added successfully. Chip serial: {newAnimal.ChipSerial}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Add Animal Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private bool IsAnimalFormValid()
    {
        return
            CheckPetName(TB_pet_name.Text) &&
            CheckPetType() &&
            CheckPetWeight(TB_pet_weight.Text) &&
            CheckBirthDate(Date_birth.Value) &&
            CheckOwnerId(TB_owner.Text) &&
            CheckLatestVacc(Date_vac.Value, Date_birth.Value);
    }

    private bool CheckPetWeight(string text)
    {
        if (!double.TryParse(text, out double weight))
        {
            X_weightVal.Visible = true;
            return false;
        }

        if (weight < 0.1 || weight > 100)
        {
            X_weightVal.Visible = true;
            return false;
        }

        X_weightVal.Visible = false;
        return true;
    }

    private bool CheckBirthDate(DateTime birthDate)
    {
        if (birthDate > DateTime.Now)
        {
            X_birthDateVal.Visible = true;
            return false;
        }

        if (birthDate.Year < 2000)
        {
            X_birthDateVal.Visible = true;
            return false;
        }

        X_birthDateVal.Visible = false;
        return true;
    }

    private bool CheckLatestVacc(DateTime latestVac, DateTime birthDate)
    {
        if ((radioButtonGotVaccine.Checked &&
            latestVac.Date >= birthDate.Date &&
            latestVac.Date <= DateTime.Today) ||
            radioButtonNoVacc.Checked)
        {
            X_vaccineVal.Visible = false;
            return true;
        }

        MessageBox.Show(
            "invalid vaccine date!  latest vaccine date can't be earlier than the animal's birthday or later than today.",
            "Error!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        X_vaccineVal.Visible = true;
        return false;
    }

    private void radioButtonGotVaccine_CheckedChanged(object sender, EventArgs e)
    {
        Date_vac.Enabled = radioButtonGotVaccine.Checked;
        Date_vac.Visible = radioButtonGotVaccine.Checked;
    }

    private void radioButtonNoVacc_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonNoVacc.Checked)
        {
            Date_vac.Enabled = false;
            Date_vac.Visible = false;
            X_vaccineVal.Visible = false;
        }
    }

  

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        if (catalog.SelectedItem == null)
        {
            MessageBox.Show(
                "you must choose an animal type to delete",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string selectedTypeName = catalog.SelectedItem.ToString() ?? string.Empty;

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

    private void addAnimalBtn_Click(object sender, EventArgs e)
    {
        addTxtBx.Enabled = true;
        addTxtBx.Visible = true;

        DoneBtn.Enabled = true;
        DoneBtn.Visible = true;
    }

    private void DoneBtn_Click(object sender, EventArgs e)
    {
        string newTypeName = addTxtBx.Text.Trim();

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

        if (!IsOnlyLetters(newTypeName))
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
            LoadAnimalTypes();
            addTxtBx.Clear();

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
}
