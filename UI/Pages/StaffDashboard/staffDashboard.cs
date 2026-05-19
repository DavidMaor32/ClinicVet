using ClinicVet.Gui.Pages.Pet;
using ClinicVet.Gui.Pages.PetCatalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clinic.Gui.Pages.StaffDashboard;

public partial class staffDashboard : Form
{
    private List<Animal> animals = new List<Animal>();
    public staffDashboard()
    {
        InitializeComponent();
        InitSearchComboBox();

    }

    private void InitSearchComboBox()
    {

        //טעינת שדות לקומבו-בוקס
        comboBoxSearch.Items.Add("name");// if change any name go change it in btnSearch_Click
        comboBoxSearch.Items.Add("chip");

    }

    private void staffDashboard_Load(object sender, EventArgs e)
    {
        //אתחול רשימת אובייקטים סטטים לרשימה בדאשבורד
        //animals.Add(new Animal("Moka", "Dog", 12.5, "123456"));
        //animals.Add(new Animal("Luna", "Cat", 4.2, "789101"));

        dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPets.DataSource = animals;
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
        }
        //---success scenario---:

        List<Animal> find = null; //call db func search by chip ID; -> db.searchByName(chip)
        foreach (Animal animal in find)
        {
            animalBindingSource.Add(animal);
        }
    }


    private void ShowAnimal(Animal animal)
    {
        animalBindingSource.Add(animal);
    }

    private void handleChip(string chip)
    {
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
        //---success scenario---:
        //animal find is the reurned object from the searchDB funtion

        //Aniaml find=Search(chip)
        //****מימוש פונקציה, SEARCHDB->DAVID

        Animal find = new Animal("hey", "dog", 15, "645498"); //call db func search by chip ID; -> db.search(chip)
        if (find == null)
        {
            MessageBox.Show(
            "chip doesn't exist in the system, please try again!",
            "chip not found",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
            );

            return;
        }

        ShowAnimal(find);
    }



    //-----------end of helper funcs







    private void btnSearch_Click(object sender, EventArgs e)
    {
        //string
        string x = comboBoxSearch.Text.Trim().ToLower();//המרה של קלט שהמשתמש כותב לקומבו -בוקס

        foreach (string item in comboBoxSearch.Items)
        {
            if (comboBoxSearch.SelectedItem == null)
            {

                MessageBox.Show("null");
            }
            else if (item.Equals(comboBoxSearch.SelectedItem.ToString()))
            {
                if (item.Equals("name"))
                {
                    handleName(txtSearch.Text);
                }



                else if (item.Equals("chip"))
                {
                    handleChip(txtSearch.Text);
                }
                else { MessageBox.Show("error"); }
            }
        }


        //פונקציות handle  מחזירות true/false אינדיקציה לתהליך מוצלח



    }



    private void button1_Click(object sender, EventArgs e)
    {
        PetCatalogForm petCatalogForm = new PetCatalogForm();
        petCatalogForm.ShowDialog();
    }

    private void DgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Label4_Click(object sender, EventArgs e)
    {

    }
}


public class Animal(string name, string type, double weight, string chipNumber) {
    public string Name { get; set; } = name;
    public string Type { get; set; } = type;
    public double Weight { get; set; } = weight;
    public string ChipNumber { get; set; } = chipNumber;
}
