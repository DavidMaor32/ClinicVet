using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicVet.Data.Repositories;
using ClinicVet.Data.Models;


namespace Team2
{
    public partial class PetForm : Form
    {
        BindingList<string> animals = new BindingList<string>();
        private readonly AnimalsRepository animalsRepository = new AnimalsRepository();
        private readonly ClientsRepository clientsRepository = new ClientsRepository();
        private readonly AnimalTypesRepository animalTypesRepository = new AnimalTypesRepository();
        public PetForm()
        {
            InitializeComponent();
            intialValues();

           

            catalog.DataSource = animals;
            typeCBx.DataSource = animals;
            InitBlist();

            typeCBx.DropDownStyle = ComboBoxStyle.DropDown;

            typeCBx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            typeCBx.AutoCompleteSource = AutoCompleteSource.ListItems;
            MakeInvisibleButton(btnFinishAddPet);
            MakeInvisibleButton(deleteBtn);
            MakeInvisibleButton(addAnimalBtn);
        }

        private void intialValues()
        {
            TB_pet_name.PlaceholderText = "Only letters allowed";
            TB_pet_weight.PlaceholderText = "Weight must be between 0.1 and 100 kg";
            TB_owner.PlaceholderText = "9 digit numerical code";

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


        private void InitBlist()//הוספת סוגי חיות מהDB לקטלוג ולקומבו בוקס
        {

            animals.Clear();
            List<AnimalType> animalTypes=animalTypesRepository.GetAll();
            foreach (AnimalType type in animalTypes)
            {
                animals.Add(type.Name);
            }
        }


        
        private void typeCBx_TextChanged(object sender, EventArgs e)
        {
            string typed = typeCBx.Text.Trim();

            int index = typeCBx.FindStringExact(typed);

            if (index != -1)
            {
                typeCBx.SelectedIndex = index;
            }
        }

        private Boolean CheckPetType()
        {
            //בדיקה שנבחר אינדקס מתוך הרשימה
            if (typeCBx.SelectedIndex == -1)
            {
                lblPetTaype.Visible = true;
                return false;
            }

            return true;
        }





        private Boolean CheckPetName(string name)
        {
            /*{       מה בדקתי?
             * 1.אם לא הקלידו שם קופץ שגיאה
             * 2.אם לא הקלידו מחרוזת של אותיות
            */
            if (name.Equals(""))   // (1)
            {
                lblPetNameValid.Visible = true;

                return false;
            }

            foreach (char ch in name)  //  (2)
            {
                if (!char.IsLetter(ch))
                {
                    lblPetNameValid.Visible = true;

                    return false;
                }
            }

            lblPetNameValid.Visible = false;
            return true;
        }









        //****************************************************** 

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


        //********************************************************
        private bool CheckOwnerId(string ownerId)
        {
            ownerId = ownerId.Trim();

            if (ownerId == "")
            {
                X_ownerVal.Visible = true;
                return false;
            }

            if (ownerId.Length != 9)
            {
                X_ownerVal.Visible = true;
                return false;
            }

            foreach (char c in ownerId)
            {
                if (!char.IsDigit(c))
                {
                    X_ownerVal.Visible = true;
                    return false;
                }
            }

            X_ownerVal.Visible = false;
            return true;
        }






        private bool IsAnimalFormValid()
        {
            return CheckPetName(TB_pet_name.Text) &&
            CheckPetType() &&
             CheckPetWeight(TB_pet_weight.Text) &&
            CheckBirthDate(Date_birth.Value) &&
            CheckOwnerId(TB_owner.Text) &&
            CheckLatestVacc(Date_vac.Value, Date_birth.Value);

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

            string ownerId = TB_owner.Text.Trim();

            try
            {
                Client owner = clientsRepository.GetById(ownerId);

                ClinicVet.Data.Models.Animal newAnimal = new ClinicVet.Data.Models.Animal
                {
                    Name = TB_pet_name.Text.Trim(),
                    AnimalType = typeCBx.Text.Trim(),
                    Weight = double.Parse(TB_pet_weight.Text),
                    Birthdate = DateOnly.FromDateTime(Date_birth.Value),

                    LastVaccine = radioButtonGotVaccine.Checked
                    ? DateOnly.FromDateTime(Date_vac.Value)
                    : null,
                    OwnerId = owner._Id,
                    ChipSerial = ""
                };

                try
                {
                    animalsRepository.Add(newAnimal);
                   
                    MessageBox.Show(
                        $"Animal added successfully. Chip serial: {newAnimal.ChipSerial}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch
            {
                MessageBox.Show("Owner not found.");
            }
        }




        private Boolean CheckPetWeight(string text)
        {
            double weight;

            // בודק אם בכלל הוקלד מספר
            if (!double.TryParse(text, out weight))
            {
                X_weightVal.Visible = true;
                return false;
            }

            // בודק אם המספר בין 0.1 ל-100
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

            // לא מאפשר לפני שנת 2000
            if (birthDate.Year < 2000)
            {
                X_birthDateVal.Visible = true;
                return false;
            }

            X_birthDateVal.Visible = false;
            return true;
        }




        private bool CheckLatestVacc(DateTime LatestVac, DateTime birthDate)
        {



            if ((radioButtonGotVaccine.Checked &&
                //בדיקה שתאריך החיסון נאחרון לא עתידי או קודם לתאריך הולדת החיה
                (LatestVac.Date >= birthDate.Date && LatestVac.Date <= DateTime.Today))
                ||
                radioButtonNoVacc.Checked)//החיה לא חוסנה
            {
                X_vaccineVal.Visible = false;

                return true;
            }

            MessageBox.Show(
                "invalid vaccine date!  latest vaccine date can't be earlier than" +
                " the animal's birthday or later than today.",

                "Error!  ",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );
            X_vaccineVal.Visible = true;

            return false;
        }

        private void radioButtonGotVaccine_CheckedChanged(object sender, EventArgs e)
        {
            Date_vac.Enabled = true;
        }

        private void radioButtonNoVacc_CheckedChanged(object sender, EventArgs e)
        {
            Date_vac.Enabled = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (catalog.SelectedItem == null)
            {
                MessageBox.Show(
              " you must choose an animal to delete",
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning
              );
                return;
            }
            string selectedTypeName = catalog.SelectedItem.ToString();

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

                InitBlist();

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
            if (newTypeName == "")
            {
                MessageBox.Show(
               " Must enter a value",
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning
               );
                return;
            }



            if (!IsOnlyLetters(newTypeName))
            {
                MessageBox.Show(
                " Must contain only letters",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                animalTypesRepository.Add(newTypeName);

                InitBlist();

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
}
