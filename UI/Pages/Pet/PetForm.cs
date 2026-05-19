namespace ClinicVet.Gui.Pages.Pet;

public partial class PetForm : Form
{
    public PetForm()
    {
        InitializeComponent();
        InitComboBox();
    }

    private void InitComboBox()
    {

        //טעינת שדות לקומבו-בוקס
        CBxPetType.Items.Add("dog");
        CBxPetType.Items.Add("cat");
        CBxPetType.Items.Add("reptile");
        CBxPetType.Items.Add("bird");
    }

   


    private Boolean CheckPetType()
    {
        //להודי לדוד שהשדות רק באותיות קטנות
        string x = CBxPetType.Text.Trim().ToLower();//המרה של קלט שהמשתמש כותב לקומבו -בוקס
        if (!CBxPetType.Items.Contains(x))//אם הערך המוקלד אינו שדה בקומבו-בוקס
        {
            lblPetTaype.Visible = true;
            return false;
        }
        lblPetTaype.Visible = false;
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

    private void btnFinishAddPet_Click(object sender, EventArgs e)
    {

        //השיטה הזו נוחה לקריאה
        //bool validName = CheckPetName(TB_pet_name.Text);
        //bool validType = CheckPetType();
        //bool validWeight = CheckPetWeight(TB_pet_weight.Text);
        //bool validBirth = CheckBirthDate(Date_birth.Value);
        //bool validVacc = CheckLatestVacc(Date_vac.Value, Date_birth.Value);




        //if (validName && validType && validWeight && validBirth && validVacc)
        //{
        //    // Enter to DB. And open/close form
        //}

        //---------השיטה הזו יעילה יותר מבחינת זמן ריצה כי מדובר בשרשור IF
        if (CheckPetName(TB_pet_name.Text) && CheckPetType() &&
            CheckPetWeight(TB_pet_weight.Text) && CheckBirthDate(Date_birth.Value) &&
              CheckLatestVacc(Date_vac.Value, Date_birth.Value))
        {
            //DB staff 'add object ...
        }
        else {
            MessageBox.Show(
            "Please check the highlighted fields.",
            "Invalid Input",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
            );
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
        // MessageBox.Show("CheckLatestVacc entered");

        //לא סומן כפתור
        //if ((!radioButtonNoVacc.Checked && !radioButtonGotVaccine.Checked)
        //    || (radioButtonNoVacc.Checked && radioButtonGotVaccine.Checked))
        //{
        //    X_vaccineVal.Visible = true;

        //    return false;
        //}


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

   

   
    

   

  

    

    

   
}
