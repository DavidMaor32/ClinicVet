using ClinicVet.Data;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Team2
{
    public partial class staffDashboard : Form
    {

        private readonly ClientsRepository clientsRepository = new ClientsRepository();
        private readonly AnimalsRepository animalsRepository = new AnimalsRepository();
        public staffDashboard()
        {
            InitializeComponent();

            InitSearchComboBox();
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

        private void InitSearchComboBox()
        {

            //טעינת שדות לקומבו-בוקס
            comboBoxSearch.Items.Add("name");// if change any name go change it in btnSearch_Click
            comboBoxSearch.Items.Add("chip");

        }


        private void btnAddPet_Click(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }










        //helper funcs ----------------------------------------
        private Boolean IsOnlyLetters(string name)
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


        private Boolean IsOnlyDigits(string chip)
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

        //the handaling funcs assure the argument( name/chip) is valid and if so call the appropriate DB func
        //true if the whole process been done successfuly
        private void handleName(string name)
        {
            if (!(IsOnlyLetters(name)))
            {
                MessageBox.Show(
                "Please enter a valid name.",
                "Invalid name",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                txtSearch.Text = "";
                return;
            }
            animalBindingSource.Clear();


            List<ClinicVet.Data.Models.Animal> find = animalsRepository.GetByName(name);

            if (find.Count == 0) // אין תוצאות
            {
                MessageBox.Show(
               "No animal found.",
               "Invalid name",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error

               );
                dgvPets.DataSource = new List<AnimalDisplay>();
                return;
            }

            dgvPets.AutoGenerateColumns = true;

            var displayAnimals = find.Select(animal =>
            {
                Client owner = clientsRepository.GetAll()
                    .First(c => c._Id == animal.OwnerId);

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

            dgvPets.DataSource = displayAnimals;

        }



        private void handleChip(string chip)
        {

            chip = chip.Trim();

            if (!(IsOnlyDigits(chip)))
            {
                MessageBox.Show(
                "Please enter a valid chip.",
                "Invalid chip ID",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                txtSearch.Text = "";

                return;
            }




            try
            {
                ClinicVet.Data.Models.Animal find = animalsRepository.GetByChipSerial(chip);

                dgvPets.AutoGenerateColumns = true;

                var displayAnimals = new List<AnimalDisplay>();

                Client owner = clientsRepository.GetAll()
                    .First(c => c._Id == find.OwnerId);

                displayAnimals.Add(new AnimalDisplay
                {
                    Name = find.Name,
                    AnimalType = find.AnimalType,
                    Weight = find.Weight,
                    Birthdate = find.Birthdate,
                    LastVaccine = find.LastVaccine,
                    ChipSerial = find.ChipSerial,
                    OwnerNationalId = owner.Id
                });

                dgvPets.AutoGenerateColumns = true;
                dgvPets.DataSource = displayAnimals;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Search failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }









        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchType = comboBoxSearch.Text.Trim().ToLower();
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchType))
            {
                MessageBox.Show("Please choose search type.", "Invalid Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search value.", "Invalid Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    //מחלקה לתצוגה של חיות מחמד בדאטה גריד 
    public class AnimalDisplay
    {
        public string Name { get; set; } = "";
        public string AnimalType { get; set; } = "";
        public double Weight { get; set; }
        public DateOnly Birthdate { get; set; }
        public DateOnly? LastVaccine { get; set; }
        public string ChipSerial { get; set; } = "";

        public string OwnerNationalId { get; set; }="";
    }
}
